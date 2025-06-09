using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LGSTrackingApp
{
    public partial class PerformanceTrack : Form
    {
        private string connectionString = @"Server=DEDEOGLU\SQLEXPRESS;Database=LGSTrackerDB;Trusted_Connection=True;";

        public PerformanceTrack()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            cmbStudentsP.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID, Name + ' ' + Surname AS FullName FROM Students", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbStudentsP.Items.Add(new ComboBoxItem
                    {
                        Text = reader["FullName"].ToString(),
                        Value = (int)reader["StudentID"]
                    });
                }
            }
            if (cmbStudentsP.Items.Count > 0)
                cmbStudentsP.SelectedIndex = 0;
        }

        private void btnSelectedExam_Click(object sender, EventArgs e)
        {
            if (cmbStudentsP.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            string examName = txtBoxExamName.Text.Trim();
            if (string.IsNullOrWhiteSpace(examName))
            {
                MessageBox.Show("Please enter an exam name.");
                return;
            }

            var selectedStudent = (ComboBoxItem)cmbStudentsP.SelectedItem;
            int studentId = selectedStudent.Value;

            chartPerformanceAdmin.Series.Clear();
            chartPerformanceAdmin.ChartAreas.Clear();
            chartPerformanceAdmin.ChartAreas.Add(new ChartArea("SelectedExam"));

            Series series = new Series("Net")
            {
                ChartType = SeriesChartType.Column,
                BorderWidth = 2,
                IsValueShownAsLabel = true,
                LabelFormat = "F1"
            };
            chartPerformanceAdmin.Series.Add(series);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT MatematikNet, TürkçeNet, FenBilimleriNet, İngilizceNet, İnkılapTarihiNet, DinKültürüNet
                                                 FROM Exams
                                                 WHERE StudentID = @StudentID AND ExamName = @ExamName", con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@ExamName", examName);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    series.Points.AddXY("Matematik", Math.Round(Convert.ToDouble(reader["MatematikNet"]), 1));
                    series.Points.AddXY("Türkçe", Math.Round(Convert.ToDouble(reader["TürkçeNet"]), 1));
                    series.Points.AddXY("Fen", Math.Round(Convert.ToDouble(reader["FenBilimleriNet"]), 1));
                    series.Points.AddXY("İngilizce", Math.Round(Convert.ToDouble(reader["İngilizceNet"]), 1));
                    series.Points.AddXY("İnkılap", Math.Round(Convert.ToDouble(reader["İnkılapTarihiNet"]), 1));
                    series.Points.AddXY("Din", Math.Round(Convert.ToDouble(reader["DinKültürüNet"]), 1));
                }
                else
                {
                    MessageBox.Show("Exam not found.");
                }
            }
        }

        private void btnAllExamsA_Click(object sender, EventArgs e)
        {
            if (cmbStudentsP.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            var selectedStudent = (ComboBoxItem)cmbStudentsP.SelectedItem;
            int studentId = selectedStudent.Value;

            chartPerformanceAdmin.Series.Clear();
            chartPerformanceAdmin.ChartAreas.Clear();
            chartPerformanceAdmin.ChartAreas.Add(new ChartArea("AllExams"));

            string[] dersler = { "MatematikNet", "TürkçeNet", "FenBilimleriNet", "İngilizceNet", "İnkılapTarihiNet", "DinKültürüNet" };
            foreach (string ders in dersler)
            {
                Series series = new Series(ders)
                {
                    ChartType = SeriesChartType.Column,
                    BorderWidth = 2,
                    IsValueShownAsLabel = true,
                    LabelFormat = "F1"
                };
                chartPerformanceAdmin.Series.Add(series);
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT ExamName, MatematikNet, TürkçeNet, FenBilimleriNet, İngilizceNet, İnkılapTarihiNet, DinKültürüNet
                                                 FROM Exams
                                                 WHERE StudentID = @StudentID AND ExamName IS NOT NULL
                                                 ORDER BY ExamDate", con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                SqlDataReader reader = cmd.ExecuteReader();
                bool hasData = false;
                while (reader.Read())
                {
                    hasData = true;
                    string examName = reader["ExamName"].ToString();
                    foreach (string ders in dersler)
                    {
                        double net = reader[ders] != DBNull.Value ? Math.Round(Convert.ToDouble(reader[ders]), 1) : 0;
                        chartPerformanceAdmin.Series[ders].Points.AddXY(examName, net);
                    }
                }

                if (!hasData)
                {
                    MessageBox.Show("This student has no exams to display.");
                }
            }
        }
    }

}

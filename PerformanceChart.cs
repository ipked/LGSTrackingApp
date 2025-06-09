using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LGSTrackingApp
{
    public partial class PerformanceChart : Form
    {
        private int studentUserId;
        private int studentId;
        private string connectionString = @"Server=DEDEOGLU\SQLEXPRESS;Database=LGSTrackerDB;Trusted_Connection=True;";

        public PerformanceChart(int userId)
        {
            InitializeComponent();
            studentUserId = userId;
            studentId = GetStudentIdFromUserId(userId);
        }

        private int GetStudentIdFromUserId(int userId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID FROM Students WHERE UserID = @UserID", con);
                cmd.Parameters.AddWithValue("@UserID", userId);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private void btnSelectedExam_Click(object sender, EventArgs e)
        {
            string examName = txtSelectedExam.Text.Trim();
            if (string.IsNullOrWhiteSpace(examName))
            {
                MessageBox.Show("Please enter an exam name.");
                return;
            }

            chartPerformance.Series.Clear();
            chartPerformance.ChartAreas.Clear();
            chartPerformance.ChartAreas.Add(new ChartArea("SelectedExam"));

            Series series = new Series("Net")
            {
                ChartType = SeriesChartType.Column,
                BorderWidth = 2,
                IsValueShownAsLabel = true,
                LabelFormat = "F1"
            };

            chartPerformance.Series.Add(series);

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

        private void btnAllExams_Click(object sender, EventArgs e)
        {
            chartPerformance.Series.Clear();
            chartPerformance.ChartAreas.Clear();
            chartPerformance.ChartAreas.Add(new ChartArea("AllExams"));

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
                chartPerformance.Series.Add(series);
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT ExamName, MatematikNet, TürkçeNet, FenBilimleriNet, İngilizceNet, İnkılapTarihiNet, DinKültürüNet
                                                 FROM Exams
                                                 WHERE StudentID = @StudentID
                                                 ORDER BY ExamDate", con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string examName = reader["ExamName"].ToString();
                    foreach (string ders in dersler)
                    {
                        double net = reader[ders] != DBNull.Value ? Math.Round(Convert.ToDouble(reader[ders]), 1) : 0;
                        chartPerformance.Series[ders].Points.AddXY(examName, net);
                    }
                }
            }
        }
    }
}

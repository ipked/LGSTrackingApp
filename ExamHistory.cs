using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LGSTrackingApp
{
    public partial class ExamHistory : Form
    {
        private string connectionString = @"Server=DEDEOGLU\SQLEXPRESS;Database=LGSTrackerDB;Trusted_Connection=True;";

        public ExamHistory()
        {
            InitializeComponent();
            LoadStudentsToCombo();
        }

        private void LoadStudentsToCombo()
        {
            cmbStudentList.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID, Name + ' ' + Surname AS FullName FROM Students", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbStudentList.Items.Add(new ComboBoxItem
                    {
                        Text = reader["FullName"].ToString(),
                        Value = (int)reader["StudentID"]
                    });
                }
            }
        }

        private void btnShowSelected_Click(object sender, EventArgs e)
        {
            if (cmbStudentList.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            var selectedStudent = (ComboBoxItem)cmbStudentList.SelectedItem;
            int studentId = selectedStudent.Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
                    s.Name + ' ' + s.Surname AS StudentName,
                    e.ExamName,
                    e.ExamDate,
                    e.Matematik, e.MatematikWrong, e.MatematikNet,
                    e.FenBilimleri, e.FenBilimleriWrong, e.FenBilimleriNet,
                    e.Türkçe, e.TürkçeWrong, e.TürkçeNet,
                    e.İngilizce, e.İngilizceWrong, e.İngilizceNet,
                    e.İnkılapTarihi, e.İnkılapTarihiWrong, e.İnkılapTarihiNet,
                    e.DinKültürü, e.DinKültürüWrong, e.DinKültürüNet
                FROM Exams e
                INNER JOIN Students s ON s.StudentID = e.StudentID
                WHERE e.StudentID = @StudentID
                ORDER BY e.ExamDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@StudentID", studentId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridHistory.DataSource = dt;

                FormatColumns();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
                    s.Name + ' ' + s.Surname AS StudentName,
                    e.ExamName,
                    e.ExamDate,
                    e.Matematik, e.MatematikWrong, e.MatematikNet,
                    e.FenBilimleri, e.FenBilimleriWrong, e.FenBilimleriNet,
                    e.Türkçe, e.TürkçeWrong, e.TürkçeNet,
                    e.İngilizce, e.İngilizceWrong, e.İngilizceNet,
                    e.İnkılapTarihi, e.İnkılapTarihiWrong, e.İnkılapTarihiNet,
                    e.DinKültürü, e.DinKültürüWrong, e.DinKültürüNet
                FROM Exams e
                INNER JOIN Students s ON s.StudentID = e.StudentID
                ORDER BY s.Name, e.ExamDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridHistory.DataSource = dt;

                FormatColumns();
            }
        }

        private void FormatColumns()
        {
            dataGridHistory.Columns["ExamName"].HeaderText = "Deneme Adı";
            dataGridHistory.Columns["MatematikWrong"].HeaderText = "Matematik Yanlış";
            dataGridHistory.Columns["MatematikNet"].HeaderText = "Matematik Net";
            dataGridHistory.Columns["FenBilimleriWrong"].HeaderText = "Fen Yanlış";
            dataGridHistory.Columns["FenBilimleriNet"].HeaderText = "Fen Net";
            dataGridHistory.Columns["TürkçeWrong"].HeaderText = "Türkçe Yanlış";
            dataGridHistory.Columns["TürkçeNet"].HeaderText = "Türkçe Net";
            dataGridHistory.Columns["İngilizceWrong"].HeaderText = "İngilizce Yanlış";
            dataGridHistory.Columns["İngilizceNet"].HeaderText = "İngilizce Net";
            dataGridHistory.Columns["İnkılapTarihiWrong"].HeaderText = "İnkılap Yanlış";
            dataGridHistory.Columns["İnkılapTarihiNet"].HeaderText = "İnkılap Net";
            dataGridHistory.Columns["DinKültürüWrong"].HeaderText = "Din Yanlış";
            dataGridHistory.Columns["DinKültürüNet"].HeaderText = "Din Net";

            string[] netColumns = {
                "MatematikNet", "FenBilimleriNet", "TürkçeNet",
                "İngilizceNet", "İnkılapTarihiNet", "DinKültürüNet"
            };

            foreach (string col in netColumns)
            {
                if (dataGridHistory.Columns.Contains(col))
                {
                    dataGridHistory.Columns[col].DefaultCellStyle.Format = "F1";
                }
            }
        }
    }

}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LGSTrackingApp
{
    public partial class ExamResults : Form
    {
        private int userId;
        private int studentId;
        private string connectionString = @"Server=DEDEOGLU\SQLEXPRESS;Database=LGSTrackerDB;Trusted_Connection=True;";

        public ExamResults(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            studentId = GetStudentIdFromUserId(userId);

            if (studentId <= 0)
            {
                MessageBox.Show($"Student record not found for this user (UserID: {userId}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private int GetStudentIdFromUserId(int userId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT StudentID FROM Students WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving StudentID:\n" + ex.Message);
                    return -1;
                }
            }
        }

        private void btnMyResults_Click(object sender, EventArgs e)
        {
            LoadExamResults();
        }

        private void LoadExamResults()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
                        SELECT 
                            ExamName,
                            ExamDate,
                            Matematik, MatematikWrong, MatematikNet,
                            FenBilimleri, FenBilimleriWrong, FenBilimleriNet,
                            Türkçe, TürkçeWrong, TürkçeNet,
                            İngilizce, İngilizceWrong, İngilizceNet,
                            İnkılapTarihi, İnkılapTarihiWrong, İnkılapTarihiNet,
                            DinKültürü, DinKültürüWrong, DinKültürüNet
                        FROM Exams
                        WHERE StudentID = @StudentID
                        ORDER BY ExamDate DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@StudentID", studentId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridMyResults.DataSource = dt;

                    string[] netColumns = {
                       "MatematikNet", "FenBilimleriNet", "TürkçeNet",
                       "İngilizceNet", "İnkılapTarihiNet", "DinKültürüNet"
                    };

                    foreach (string col in netColumns)
                    {
                        if (dataGridMyResults.Columns.Contains(col))
                        {
                            dataGridMyResults.Columns[col].DefaultCellStyle.Format = "F1";
                        }
                    }

                    dataGridMyResults.Columns["ExamName"].HeaderText = "Deneme Adı";
                    dataGridMyResults.Columns["MatematikWrong"].HeaderText = "Matematik Yanlış";
                    dataGridMyResults.Columns["MatematikNet"].HeaderText = "Matematik Net";
                    dataGridMyResults.Columns["FenBilimleriWrong"].HeaderText = "Fen Yanlış";
                    dataGridMyResults.Columns["FenBilimleriNet"].HeaderText = "Fen Net";
                    dataGridMyResults.Columns["TürkçeWrong"].HeaderText = "Türkçe Yanlış";
                    dataGridMyResults.Columns["TürkçeNet"].HeaderText = "Türkçe Net";
                    dataGridMyResults.Columns["İngilizceWrong"].HeaderText = "İngilizce Yanlış";
                    dataGridMyResults.Columns["İngilizceNet"].HeaderText = "İngilizce Net";
                    dataGridMyResults.Columns["İnkılapTarihiWrong"].HeaderText = "İnkılap Yanlış";
                    dataGridMyResults.Columns["İnkılapTarihiNet"].HeaderText = "İnkılap Net";
                    dataGridMyResults.Columns["DinKültürüWrong"].HeaderText = "Din Yanlış";
                    dataGridMyResults.Columns["DinKültürüNet"].HeaderText = "Din Net";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading exam results:\n" + ex.Message);
                }
            }
        }
    }
}

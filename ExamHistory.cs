using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LGSTrackingApp;

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
                                e.ExamDate,
                                e.Matematik,
                                e.FenBilimleri,
                                e.Türkçe,
                                e.İngilizce,
                                e.İnkılapTarihi,
                                e.DinKültürü
                            FROM Exams e
                            INNER JOIN Students s ON s.StudentID = e.StudentID
                            WHERE e.StudentID = @StudentID
                            ORDER BY e.ExamDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@StudentID", studentId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridHistory.DataSource = dt;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
                                s.Name + ' ' + s.Surname AS StudentName,
                                e.ExamDate,
                                e.Matematik,
                                e.FenBilimleri,
                                e.Türkçe,
                                e.İngilizce,
                                e.İnkılapTarihi,
                                e.DinKültürü
                            FROM Exams e
                            INNER JOIN Students s ON s.StudentID = e.StudentID
                            ORDER BY s.Name, e.ExamDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridHistory.DataSource = dt;
            }
        }

    }

    
}
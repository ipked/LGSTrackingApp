using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LGSTrackingApp
{
    public partial class StudentForm : Form
    {
        private int currentUserId;
        private int studentId;
        private string connectionString = @"Server=DEDEOGLU\SQLEXPRESS;Database=LGSTrackerDB;Trusted_Connection=True;";

        public StudentForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            GetStudentIdFromUserId();
        }

        private void GetStudentIdFromUserId()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT StudentID FROM Students WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserID", currentUserId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        studentId = Convert.ToInt32(result);
                       
                    }
                    else
                    {
                        studentId = -1;
                        MessageBox.Show("Student record not found for this user (UserID: " + currentUserId + ").");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching StudentID:\n" + ex.Message);
                }
            }
        }

        private void btnAddS_Click(object sender, EventArgs e)
        {
            if (studentId <= 0)
            {
                MessageBox.Show("Invalid student. Cannot add exam.");
                return;
            }

            DateTime examDate = dateTimePickerExam.Value;

            int matematik = (int)numericMath.Value;
            int fen = (int)numericFen.Value;
            int ingilizce = (int)numericIng.Value;
            int turkce = (int)numericTurk.Value;
            int inkilap = (int)numericInk.Value;
            int din = (int)numericDin.Value;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Exams 
                        (StudentID, ExamDate, Matematik, FenBilimleri, Türkçe, İngilizce, İnkılapTarihi, DinKültürü)
                        VALUES
                        (@StudentID, @ExamDate, @Matematik, @FenBilimleri, @Turkce, @Ingilizce, @InkilapTarihi, @DinKulturu)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.Parameters.AddWithValue("@ExamDate", examDate);
                    cmd.Parameters.AddWithValue("@Matematik", matematik);
                    cmd.Parameters.AddWithValue("@FenBilimleri", fen);
                    cmd.Parameters.AddWithValue("@Turkce", turkce);
                    cmd.Parameters.AddWithValue("@Ingilizce", ingilizce);
                    cmd.Parameters.AddWithValue("@InkilapTarihi", inkilap);
                    cmd.Parameters.AddWithValue("@DinKulturu", din);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your exam results were successfully recorded!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving exam:\n" + ex.Message);
            }
        }

        private void examResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (studentId <= 0)
            {
                MessageBox.Show("Student ID not found. Cannot open results.");
                return;
            }

            ExamResults resultsForm = new ExamResults(currentUserId); 
            resultsForm.ShowDialog();
        }
    }
}

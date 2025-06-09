using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LGSTrackingApp
{
    public partial class AddExam : Form
    {
        private string connectionString = @"Server=DEDEOGLU\SQLEXPRESS;Database=LGSTrackerDB;Trusted_Connection=True;";

        public AddExam()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            cmbStudents.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID, Name + ' ' + Surname AS FullName FROM Students", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbStudents.Items.Add(new ComboBoxItem
                    {
                        Text = reader["FullName"].ToString(),
                        Value = (int)reader["StudentID"]
                    });
                }
            }
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            string examName = txtExamName.Text.Trim();
            if (string.IsNullOrWhiteSpace(examName))
            {
                MessageBox.Show("Please enter an exam name.");
                return;
            }

            var selectedStudent = (ComboBoxItem)cmbStudents.SelectedItem;
            int studentId = selectedStudent.Value;
            DateTime examDate = dateTimePicker.Value;

            int mathCorrect = (int)numMath.Value;
            int turkceCorrect = (int)numTurk.Value;
            int fenCorrect = (int)numFen.Value;
            int ingCorrect = (int)numIng.Value;
            int inkCorrect = (int)numInk.Value;
            int dinCorrect = (int)numDin.Value;

            int mathWrong = (int)numMathF.Value;
            int turkceWrong = (int)numTurkF.Value;
            int fenWrong = (int)numFenF.Value;
            int ingWrong = (int)numIngF.Value;
            int inkWrong = (int)numInkF.Value;
            int dinWrong = (int)numDinF.Value;

            double mathNet = mathCorrect - mathWrong / 3.0;
            double turkceNet = turkceCorrect - turkceWrong / 3.0;
            double fenNet = fenCorrect - fenWrong / 3.0;
            double ingNet = ingCorrect - ingWrong / 3.0;
            double inkNet = inkCorrect - inkWrong / 3.0;
            double dinNet = dinCorrect - dinWrong / 3.0;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Exams 
                        (StudentID, ExamDate, ExamName,
                         Matematik, MatematikWrong, MatematikNet,
                         Türkçe, TürkçeWrong, TürkçeNet,
                         FenBilimleri, FenBilimleriWrong, FenBilimleriNet,
                         İngilizce, İngilizceWrong, İngilizceNet,
                         İnkılapTarihi, İnkılapTarihiWrong, İnkılapTarihiNet,
                         DinKültürü, DinKültürüWrong, DinKültürüNet)
                        VALUES
                        (@StudentID, @ExamDate, @ExamName,
                         @MathC, @MathW, @MathN,
                         @TurkC, @TurkW, @TurkN,
                         @FenC, @FenW, @FenN,
                         @IngC, @IngW, @IngN,
                         @InkC, @InkW, @InkN,
                         @DinC, @DinW, @DinN)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.Parameters.AddWithValue("@ExamDate", examDate);
                    cmd.Parameters.AddWithValue("@ExamName", examName);

                    cmd.Parameters.AddWithValue("@MathC", mathCorrect);
                    cmd.Parameters.AddWithValue("@MathW", mathWrong);
                    cmd.Parameters.AddWithValue("@MathN", mathNet);

                    cmd.Parameters.AddWithValue("@TurkC", turkceCorrect);
                    cmd.Parameters.AddWithValue("@TurkW", turkceWrong);
                    cmd.Parameters.AddWithValue("@TurkN", turkceNet);

                    cmd.Parameters.AddWithValue("@FenC", fenCorrect);
                    cmd.Parameters.AddWithValue("@FenW", fenWrong);
                    cmd.Parameters.AddWithValue("@FenN", fenNet);

                    cmd.Parameters.AddWithValue("@IngC", ingCorrect);
                    cmd.Parameters.AddWithValue("@IngW", ingWrong);
                    cmd.Parameters.AddWithValue("@IngN", ingNet);

                    cmd.Parameters.AddWithValue("@InkC", inkCorrect);
                    cmd.Parameters.AddWithValue("@InkW", inkWrong);
                    cmd.Parameters.AddWithValue("@InkN", inkNet);

                    cmd.Parameters.AddWithValue("@DinC", dinCorrect);
                    cmd.Parameters.AddWithValue("@DinW", dinWrong);
                    cmd.Parameters.AddWithValue("@DinN", dinNet);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Exam result added successfully to Exams table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding exam:\n" + ex.Message);
            }
        }
    }

   
}

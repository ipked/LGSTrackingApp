﻿using System;
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
                    studentId = result != null ? Convert.ToInt32(result) : -1;
                    if (studentId == -1)
                        MessageBox.Show("Student record not found for this user (UserID: " + currentUserId + ").");
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

            string examName = txtExamNameS.Text.Trim();
            if (string.IsNullOrWhiteSpace(examName))
            {
                MessageBox.Show("Please enter an exam name.");
                return;
            }

            DateTime examDate = dateTimePickerExam.Value;

            int mathCorrect = (int)numericMath.Value;
            int mathWrong = (int)numericMathF.Value;
            double mathNet = mathCorrect - mathWrong / 3.0;

            int turkceCorrect = (int)numericTurk.Value;
            int turkceWrong = (int)numericTurkF.Value;
            double turkceNet = turkceCorrect - turkceWrong / 3.0;

            int fenCorrect = (int)numericFen.Value;
            int fenWrong = (int)numericFenF.Value;
            double fenNet = fenCorrect - fenWrong / 3.0;

            int ingCorrect = (int)numericIng.Value;
            int ingWrong = (int)numericIngF.Value;
            double ingNet = ingCorrect - ingWrong / 3.0;

            int inkCorrect = (int)numericInk.Value;
            int inkWrong = (int)numericInkF.Value;
            double inkNet = inkCorrect - inkWrong / 3.0;

            int dinCorrect = (int)numericDin.Value;
            int dinWrong = (int)numericDinF.Value;
            double dinNet = dinCorrect - dinWrong / 3.0;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Exams 
                        (StudentID, ExamDate, ExamName,
                         Matematik, MatematikWrong, MatematikNet,
                         FenBilimleri, FenBilimleriWrong, FenBilimleriNet,
                         Türkçe, TürkçeWrong, TürkçeNet,
                         İngilizce, İngilizceWrong, İngilizceNet,
                         İnkılapTarihi, İnkılapTarihiWrong, İnkılapTarihiNet,
                         DinKültürü, DinKültürüWrong, DinKültürüNet)
                        VALUES
                        (@StudentID, @ExamDate, @ExamName,
                         @MathC, @MathW, @MathN,
                         @FenC, @FenW, @FenN,
                         @TurkC, @TurkW, @TurkN,
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

                    cmd.Parameters.AddWithValue("@FenC", fenCorrect);
                    cmd.Parameters.AddWithValue("@FenW", fenWrong);
                    cmd.Parameters.AddWithValue("@FenN", fenNet);

                    cmd.Parameters.AddWithValue("@TurkC", turkceCorrect);
                    cmd.Parameters.AddWithValue("@TurkW", turkceWrong);
                    cmd.Parameters.AddWithValue("@TurkN", turkceNet);

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

        private void myPerformanceChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformanceChart chartForm = new PerformanceChart(currentUserId);
            chartForm.ShowDialog();
        }

        private void pDFExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPDFExport myPDFExport = new MyPDFExport(currentUserId);
            myPDFExport.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}

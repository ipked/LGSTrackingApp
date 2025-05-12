using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LGSTrackingApp;

namespace LGSTrackingApp
{
    public partial class AdminForm : Form
    {
        private string connectionString;

        public AdminForm(string connStr)
        {
            InitializeComponent();
            connectionString = connStr;
            LoadStudentsToComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string username = txtUsernameA.Text.Trim();
            string school = txtSchool.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(school) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", con);
                    checkUser.Parameters.AddWithValue("@Username", username);
                    int userExists = (int)checkUser.ExecuteScalar();
                    if (userExists > 0)
                    {
                        MessageBox.Show("This username already exists.");
                        return;
                    }

                    SqlCommand insertUser = new SqlCommand(
                        "INSERT INTO Users (Username, Password, Role) OUTPUT INSERTED.UserID VALUES (@Username, @Password, @Role)", con);
                    insertUser.Parameters.AddWithValue("@Username", username);
                    insertUser.Parameters.AddWithValue("@Password", password);
                    insertUser.Parameters.AddWithValue("@Role", "Student");

                    int newUserId = (int)insertUser.ExecuteScalar();

                    SqlCommand insertStudent = new SqlCommand(
                        "INSERT INTO Students (UserID, Name, Surname, School, Username, Password) VALUES (@UserID, @Name, @Surname, @School, @Username, @Password)", con);
                    insertStudent.Parameters.AddWithValue("@UserID", newUserId);
                    insertStudent.Parameters.AddWithValue("@Name", name);
                    insertStudent.Parameters.AddWithValue("@Surname", surname);
                    insertStudent.Parameters.AddWithValue("@School", school);
                    insertStudent.Parameters.AddWithValue("@Username", username);
                    insertStudent.Parameters.AddWithValue("@Password", password); 


                    int result = insertStudent.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Student successfully added.");
                        ClearInputs();
                        LoadStudentsToComboBox();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add student.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message);
            }
        }

        private void btnListAllS_Click(object sender, EventArgs e)
        {
            dataGridStudent.AutoGenerateColumns = true; 
            dataGridStudent.Columns.Clear();            

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Name, Surname, Username, School, Password FROM Students", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridStudent.DataSource = dt;
                

                
                if (dataGridStudent.Columns.Contains("Password"))
                {
                    dataGridStudent.Columns["Password"].Visible = true;
                }

            }
        }


        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridStudent.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtSurname.Text = row.Cells["Surname"].Value.ToString();
                txtUsernameA.Text = row.Cells["Username"].Value.ToString();
                txtSchool.Text = row.Cells["School"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value?.ToString();


            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string username = txtUsernameA.Text.Trim();
            string school = txtSchool.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(school) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all fields to update.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                     @"UPDATE Students 
                     SET Name = @Name, Surname = @Surname, School = @School, Password = @Password
                     WHERE Username = @Username", con);


                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@School", school);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Student updated successfully.");
                        btnListAllS_Click(null, null); 
                    }
                    else
                    {
                        MessageBox.Show("No student found with that username.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student:\n" + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsernameA.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student and all related data?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                    SqlCommand getStudentId = new SqlCommand(
                        "SELECT StudentID FROM Students WHERE Username = @Username", con);
                    getStudentId.Parameters.AddWithValue("@Username", username);

                    object studentIdObj = getStudentId.ExecuteScalar();
                    if (studentIdObj == null)
                    {
                        MessageBox.Show("Student not found.");
                        return;
                    }

                    int studentId = Convert.ToInt32(studentIdObj);

                    
                    SqlCommand deleteExams = new SqlCommand("DELETE FROM Exams WHERE StudentID = @StudentID", con);
                    deleteExams.Parameters.AddWithValue("@StudentID", studentId);
                    deleteExams.ExecuteNonQuery();

                   
                    SqlCommand deleteStudent = new SqlCommand("DELETE FROM Students WHERE StudentID = @StudentID", con);
                    deleteStudent.Parameters.AddWithValue("@StudentID", studentId);
                    deleteStudent.ExecuteNonQuery();

                   
                    SqlCommand deleteUser = new SqlCommand("DELETE FROM Users WHERE Username = @Username", con);
                    deleteUser.Parameters.AddWithValue("@Username", username);
                    deleteUser.ExecuteNonQuery();

                    MessageBox.Show("Student and related records deleted.");
                    ClearInputs();
                    LoadStudentsToComboBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting:\n" + ex.Message);
            }
        }
        private void btnExam_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            var selectedStudent = (ComboBoxItem)cmbStudents.SelectedItem;
            int studentId = selectedStudent.Value;
            DateTime examDate = dateTimePicker.Value;

            int matematik = (int)numMath.Value;
            int turkce = (int)numTurk.Value;
            int fen = (int)numFen.Value;
            int ingilizce = (int)numIng.Value;
            int inkilap = (int)numInk.Value;
            int din = (int)numDin.Value;

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
                    MessageBox.Show("Exam result added successfully to Exams table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding exam:\n" + ex.Message);
            }
        }

        
        private void ClearInputs()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtUsernameA.Clear();
            txtSchool.Clear();
            txtPassword.Clear();

        }


        private void LoadStudentsToComboBox()
        {
            cmbStudents.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID, Name, Surname FROM Students", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["StudentID"];
                    string fullName = reader["Name"] + " " + reader["Surname"];
                    cmbStudents.Items.Add(new ComboBoxItem { Text = fullName, Value = id });
                }
            }
        }
        private void examHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ExamHistory examForm = new ExamHistory();
            examForm.Show();
        }


    }
}
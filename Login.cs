using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LGSTrackingApp
{
    public partial class Login : Form
    {
        private string connectionString = @"Server=DEDEOGLU\SQLEXPRESS;Database=LGSTrackerDB;Trusted_Connection=True;";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Role FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["UserID"]);
                    string role = reader["Role"].ToString();

                    if (role == "Student")
                    {
                        StudentForm studentForm = new StudentForm(userId);
                        studentForm.Show();
                    }
                    else if (role == "Admin")
                    {
                        AdminForm adminForm = new AdminForm(connectionString);
                        adminForm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }
    }
}

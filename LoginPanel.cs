using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace FitX
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
            passwordField.PasswordChar = '•';
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordField.PasswordChar = '\0';
            }
            else
            {
                passwordField.PasswordChar = '•';
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupPanel signupPanel = new SignupPanel();
            signupPanel.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailField.Text;
            string password = passwordField.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = @"Data Source=C:\Users\royce\Desktop\Visual Studio\FitX\CoreDB.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Password FROM Users WHERE Email = @Email";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        SQLiteDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string storedHashedPassword = reader["Password"].ToString();

                            string enteredHashedPassword = HashPassword(password);

                            if (storedHashedPassword == enteredHashedPassword)
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Dashboard dashboard = new Dashboard();
                                dashboard.Show();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No account found with that email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private void forgotPasswordBtn_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
    }
}
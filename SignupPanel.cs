using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace FitX
{
    public partial class SignupPanel : Form
    {
        public SignupPanel()
        {
            InitializeComponent();
            passwordField.PasswordChar = '•';
            confirmPasswordField.PasswordChar = '•';
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameField.Text.Trim();
            string lastName = lastNameField.Text.Trim();
            string email = emailField.Text.Trim();
            string password = passwordField.Text;
            string confirmPassword = confirmPasswordField.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                ShowError("All fields are required. Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                ShowError("Passwords do not match. Please try again.");
                return;
            }

            using (var termsConditions = new TermsConditions())
            {
                termsConditions.ShowDialog();

                if (!termsConditions.IsConfirmed)
                {
                    ShowError("You must agree to the Terms and Conditions to register.");
                    return;
                }
            }

            string hashedPassword = HashPassword(password);

            try
            {
                string connectionString = @"Data Source=C:\Users\royce\Desktop\Visual Studio\FitX\CoreDB.db;Version=3;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Users (FirstName, LastName, Email, Password) VALUES (@FirstName, @LastName, @Email, @Password)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", hashedPassword);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();

                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while creating your account: " + ex.Message);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Show();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            char passwordChar = showPassword.Checked ? '\0' : '•';
            passwordField.PasswordChar = passwordChar;
            confirmPasswordField.PasswordChar = passwordChar;
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

        private void ClearFields()
        {
            firstNameField.Clear();
            lastNameField.Clear();
            emailField.Clear();
            passwordField.Clear();
            confirmPasswordField.Clear();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

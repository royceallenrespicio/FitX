using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitX
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void newPasswordBtn_Click(object sender, EventArgs e)
        {
            string email = email_Field.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SendNewPasswordEmail(email))
            {
                MessageBox.Show("A new password has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool SendNewPasswordEmail(string email)
        {
            if (!CheckEmailInDatabase(email))
            {
                MessageBox.Show("No account found with this email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string newPassword = GenerateRandomPassword();

            if (UpdatePasswordInDatabase(email, newPassword))
            {
                return SendEmail(email, newPassword);
            }

            return false;
        }

        private bool CheckEmailInDatabase(string email)
        {
            try
            {
                string connectionString = @"Data Source=C:\Users\royce\Desktop\Visual Studio\FitX\CoreDB.db;Version=3;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        long count = (long)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string GenerateRandomPassword()
        {
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            Random random = new Random();
            char[] password = new char[12];
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = validChars[random.Next(validChars.Length)];
            }
            return new string(password);
        }

        private bool UpdatePasswordInDatabase(string email, string newPassword)
        {
            try
            {
                string hashedPassword = HashPassword(newPassword);
                string connectionString = @"Data Source=C:\Users\royce\Desktop\Visual Studio\FitX\CoreDB.db;Version=3;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Users SET Password = @Password WHERE Email = @Email";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool SendEmail(string email, string newPassword)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("fitx.handler@gmail.com", "blbghrqkzwbvaosa"),
                    EnableSsl = true,
                };

                var message = new MailMessage
                {
                    From = new MailAddress("fitx.handler@gmail.com"),
                    Subject = "Your New Password",
                    Body = $"Your new password is: {newPassword}\n\nPlease log in and change your password as soon as possible.",
                    IsBodyHtml = false,
                };

                message.To.Add(email);
                smtpClient.Send(message);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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

        private void email_Field_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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

            if (!CheckEmailInDatabase(email))
            {
                MessageBox.Show("No account found with this email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resetCode = GenerateResetCode();
            if (UpdateResetCodeInDatabase(email, resetCode))
            {
                if (SendEmail(email, resetCode))
                {
                    MessageBox.Show("A reset code has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    NewPassword newPasswordForm = new NewPassword(email);
                    newPasswordForm.Show();
                }
            }
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
                        return count > 0; // Email exists if count > 0
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private string GenerateResetCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); // Generates a 6-digit code
        }

        private bool UpdateResetCodeInDatabase(string email, string resetCode)
        {
            try
            {
                DateTime expiryTime = DateTime.Now.AddMinutes(15);
                string connectionString = @"Data Source=C:\Users\royce\Desktop\Visual Studio\FitX\CoreDB.db;Version=3;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Users SET ResetCode = @ResetCode, CodeExpiry = @CodeExpiry WHERE Email = @Email";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResetCode", resetCode);
                        command.Parameters.AddWithValue("@CodeExpiry", expiryTime);
                        command.Parameters.AddWithValue("@Email", email);
                        command.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating reset code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool SendEmail(string email, string resetCode)
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
                    Subject = "Password Reset Code",
                    Body = $"Your password reset code is: {resetCode}\n\nThis code is valid for 15 minutes.",
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
    }
}

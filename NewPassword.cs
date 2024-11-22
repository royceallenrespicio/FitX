using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FitX
{
    public partial class NewPassword : Form
    {
        private string userEmail;

        public NewPassword(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void newPasswordBtn_Click(object sender, EventArgs e)
        {
            string resetCode = code_Field.Text;
            string newPassword = newPassword_Field.Text;

            if (string.IsNullOrEmpty(resetCode) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!VerifyResetCode(userEmail, resetCode))
            {
                MessageBox.Show("Invalid or expired reset code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UpdatePasswordInDatabase(userEmail, newPassword))
            {
                MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool VerifyResetCode(string email, string resetCode)
        {
            try
            {
                string connectionString = @"Data Source=C:\Users\royce\Desktop\Visual Studio\FitX\CoreDB.db;Version=3;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT CodeExpiry FROM Users WHERE Email = @Email AND ResetCode = @ResetCode";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@ResetCode", resetCode);

                        SQLiteDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            DateTime expiryTime = Convert.ToDateTime(reader["CodeExpiry"]);
                            if (DateTime.Now > expiryTime)
                            {
                                return false; // Code expired
                            }
                            return true; // Code is valid
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verifying reset code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
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

                    string query = "UPDATE Users SET Password = @Password, ResetCode = NULL, CodeExpiry = NULL WHERE Email = @Email";
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

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}

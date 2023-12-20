using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaOrderSystem;
using System.Security.Cryptography;

namespace PizzaOrderSystem
{
    public partial class RegistrationForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-HRFVO2E\\SQLEXPRESS02;Initial Catalog=pizzadbase;Integrated Security=True;";
        private string jobPosition;
        public RegistrationForm()
        {
            InitializeComponent();
            RegisterPasswordTextBox.PasswordChar = '*' ; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterUserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        //--------------------Register Button-----------------------
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = RegisterUserNameTextBox.Text.Trim();
            string password = RegisterPasswordTextBox.Text;
            string phoneNumber = RegisterPhoneNumberTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please fill in all fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (RegisterUser(username, password, phoneNumber))
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool RegisterUser(string username, string password, string phoneNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string salt;
                    string hashedPassword = PasswordHasher.HashPassword(password, out salt);

                    string insertQuery = "INSERT INTO Users (Username, PasswordHash, Salt, PhoneNumber, JobPosition) " +
                                         "VALUES (@Username, @PasswordHash, @Salt, @PhoneNumber, @JobPosition)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        command.Parameters.AddWithValue("@Salt", salt);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@JobPosition", jobPosition);

                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterDriverButton_Click(object sender, EventArgs e)
        {
            string driverUsername = DriverUserNameTextBox.Text.Trim();
            string driverPassword = DriverPasswordTextBox.Text; 
            string driverPhoneNumber = DriverPhoneNumberTextBox.Text.Trim();

            if (string.IsNullOrEmpty(driverUsername) || string.IsNullOrEmpty(driverPassword) || string.IsNullOrEmpty(driverPhoneNumber))
            {
                MessageBox.Show("Please fill in all fields for the driver.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RegisterDriver(driverUsername, driverPassword, driverPhoneNumber))
            {
                MessageBox.Show("Driver registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Driver registration failed. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool RegisterDriver(string driverUsername, string driverPassword, string driverPhoneNumber)
        {
            const string jobPosition = "Driver";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string salt;
                    string hashedPassword = PasswordHasher.HashPassword(driverPassword, out salt);

                    string insertQuery = "INSERT INTO Drivers (DriverUsername, PasswordHash, Salt, PhoneNumber, JobPosition) " +
                                         "VALUES (@DriverUsername, @PasswordHash, @Salt, @PhoneNumber, @JobPosition)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DriverUsername", driverUsername);
                        command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        command.Parameters.AddWithValue("@Salt", salt);
                        command.Parameters.AddWithValue("@PhoneNumber", driverPhoneNumber);
                        command.Parameters.AddWithValue("@JobPosition", jobPosition);

                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void DriverUserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        //--------------------------Register Staff---------------------------
    }

    public static class PasswordHasher
    {
        public static string HashPassword(string password, out string salt)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] saltBytes = new byte[16];
                rng.GetBytes(saltBytes);
                salt = Convert.ToBase64String(saltBytes);

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000, HashAlgorithmName.SHA256))
                {
                    byte[] hash = pbkdf2.GetBytes(32); 
                    return Convert.ToBase64String(hash);
                }
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000, HashAlgorithmName.SHA256))
            {
                byte[] hashToCheck = pbkdf2.GetBytes(32); 
                return Convert.ToBase64String(hashToCheck) == hashedPassword;
            }
        }
    }
}

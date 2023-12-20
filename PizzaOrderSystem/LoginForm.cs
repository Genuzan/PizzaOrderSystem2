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


namespace PizzaOrderSystem
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-HRFVO2E\\SQLEXPRESS02;Initial Catalog=pizzadbase;Integrated Security=True;";
        SqlConnection connection;
         
        public LoginForm()
        {
             
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            PasswordTextBox.PasswordChar = '*';

        }
        //-------------------TextBoxes-------------------------
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //---------------Lgin Button---------------------
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string phoneNumber = PhoneNumberTextBox.Text.Trim();
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both phone number and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AuthenticateUser(phoneNumber, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bool isDriver = IsDriver(phoneNumber);

                if (isDriver) 
                {
                    DriverForm driverForm = new DriverForm();
                    driverForm.ShowDialog();
                } 
                else
                {
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }

                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid phone number or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string phoneNumber, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (CheckUserTable(connection, phoneNumber, password))
                        return true;
                    if (CheckDriverTable(connection, phoneNumber, password))
                        return true;   
                    if (CheckAdminTable(connection, phoneNumber, password))
                        return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool CheckAdminTable(SqlConnection connection, string phoneNumber, string password)
        {
            string selectQuery = "SELECT * FROM Admins WHERE AdminUsername = @AdminUsername";
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@AdminUsername", phoneNumber); 

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPasswordHash = reader["PasswordHash"].ToString();
                        string storedSalt = reader["Salt"].ToString();

                        if (PasswordHasher.VerifyPassword(password, storedPasswordHash, storedSalt))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }


        private bool CheckDriverTable(SqlConnection connection, string phoneNumber, string password)
        {
            string selectQuery = "SELECT * FROM Drivers WHERE PhoneNumber = @PhoneNumber";
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPasswordHash = reader["PasswordHash"].ToString();
                        string storedSalt = reader["Salt"].ToString();

                        if (PasswordHasher.VerifyPassword(password, storedPasswordHash, storedSalt))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private bool CheckUserTable(SqlConnection connection, string phoneNumber, string password)
        {
            string selectQuery = "SELECT * FROM Users WHERE PhoneNumber = @PhoneNumber";
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPasswordHash = reader["PasswordHash"].ToString();
                        string storedSalt = reader["Salt"].ToString();

                        if (PasswordHasher.VerifyPassword(password, storedPasswordHash, storedSalt))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

         
        private bool IsDriver(string phoneNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT COUNT(*) FROM Drivers WHERE PhoneNumber = @PhoneNumber";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        int driverCount = (int)command.ExecuteScalar();

                        return driverCount > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //-----------------------Register Button--------------------------
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();

            this.Close(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

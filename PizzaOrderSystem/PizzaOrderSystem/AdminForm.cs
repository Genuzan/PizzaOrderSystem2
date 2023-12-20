using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using PizzaOrderSystem;

namespace PizzaOrderSystem
{
    public partial class AdminForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-HRFVO2E\\SQLEXPRESS02;Initial Catalog=pizzadbase;Integrated Security=True;";
        public AdminForm()
        {
            InitializeComponent();

           
            dataGridView1.Columns.Add("UserID", "User ID");
            dataGridView1.Columns.Add("Username", "Username");
            dataGridView1.Columns.Add("PhoneNumber", "Phone Number");
            dataGridView1.Columns.Add("JobPosition", "Job Position");            
            LoadUserData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadUserData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string userQuery = "SELECT UserID, Username, PhoneNumber, JobPosition FROM Users";
                    SqlCommand userCommand = new SqlCommand(userQuery, connection);
                    SqlDataReader userReader = userCommand.ExecuteReader();

                    while (userReader.Read())
                    {
                        int userId = (int)userReader["UserID"];
                        string username = userReader["Username"].ToString();
                        string phoneNumber = userReader["PhoneNumber"].ToString();
                        string jobPosition = userReader["JobPosition"].ToString();

                        dataGridView1.Rows.Add(userId, username, phoneNumber, jobPosition);
                    }

                    userReader.Close(); 

                   
                    string driverQuery = "SELECT DriverID, DriverUsername, PhoneNumber, JobPosition FROM Drivers";
                    SqlCommand driverCommand = new SqlCommand(driverQuery, connection);
                    SqlDataReader driverReader = driverCommand.ExecuteReader();

                    while (driverReader.Read())
                    {
                        int driverId = (int)driverReader["DriverID"];
                        string driverUsername = driverReader["DriverUsername"].ToString();
                        string phoneNumber = driverReader["PhoneNumber"].ToString();
                        string jobPosition = driverReader["JobPosition"].ToString();

                        dataGridView1.Rows.Add(driverId, driverUsername, phoneNumber, jobPosition);
                    }

                    driverReader.Close(); 
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void SearcBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearcBox.Text.Trim().ToLower();
            dataGridView1.Rows.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string userQuery = $"SELECT UserID, Username, PhoneNumber, JobPosition FROM Users WHERE LOWER(Username) LIKE '%{searchTerm}%'";
                    SqlCommand userCommand = new SqlCommand(userQuery, connection);
                    SqlDataReader userReader = userCommand.ExecuteReader();

                    while (userReader.Read())
                    {
                        int userId = (int)userReader["UserID"];
                        string username = userReader["Username"].ToString();
                        string phoneNumber = userReader["PhoneNumber"].ToString();
                        string jobPosition = userReader["JobPosition"].ToString();
                        dataGridView1.Rows.Add(userId, username, phoneNumber, jobPosition);
                    }

                    userReader.Close();
                    string driverQuery = $"SELECT DriverID, DriverUsername, PhoneNumber, JobPosition FROM Drivers WHERE LOWER(DriverUsername) LIKE '%{searchTerm}%'";
                    SqlCommand driverCommand = new SqlCommand(driverQuery, connection);
                    SqlDataReader driverReader = driverCommand.ExecuteReader();

                    while (driverReader.Read())
                    {
                        int driverId = (int)driverReader["DriverID"];
                        string driverUsername = driverReader["DriverUsername"].ToString();
                        string phoneNumber = driverReader["PhoneNumber"].ToString();
                        string jobPosition = driverReader["JobPosition"].ToString();
                        dataGridView1.Rows.Add(driverId, driverUsername, phoneNumber, jobPosition);
                    }

                    driverReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowUsersButton_Click(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void ShowDriversButton_Click(object sender, EventArgs e)
        {
            ShowDrivers();
        }

        private void ShowUsers()
        {
            
            dataGridView1.Rows.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string userQuery = "SELECT UserID, Username, PhoneNumber, JobPosition FROM Users";
                    SqlCommand userCommand = new SqlCommand(userQuery, connection);
                    SqlDataReader userReader = userCommand.ExecuteReader();

                    while (userReader.Read())
                    {
                        int userId = (int)userReader["UserID"];
                        string username = userReader["Username"].ToString();
                        string phoneNumber = userReader["PhoneNumber"].ToString();
                        string jobPosition = userReader["JobPosition"].ToString();

                        dataGridView1.Rows.Add(userId, username, phoneNumber, jobPosition);
                    }

                    userReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowDrivers()
        {
            
            dataGridView1.Rows.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string driverQuery = "SELECT DriverID, DriverUsername, PhoneNumber, JobPosition FROM Drivers";
                    SqlCommand driverCommand = new SqlCommand(driverQuery, connection);
                    SqlDataReader driverReader = driverCommand.ExecuteReader();

                    while (driverReader.Read())
                    {
                        int driverId = (int)driverReader["DriverID"];
                        string driverUsername = driverReader["DriverUsername"].ToString();
                        string phoneNumber = driverReader["PhoneNumber"].ToString();
                        string jobPosition = driverReader["JobPosition"].ToString();

                        dataGridView1.Rows.Add(driverId, driverUsername, phoneNumber, jobPosition);
                    }

                    driverReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading driver data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide(); 
            loginForm.Show();
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedRows();
        }

        private void RemoveSelectedRows()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string tableName = (row.Cells["JobPosition"].Value.ToString() == "Driver") ? "Drivers" : "Users";
                            string idColumnName = (tableName == "Drivers") ? "DriverID" : "UserID";                           
                            string deleteQuery = $"DELETE FROM [{tableName}] WHERE {idColumnName} = @ID";

                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                            deleteCommand.Parameters.AddWithValue("@ID", id);
                            deleteCommand.ExecuteNonQuery();
                        }

                        dataGridView1.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("No rows selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 staffform = new Form1();
            staffform.Show();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverForm driverform = new DriverForm();
            driverform.Show();
        }

        private void pizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

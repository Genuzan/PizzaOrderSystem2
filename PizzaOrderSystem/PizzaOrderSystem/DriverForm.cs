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

namespace PizzaOrderSystem
{
    public partial class DriverForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-HRFVO2E\\SQLEXPRESS02;Initial Catalog=pizzadbase;Integrated Security=True;";

        public DriverForm()
        {
            InitializeComponent();
            LoadAvailableOrders();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            SearcBox.TextChanged += SearcBox_TextChanged;
        }

        private int GetLoggedInDriverID()
        {
            int driverID = 123; 
            return driverID;
        }
         
        private void LoadAvailableOrders()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    int driverID = GetLoggedInDriverID();
                    string selectQuery = "SELECT o.OrderID, o.CustomerID, c.CustomerName, c.PhoneNumber, c.CustomerAddress, o.OrderDate FROM [Order] o " +
                                         "INNER JOIN Customers c ON o.CustomerID = c.CustomerID " +
                                         "WHERE o.Status = 'Pending' OR o.DriverID = @DriverID";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", driverID);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridView2.Rows.Clear();
                        dataGridView2.Columns.Clear();

                       
                        dataGridView2.Columns.Add("OrderID", "Order ID");
                        dataGridView2.Columns.Add("CustomerID", "Customer ID");
                        dataGridView2.Columns.Add("CustomerName", "Customer Name");
                        dataGridView2.Columns.Add("PhoneNumber", "Phone Number");
                        dataGridView2.Columns.Add("CustomerAddress", "Address");
                        dataGridView2.Columns.Add("OrderDate", "Order Date");

                     
                        foreach (DataRow row in dataTable.Rows)
                        {
                            int orderID = Convert.ToInt32(row["OrderID"]);
                            int customerID = Convert.ToInt32(row["CustomerID"]);
                            string customerName = row["CustomerName"].ToString();
                            string phoneNumber = row["PhoneNumber"].ToString();
                            string customerAddress = row["CustomerAddress"].ToString();
                            DateTime orderDate = Convert.ToDateTime(row["OrderDate"]);

                            dataGridView2.Rows.Add(orderID, customerID, customerName, phoneNumber, customerAddress, orderDate);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["DeliveredButton"].Index && e.RowIndex >= 0)
            {
               
                int orderID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["OrderID"].Value);
                UpdateOrderStatus(orderID, "Delivered");
                LoadAvailableOrders();
            }
            else if (e.ColumnIndex == dataGridView2.Columns["CancelledButton"].Index && e.RowIndex >= 0)
            {
                int orderID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["OrderID"].Value);
                UpdateOrderStatus(orderID, "Cancelled");
                LoadAvailableOrders();
            }
        }

        private void DeliveredButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

            if (selectedRowIndex >= 0)
            {

                int orderID = Convert.ToInt32(dataGridView2.Rows[selectedRowIndex].Cells["OrderID"].Value);

                UpdateOrderStatus(orderID, "Delivered");

                LoadAvailableOrders();
            }
        }

        private void UpdateOrderStatus(int orderID, string newStatus)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE [Order] SET Status = @Status WHERE OrderID = @OrderID";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Status", newStatus);
                        command.Parameters.AddWithValue("@OrderID", orderID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the order status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show(); 
        }

        private void CancelledButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

            
            if (selectedRowIndex >= 0)
            {
              
                int orderID = Convert.ToInt32(dataGridView2.Rows[selectedRowIndex].Cells["OrderID"].Value);
                UpdateOrderStatus(orderID, "Cancelled"); 
                LoadAvailableOrders();
            }
        }

        private void SearcBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearcBox.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        int driverID = GetLoggedInDriverID();
                        string selectQuery = "SELECT o.OrderID, o.CustomerID, c.CustomerName, c.PhoneNumber, c.CustomerAddress, o.OrderDate FROM [Order] o " +
                                             "INNER JOIN Customers c ON o.CustomerID = c.CustomerID " +
                                             "WHERE (o.Status = 'Pending' OR o.DriverID = @DriverID) " +
                                             $"AND (LOWER(c.CustomerName) LIKE '%{searchTerm}%' OR " +
                                             $"LOWER(c.PhoneNumber) LIKE '%{searchTerm}%' OR " +
                                             $"LOWER(c.CustomerAddress) LIKE '%{searchTerm}%')";
                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@DriverID", driverID);

                            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            dataGridView2.Rows.Clear();
                            dataGridView2.Columns.Clear();

                            dataGridView2.Columns.Add("OrderID", "Order ID");
                            dataGridView2.Columns.Add("CustomerID", "Customer ID");
                            dataGridView2.Columns.Add("CustomerName", "Customer Name");
                            dataGridView2.Columns.Add("PhoneNumber", "Phone Number");
                            dataGridView2.Columns.Add("CustomerAddress", "Address");
                            dataGridView2.Columns.Add("OrderDate", "Order Date");

                            foreach (DataRow row in dataTable.Rows)
                            {
                                int orderID = Convert.ToInt32(row["OrderID"]);
                                int customerID = Convert.ToInt32(row["CustomerID"]);
                                string customerName = row["CustomerName"].ToString();
                                string phoneNumber = row["PhoneNumber"].ToString();
                                string customerAddress = row["CustomerAddress"].ToString();
                                DateTime orderDate = Convert.ToDateTime(row["OrderDate"]);

                                dataGridView2.Rows.Add(orderID, customerID, customerName, phoneNumber, customerAddress, orderDate);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                LoadAvailableOrders();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        } 
    }
    
}

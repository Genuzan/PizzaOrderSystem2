using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PizzaOrderSystem
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-HRFVO2E\\SQLEXPRESS02;Initial Catalog=pizzadbase;Integrated Security=True;";
        SqlConnection connection;

        private Dictionary<string, int> selectedPizzas = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);

            
            dataGridView1.Columns.Add("CustomerName", "Customer Name");
            dataGridView1.Columns.Add("PizzaName", "Pizza Name");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Status", "Status");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                LoadDataIntoDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            SearcBox.TextChanged += SearcBox_TextChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //------------------Pizza Check Boxes----------------------------
        private void ClassicBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ClassicBox.Checked)
            {
                ClassicAmount.Enabled = true;
                selectedPizzas["Classic"] = 0; 
            }
            else
            {
                ClassicAmount.Enabled = false;
                ClassicAmount.Clear();
                selectedPizzas.Remove("Classic");
            }
        }

        private void PeporoniBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PeporoniBox.Checked)
            {
                PeporoniAmount.Enabled = true;
                selectedPizzas["Peporoni"] = 0;  
            }
            else
            {
                PeporoniAmount.Enabled = false;
                PeporoniAmount.Clear();
                selectedPizzas.Remove("Peporoni");
            }
        }
         
        private void CheeseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseBox.Checked)
            {
                CheeseAmount.Enabled = true;
                selectedPizzas["Cheese"] = 0; 
            }
            else
            {
                CheeseAmount.Enabled = false;
                CheeseAmount.Clear();
                selectedPizzas.Remove("Cheese");
            }
        }

        private void ItalianBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ItalianBox.Checked)
            {
                ItalianAmount.Enabled = true;
                selectedPizzas["Italian"] = 0; 
            }
            else
            {
                ItalianAmount.Enabled = false;
                ItalianAmount.Clear();
                selectedPizzas.Remove("Italian");
            }
        }

         

        //------------------------Pizza Quantity---------------------------
        private void ClassicAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ClassicAmount.Text))
            {
                int quantity;
                if (int.TryParse(ClassicAmount.Text, out quantity))
                {
                    if (quantity > 0)
                    {
                        selectedPizzas["Classic"] = quantity;
                    }
                }
            }
        }

        private void PeporoniAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PeporoniAmount.Text))
            {
                int quantity;
                if (int.TryParse(PeporoniAmount.Text, out quantity))
                {
                    if (quantity > 0)
                    {
                        selectedPizzas["Peporoni"] = quantity;
                    }
                }
            }

        }

        private void CheeseAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CheeseAmount.Text))
            {
                int quantity;
                if (int.TryParse(CheeseAmount.Text, out quantity))
                {
                    if (quantity > 0)
                    {
                        selectedPizzas["Cheese"] = quantity;
                    }
                }
            }
        }

        private void ItalianAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ItalianAmount.Text))
            {
                int quantity;
                if (int.TryParse(ItalianAmount.Text, out quantity))
                {
                    if (quantity > 0)
                    {
                        selectedPizzas["Italian"] = quantity;
                    }
                }
            }
        }



        //----------------Customer Info----------------------

        private string customerName;
        private string contactNumber;
        private string customerAdress;


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void NametxtBox_TextChanged(object sender, EventArgs e)
        {
            customerName = NametxtBox.Text;
        }

        private void NumbertxtBox_TextChanged(object sender, EventArgs e)
        {

            contactNumber = NumbertxtBox.Text;

        }

        private void AdresstxtBox_TextChanged(object sender, EventArgs e)
        {
            customerAdress = AdresstxtBox.Text;
        }



        //-----------------OrderInformation------------------------
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Columns.Add("CustomerName", "Customer Name");
            //dataGridView1.Columns.Add("PizzaName", "Pizza Name");
            //dataGridView1.Columns.Add("Quantity", "Quantity");
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(contactNumber) || string.IsNullOrWhiteSpace(customerAdress))
                {
                    MessageBox.Show("Please enter valid customer information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open();


                string insertCustomerQuery = "INSERT INTO Customers (CustomerName, PhoneNumber, CustomerAddress) " +
                                             "VALUES (@CustomerName, @PhoneNumber, @CustomerAddress); SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(insertCustomerQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@PhoneNumber", contactNumber);
                    command.Parameters.AddWithValue("@CustomerAddress", customerAdress);

                    int customerId = Convert.ToInt32(command.ExecuteScalar());


                    string insertOrderQuery = "INSERT INTO [Order] (CustomerID, OrderDate) VALUES (@CustomerID, GETDATE()); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand orderCommand = new SqlCommand(insertOrderQuery, connection))
                    {
                        orderCommand.Parameters.AddWithValue("@CustomerID", customerId);

                        int orderId = Convert.ToInt32(orderCommand.ExecuteScalar());


                        foreach (var pizzaEntry in selectedPizzas)
                        {
                            string pizzaName = pizzaEntry.Key;
                            int quantity = pizzaEntry.Value;

                            string insertPizzaQuery = "INSERT INTO OrderDetail (OrderID, PizzaID, Quantity) " +
                                                      "VALUES (@OrderID, (SELECT DISTINCT PizzaID FROM Pizzas WHERE PizzaName = @PizzaName), @Quantity)";

                            using (SqlCommand pizzaCommand = new SqlCommand(insertPizzaQuery, connection))
                            {
                                pizzaCommand.Parameters.AddWithValue("@OrderID", orderId);
                                pizzaCommand.Parameters.AddWithValue("@PizzaName", pizzaName);
                                pizzaCommand.Parameters.AddWithValue("@Quantity", quantity);

                                pizzaCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                selectedPizzas.Clear();
                customerName = "";
                contactNumber = "";
                customerAdress = "";

                LoadDataIntoDataGridView();

                MessageBox.Show("Order has been submitted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting data into the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }



        private void LoadDataIntoDataGridView()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("CustomerName", "Customer Name");
                    dataGridView1.Columns.Add("PizzaName", "Pizza Name");
                    dataGridView1.Columns.Add("Quantity", "Quantity");
                    dataGridView1.Columns.Add("Status", "Status"); 
                }

                dataGridView1.Rows.Clear(); 

                string selectQuery = @"SELECT C.CustomerName, P.PizzaName, OD.Quantity, O.Status
                                       FROM OrderDetail OD
                                       JOIN Pizzas P ON OD.PizzaID = P.PizzaID
                                       JOIN [Order] O ON OD.OrderID = O.OrderID
                                       JOIN Customers C ON O.CustomerID = C.CustomerID";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string customerName = reader["CustomerName"].ToString();
                        string pizzaName = reader["PizzaName"].ToString();
                        int quantity = Convert.ToInt32(reader["Quantity"]);
                        string status = reader["Status"].ToString();

                        dataGridView1.Rows.Add(customerName, pizzaName, quantity, status);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data into the DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells["CustomerName"].Value != null)
                {
                    string customerName = row.Cells["CustomerName"].Value.ToString();
                    DeleteRowFromDatabase(customerName);
                    dataGridView1.Rows.Remove(row);
                }
                else
                {
                    MessageBox.Show("Invalid Customer Name format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
         


        private void DeleteRowFromDatabase(string customerName)
        {
            try
            {
                connection.Open();


                string deleteOrderDetailQuery = "DELETE FROM OrderDetail WHERE OrderID IN (SELECT OrderID FROM [Order] WHERE CustomerID IN (SELECT CustomerID FROM Customers WHERE CustomerName = @CustomerName))";
                using (SqlCommand command = new SqlCommand(deleteOrderDetailQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.ExecuteNonQuery();
                }

                string deleteOrderQuery = "DELETE FROM [Order] WHERE CustomerID IN (SELECT CustomerID FROM Customers WHERE CustomerName = @CustomerName)";
                using (SqlCommand command = new SqlCommand(deleteOrderQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.ExecuteNonQuery();
                }

                string deleteCustomersQuery = "DELETE FROM Customers WHERE CustomerName = @CustomerName";
                using (SqlCommand command = new SqlCommand(deleteCustomersQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the row from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            NametxtBox.Text = "";
            NumbertxtBox.Text = "";
            AdresstxtBox.Text = "";

            customerName = "";
            contactNumber = "";
            customerAdress = "";
        }


        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();


        }

        private void ShowPendingButton_Click(object sender, EventArgs e)
        {
           
            LoadOrdersByStatus("Pending");
        }

        private void ShowDeliveredButton_Click(object sender, EventArgs e)
        {
            
            LoadOrdersByStatus("Delivered");
        }

        private void ShowCancelledButton_Click(object sender, EventArgs e)
        {
            
            LoadOrdersByStatus("Cancelled");
        }

     

        private void LoadOrdersByStatus(string status)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                dataGridView1.Rows.Clear(); 
                dataGridView1.Columns.Clear();


                dataGridView1.Columns.Add("CustomerName", "Customer Name");
                dataGridView1.Columns.Add("PizzaName", "Pizza Name");
                dataGridView1.Columns.Add("Quantity", "Quantity");
                dataGridView1.Columns.Add("Status", "Status");

                string selectQuery = $@"SELECT C.CustomerName, P.PizzaName, OD.Quantity, O.Status
                                        FROM OrderDetail OD
                                        JOIN Pizzas P ON OD.PizzaID = P.PizzaID
                                        JOIN [Order] O ON OD.OrderID = O.OrderID
                                        JOIN Customers C ON O.CustomerID = C.CustomerID
                                        WHERE O.Status = '{status}'";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string customerName = reader["CustomerName"].ToString();
                        string pizzaName = reader["PizzaName"].ToString();
                        int quantity = Convert.ToInt32(reader["Quantity"]);
                        string orderStatus = reader["Status"].ToString();

                        dataGridView1.Rows.Add(customerName, pizzaName, quantity, orderStatus);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data into the DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void SearcBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearcBox.Text.Trim().ToLower();

            
            if (!string.IsNullOrEmpty(searchTerm))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    dataGridView1.Rows.Clear();

                    string selectQuery = $@"SELECT C.CustomerName, P.PizzaName, OD.Quantity, O.Status
                                            FROM OrderDetail OD
                                            JOIN Pizzas P ON OD.PizzaID = P.PizzaID
                                            JOIN [Order] O ON OD.OrderID = O.OrderID
                                            JOIN Customers C ON O.CustomerID = C.CustomerID
                                            WHERE LOWER(C.CustomerName) LIKE '%{searchTerm}%' OR
                                            LOWER(P.PizzaName) LIKE '%{searchTerm}%' OR
                                            LOWER(O.Status) LIKE '%{searchTerm}%'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string customerName = reader["CustomerName"].ToString();
                            string pizzaName = reader["PizzaName"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            string orderStatus = reader["Status"].ToString();

                            dataGridView1.Rows.Add(customerName, pizzaName, quantity, orderStatus);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                
                LoadDataIntoDataGridView();
            }
        }
    }
} 
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
        private string connectionString = "Data Source=DESKTOP-HRFVO2E\\SQLEXPRESS02;Initial Catalog=orderdbase;Integrated Security=True;";
        SqlConnection connection;

        private Dictionary<string, int> selectedPizzas = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
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
            }
            else 
            {
                PeporoniAmount.Enabled = false;
                PeporoniAmount.Clear();
            } 
            
        }

        private void CheeseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseBox.Checked)
            {
                CheeseAmount.Enabled = true;
            }
            else
            {
                CheeseAmount.Enabled = false;
                CheeseAmount.Clear();
            }
        }

        private void ItalianBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ItalianBox.Checked)
            {
                ItalianAmount.Enabled = true;
            }
            else
            {
                ItalianAmount.Enabled = false;
                ItalianAmount.Clear();
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
            dataGridView1.Columns.Add("PizzaName", "Pizza Name");
            dataGridView1.Columns.Add("Quantity", "Quantity");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

         
            dataGridView1.Rows.Clear();

    
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Category", "Category"); 
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Value", "Value");
            }

          
            foreach (var pizzaEntry in selectedPizzas)
            {
                string pizzaName = pizzaEntry.Key;
                int quantity = pizzaEntry.Value;

                
                dataGridView1.Rows.Add("Pizza", pizzaName, quantity);
            }

         
            dataGridView1.Rows.Add("Customer", customerName, contactNumber, customerAdress);
        } 
          

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            selectedPizzas.Clear();
            customerName = "";
            contactNumber = ""; 
            customerAdress = "";

             
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    } 
}
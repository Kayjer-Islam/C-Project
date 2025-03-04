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

namespace GadgetBD
{
    public partial class user_dashboard : Form
    {

        string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kayjer\Documents\OGMS.mdf;Integrated Security=True;Connect Timeout=30");
        public user_dashboard()
        {
            InitializeComponent();
            LoadData(); 
        }

       
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection(); 
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products WHERE ProductName LIKE @Name", conn);
                da.SelectCommand.Parameters.AddWithValue("@Name", "%" + txtSearch.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
            }
        }

        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); 

            
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                
                if (row.Cells["ProductName"].Value != null && row.Cells["ProductPrice"].Value != null)
                {
                    string productName = row.Cells["ProductName"].Value.ToString();
                    string productPrice = row.Cells["ProductPrice"].Value.ToString();
                    listBox2.Items.Add(productName + " - " + productPrice);
                }
            }
        }
            private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            List<string> selectedProducts = new List<string>();
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string productName = row.Cells["ProductName"].Value.ToString(); 
                string priceString = row.Cells["ProductPrice"].Value.ToString(); 

                // Add the product to the list
                selectedProducts.Add($"{productName} - {priceString}");

                string cleanedPrice = priceString.Replace(" tk", "").Trim();
                decimal price;
                if (decimal.TryParse(cleanedPrice, out price))
                {
                    totalPrice += price;
                }
            }

            if (selectedProducts.Count > 0)
            {
                OrderForm orderForm = new OrderForm(selectedProducts, totalPrice);

                orderForm.FormClosed += (s, args) => this.Show();
                orderForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select at least one product.");
            }
        }

        private void user_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 logIn = new Form1();
            logIn.FormClosed += (s, args) => this.Close();
            logIn.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    } 

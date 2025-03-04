using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GadgetBD
{
    public partial class Form1 : Form
    {
        string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kayjer\Documents\OGMS.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SigupButton
            Signup signUp = new Signup();
            signUp.FormClosed += (s, args) => this.Close();
            signUp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string username = textBox1.Text; 
            string password = textBox2.Text; 

            if (IsValidUser(username, password))
            {
               
                user_dashboard dashboard = new user_dashboard();
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Invalid username or password, please try again.");
            }

            textBox1.Clear();
            textBox2.Clear();
        }

        private void admLogin_Click(object sender, EventArgs e)
        {
            AdminlogIn adminLog = new AdminlogIn();
            adminLog.FormClosed += (s, args) => this.Close();
            adminLog.Show();
            this.Hide();
        }

      
        private bool IsValidUser(string username, string password)
        {
            bool isValid = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                int result = (int)cmd.ExecuteScalar(); 
                if (result == 1)
                {
                    isValid = true;
                }
            }
            return isValid;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}





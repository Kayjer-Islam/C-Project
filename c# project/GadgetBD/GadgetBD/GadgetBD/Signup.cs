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
    public partial class Signup : Form
    {
        string connectionString;
        public Signup()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kayjer\Documents\OGMS.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 logIn = new Form1();
            logIn.FormClosed += (s, args) => this.Close();
            logIn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please enter a username or password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string query = "INSERT INTO Users (Username, Password, Email) VALUES (@UserName, @Password, @Email)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", tbUsername.Text);
                        command.Parameters.AddWithValue("@Password", tbPassword.Text);
                        command.Parameters.AddWithValue("@Email", tbEmail.Text);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registration successful!");

                Form1 logIn = new Form1();
                logIn.FormClosed += (s, args) => this.Close();
                logIn.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 logIn = new Form1();
            logIn.FormClosed += (s, args) => this.Close();
            logIn.Show();
            this.Hide();
        }
    }
}

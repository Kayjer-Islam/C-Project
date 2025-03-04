using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GadgetBD
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kayjer\Documents\OGMS.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from users", con); // Select all data from the users table
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void button1_Click(object sender, EventArgs e) // Insert button
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kayjer\Documents\OGMS.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into users values (@Username, @Password, @Email)", con);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox2.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Inserted");
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e) // Update button
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kayjer\Documents\OGMS.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("update users set Username=@Username, Email=@Email where Password=@Password", con);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox2.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated");
            LoadData(); 
        }

        private void button3_Click(object sender, EventArgs e) // Delete button
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kayjer\Documents\OGMS.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from users where Password=@Password  ", con);
            cmd.Parameters.AddWithValue("@Password", textBox3.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Deleted");
            LoadData(); 
        }

        private void button4_Click(object sender, EventArgs e) // Search button
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kayjer\Documents\OGMS.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from users where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e) // Log out button
        {
            AdminlogIn adminDb = new AdminlogIn();
            adminDb.FormClosed += (s, args) => this.Close();
            adminDb.Show();
            this.Hide();
        }
    }
}

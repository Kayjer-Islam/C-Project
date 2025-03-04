using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GadgetBD
{
    public partial class AdminlogIn : Form
    {
        private string adminUsername1 = "admin1";
        private string adminPassword1 = "admin123";
        public AdminlogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == adminUsername1 && tbPassword.Text == adminPassword1)
            {
                AdminDashboard adminDb = new AdminDashboard();
                adminDb.FormClosed += (s, args) => this.Close();
                adminDb.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 logIn = new Form1();
            logIn.FormClosed += (s, args) => this.Close();
            logIn.Show();
            this.Hide();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class PaymentForm : Form
    {
        private string selectedPaymentMethod = string.Empty;

        public PaymentForm(decimal totalPrice)
        {
            InitializeComponent();
        }

        private void btnPayBkash_Click(object sender, EventArgs e)
        {
            selectedPaymentMethod = "Bkash";
            MessageBox.Show("Selected Payment Method: Bkash", "Payment Method Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPayNagad_Click(object sender, EventArgs e)
        {
            selectedPaymentMethod = "Nagad";
            MessageBox.Show("Selected Payment Method: Nagad", "Payment Method Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPaymentMethod))
            {
                MessageBox.Show("Please select a payment method before confirming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Order & Payment Successful using {selectedPaymentMethod}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            user_dashboard user_dashboard = new user_dashboard();
            user_dashboard.FormClosed += (s, args) => this.Close();
            user_dashboard.Show();
            this.Hide();
        }
    }
}

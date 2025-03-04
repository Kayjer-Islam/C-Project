using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GadgetBD
{
    public partial class OrderForm : Form
    {
        private decimal totalPrice;

        public OrderForm(List<string> selectedProducts)
        {
            InitializeComponent();

            foreach (var product in selectedProducts)
            {
                listBox1.Items.Add(product);
            }

            this.Load += new EventHandler(OrderForm_Load);
        }

        public OrderForm(List<string> selectedProducts, decimal totalPrice) : this(selectedProducts)
        {
            this.totalPrice = totalPrice;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            decimal totalPrice = 0;

            foreach (var item in listBox1.Items)
            {
                string selectedProduct = item.ToString();
                string[] productDetails = selectedProduct.Split('-'); 

                if (productDetails.Length == 2)
                {
                    string priceString = productDetails[1].Trim(); 
                    priceString = priceString.Replace(" tk", "").Trim(); 

                    if (decimal.TryParse(priceString, out decimal price))
                    {
                        totalPrice += price;
                    }
                }
            }

            txtTotalPrice.Text = totalPrice.ToString("N2") + " tk";
        }

        private void BtnGoToPayment_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm(totalPrice); 
            paymentForm.Show(); 
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            user_dashboard user_dashboard = new user_dashboard();
            user_dashboard.FormClosed += (s, args) => this.Close();
            user_dashboard.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

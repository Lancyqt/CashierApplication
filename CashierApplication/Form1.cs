using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem discItem;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void compute_Click(object sender, EventArgs e)
        {
            string name = itemBox.Text;
            double price = Convert.ToDouble(priceBox.Text);
            int quantity = Convert.ToInt32(quantityBox.Text);
            double discount = Convert.ToDouble(discountBox.Text);

            discItem = new DiscountedItem(name, price, quantity, discount);
            double totalPrice = discItem.getTotalPrice();
            label8.Text = totalPrice.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           double paymentAmount = Convert.ToDouble(PayRec.Text);
            discItem.setPayment(paymentAmount);  
            double change = discItem.getChange();
            changeBox.Text = change.ToString();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginAccount form = new frmLoginAccount();
            form.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

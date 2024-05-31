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
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }
        private Cashier cashier;

        private void Login_Click(object sender, EventArgs e)
        {
            cashier = new Cashier("Lance Mauricio", "Finance", usernameBox.Text, passwordBox.Text);

            if(cashier.validateLogin(usernameBox.Text, passwordBox.Text)) 
            {
                MessageBox.Show("Welcome " + cashier.getFullName() + " of " + cashier.getDepartment(), "Success",  MessageBoxButtons.OK);
                frmPurchaseDiscountedItem frm = new frmPurchaseDiscountedItem();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed.", "Failed", MessageBoxButtons.OK);
            }
        }
    }
}

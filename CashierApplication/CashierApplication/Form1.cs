using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashierApplication.ItemNamespace;

namespace CashierApplication
{
    public partial class frmDiscountedPurchaseItem : Form
    {
        public frmDiscountedPurchaseItem()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            double discount = Convert.ToDouble(txtDiscount.Text);
            double price = Convert.ToDouble(txtPrice.Text);
            int qntty = Convert.ToInt32(txtQuantity.Text);

            DiscountedItem obj1 = new DiscountedItem(item, price, qntty, discount);
            obj1.getTotalPrice();

            lblOutput.Text = obj1.getTotalPrice().ToString();

            btnSubmit.Click += new EventHandler(btnSubmit_Click);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double paymentReceived = Convert.ToDouble(txtPR.Text);
            string totalAmountText = lblOutput.Text;
            double totalAmount = Convert.ToDouble(totalAmountText);

            string itemName = txtItem.Text;
            double discount = Convert.ToDouble(txtDiscount.Text);
            double price = Convert.ToDouble(txtPrice.Text);
            int qntty = Convert.ToInt32(txtQuantity.Text);

            DiscountedItem obj1 = new DiscountedItem(itemName, price, qntty, discount);
            obj1.setPayment(paymentReceived);
            double change = obj1.getChange();
            lblChange.Text = change.ToString();
        }
    }
}

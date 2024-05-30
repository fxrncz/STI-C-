using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashierApplication.UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string name = "";
            string department = "";

            Cashier obj1 = new Cashier(name, department, user, pass);
            if(obj1.validateLogin(user, pass) == true)
            {
                Visible = false;
            } else
            {
                txtUser.Text = "";
                txtPass.Text = "";
                MessageBox.Show("Username or password is not matched");
            }
            
        }
    }
}

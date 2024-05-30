using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication.UserAccountNamespace
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password) : base(name, uName, password)
        {
            this.department = department;
        }

        public override bool validateLogin(string uName, string password)
        {
            if(uName.Equals("admin") && password.Equals("123")) 
            {
                frmDiscountedPurchaseItem obj1 = new frmDiscountedPurchaseItem();
                obj1.Show();
                return true;
            } else
            {
                return false;
            }
        }

        public string getDepartment()
        {
            return this.department;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication.UserAccountNamespace
{
    public abstract class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_pass;

        public UserAccount(string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_pass = password;
        }

        public abstract bool validateLogin(string uName, string password);

        public string getFullName()
        {
            return this.full_name;
        }
    }
}

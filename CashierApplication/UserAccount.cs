using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal abstract class UserAccount
    {
        public string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string Uname, string password)
        {
            this.full_name = "Lance Mauricio";
            this.user_name = "cashier101";
            this.user_password = "cashier123";
        }
        public abstract bool validateLogin(string username, string password);

        public string getFullName() 
        { 
            return this.full_name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class User
    {
        private string userName;
        private string password;
        private string message;

        public User(string userName, string password, string message) {
        this.userName = userName;   
        this.password = password;
            this.message = message; 
        }
        public string checkLogin()
        {
            if(this.userName== "Admin" && this.password == "123") {
                this.message = "You are Logged in as Admin!!";
                    
            }else if (this.userName.StartsWith("User") && this.password == "Pass123")
            {
                this.message = "You are Logged in as Admin!!";

            }
            else
            {
                this.message = "Invalid Credentials!!";

            }
            return this.message;
        }

    }
}

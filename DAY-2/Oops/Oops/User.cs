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
        private string address;
        private bool isMarried = false;


        public User(string userName, string password) {
        this.userName = userName;   
        this.password = password;
         
        }
        public User(string userName, string password,string message)
        {
            this.userName = userName;
            this.password = password;
            this.message = message;

        }
        public User(string userName, string password,string message ,string address)
        {
            this.userName = userName;
            this.password = password;
            this.message = message;
            this.address = address;

        }
        public User(string userName, string password, string message, string address, bool isMarried)
        {
            this.userName = userName;
            this.password = password;
            this.message = message;
            this.address = address;
            this.isMarried = isMarried;

        }
       
        public void getDetails()
        {
            Console.WriteLine("USername : " + userName);
            Console.WriteLine("Password : " + password);

            if(this.address != null)
            {
                Console.WriteLine("Address : " + this.address);
            }
            Console.WriteLine("Is Married : " + this.isMarried);
        }
        public string checkLogin()
        {
            if(this.userName== "Admin" && this.password == "123") {
                if (this.message == null)
                {
                    this.message = "You are Logged in as Admin!!";
                }
                    
            }else if (this.userName.StartsWith("User") && this.password == "Pass123")
            {
                if (this.message == null)
                {
                    this.message = "You are Logged in as Normal User!!";
                }
            }
            else
            {
                if (this.message == null)
                {
                    this.message = "Invalid Login!!";
                }

            }
            return this.message;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class InnerClass
    {
        public class Address
        {
            public class Contact
            {
                public string name = "Siva";
                public void getContact()
                {
                    Console.WriteLine("Name : " + name + " " + "Chennai -600028");
                }
            }
        }
    }
}

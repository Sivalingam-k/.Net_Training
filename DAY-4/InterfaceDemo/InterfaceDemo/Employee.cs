using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Employee : IAddress, IContact
    {
        public string ename {  get; set; }
        public string addressLine1 { get; set; }
        public string city { get ; set; }
        public string state { get; set ; }
        public int postcode { get; set; }
        public string email { get ; set ; }
        public long mobile { get ; set ; }

        public void AddressDetails()
        {
            Console.WriteLine("EmployeeDetails :");
            Console.WriteLine("Employee Name :" + ename);
            string address =  this.addressLine1 + "," + this.city +  "," + this.state + "," + this.postcode;
            Console.WriteLine(address);

        }

        public void getContactDetails()
        {
            Console.WriteLine("Employee Contact Details :");
            Console.WriteLine("Email : " + email);
            Console.WriteLine("Phone : " + this.mobile);
        }
    }
}

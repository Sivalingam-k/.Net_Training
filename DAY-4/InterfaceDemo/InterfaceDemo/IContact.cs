using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IContact
    {
        abstract string email { get; set; }
        abstract long mobile { get; set; }

         abstract void getContactDetails();
       
    }
}

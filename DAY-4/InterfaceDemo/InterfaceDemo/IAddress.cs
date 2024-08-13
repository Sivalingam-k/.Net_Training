using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IAddress
    {
        abstract string addressLine1 { get; set; }
        abstract string city { get; set; }
        abstract string state { get; set; }
        abstract int postcode { get; set; }


         abstract void AddressDetails();
        
    }
}

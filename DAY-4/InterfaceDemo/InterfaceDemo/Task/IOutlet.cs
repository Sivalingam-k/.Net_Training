using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Task
{
    internal interface IOutlet
    {
        string outlet_name { get; set; }
        string outlet_city { get; set; }
        string outlet_location { get; set; }


        public string getOutletDetails();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY.Task
{
    internal class Month
    {

        private static void Main(string[] args)
        {
            string[] months = { "Jan", "Feb", "Mar", "April", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            ////Sort an array
            Console.WriteLine("Sorted Array in Asscending Order :");
            Array.Sort(months);
            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }
            ////Reverse an array
            Console.WriteLine("Reverse the Sorted Array :");
            Array.Reverse(months);
            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }
            //Index of Particular Month

            int monthnumber = Array.IndexOf(months,"Jan");

            Console.WriteLine("Number of the Month :" + (monthnumber + 1));

            //Clear one particular index value(it will only make empty).
            Console.WriteLine("Removing one value from the array :");
            Array.Clear(months, 0,1);
            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }

            //Inserting a value in one particular index
            Console.WriteLine("Inserting one value from the array :");
            months[0] = "september";
            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }

            Array.Resize(ref months, 13);
            months[12] = "Festival Month";

            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }

            //Copy Array
            Console.WriteLine("Copying to Another Array");
            string[] copy_months = new string[months.Length];
            months.CopyTo(copy_months, 0);

            foreach (string cmon in copy_months)
            {
                Console.WriteLine(cmon);
            }
        }


    }
    
}

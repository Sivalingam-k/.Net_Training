using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Dictionary
    {


        static void Main(string[] args)
        {
            Dictionary<int, string> empdetails;

            empdetails = new Dictionary<int, string>();

            empdetails.Add(100, "Parag");

            empdetails.Add(102, "Prachi");

            empdetails.Add(103, "Manas");
            
            string ename = empdetails[102];

            Console.WriteLine(ename);

            Console.WriteLine("Sorted List ");
            Console.WriteLine();
            SortedList<string, int> Marks;

            Marks = new SortedList<string, int>();

            Marks.Add("Maths", 80);

            Marks.Add("Physics", 90);

            Marks.Add("English", 65);

            Marks.Add("Chemistry", 75);
            
            foreach (string key in Marks.Keys)

            {

                Console.WriteLine(Marks[key]);

            }


            //Some Inbuild Methods:

            //1. Contains Key
            Console.WriteLine(Marks.ContainsKey("English"));


            //2. Contains Value
            Console.WriteLine(Marks.ContainsValue(75));

            //3.Remove Method
            Console.WriteLine(Marks.Remove("Maths"));

            //4.Count
            Console.WriteLine(Marks.Count);

            //5.clear
            Marks.Clear();










        }
    }
}

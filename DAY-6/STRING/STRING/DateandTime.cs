using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRING
{
    internal class DateandTime
    {
        static void Main(string[] args)
        {
           

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();
            Console.WriteLine("default Time : " + dt1);
            Console.WriteLine();
            //assigns year, month, day
            DateTime dt2 = new DateTime(2024, 08, 14);
            Console.WriteLine(" Year-Month-Day : " + dt2);
            Console.WriteLine();
            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2024, 08, 14, 5, 10, 20);
            Console.WriteLine(" Year-Month-Day hour-min-sec : " + dt3);
            Console.WriteLine();

            //Static Dates
            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            Console.WriteLine("Current Date And Time :" +currentDateTime);
            Console.WriteLine();
            DateTime todaysDate = DateTime.Today; // returns today's date
            Console.WriteLine("Today Date : " +todaysDate);
            Console.WriteLine();
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            Console.WriteLine("Utc Current Date and Time :"+currentDateTimeUTC);
            Console.WriteLine();
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            Console.WriteLine("Max Date Time Value : " +maxDateTimeValue);
            Console.WriteLine();
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime
            Console.WriteLine("min Date Time Value : "+minDateTimeValue);
            Console.WriteLine();


            //Timespan

            DateTime dt = new DateTime(2015, 12, 31);

            TimeSpan ts = new TimeSpan(25, 20, 55);

            DateTime newDate = dt.Add(ts);

            Console.WriteLine(newDate);//1/1/2016 1:20:55 AM


            //Convert String to DateTime
            var str = "5/12/2020";
            DateTime dts;

            var isValidDate = DateTime.TryParse(str, out dts);

            if (isValidDate)
                Console.WriteLine(dts);
            else
                Console.WriteLine($"{str} is not a valid date string");
        }
    }
}

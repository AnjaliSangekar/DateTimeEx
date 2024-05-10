using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            datetimeformat();
            Console.WriteLine();
            daymonthyear();
        }


        public static void datetimeformat()
        {

            DateTime dt1 = new DateTime(2024, 5, 8, 10, 39, 0);
            Console.WriteLine("Complete date: " + dt1.ToString());


            DateTime dateOnly = dt1.Date;


            Console.WriteLine("Short Date: " + dateOnly.ToString("d"));


            Console.WriteLine("Display date using 24-hour clock format:");


            Console.WriteLine(dateOnly.ToString("g"));


            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));
        }


        public static void daymonthyear()
        {


            System.DateTime moment = new System.DateTime(2024, 6, 20, 3, 57, 31, 11);

           
            Console.WriteLine("year = " + moment.Year);

        
            Console.WriteLine("month = " + moment.Month);

           
            Console.WriteLine("day = " + moment.Day);

           
            Console.WriteLine("hour = " + moment.Hour);

            Console.WriteLine("minute = " + moment.Minute);

            
            Console.WriteLine("second = " + moment.Second);

            
            Console.WriteLine("millisecond = " + moment.Millisecond);
        }
    
    }
}

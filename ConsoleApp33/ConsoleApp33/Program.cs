using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert 12 hour time to 24 hour time
            Console.Write("Enter hour for 12 hr time: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            //Enter hour in 12 hour time

            Console.Write("Enter min for 12 hr time: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            //Enter Minutes in 12 hour time

            Console.Write("Enter sec for 12 hr time: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            //Enter seconds in 12 hour time

            string AMPM;
            Console.Write("AM or PM?:");
            AMPM =Convert.ToString(Console.ReadLine());
            //Enter AM,PM

            //print out in 24 hour time format     
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number:");
            int number1 = 2000;
            Console.WriteLine(number1);
            Console.Write("Enter A Number:");
            int number2 = 8;
            Console.WriteLine(number2);
            Console.Write("Enter A Number:");
            int number3 =90;
            Console.WriteLine(number3);
            int average;
            int math;
            Console.Write("Average:");
            math = (number1 + number2 + number3);
            average = (math / 3);
            Console.WriteLine(average);
            

        }
    }
}

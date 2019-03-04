using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3;
            Console.Write("Enter a number:");
            number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter a number:");
                number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number:");
            number3 = Convert.ToDouble(Console.ReadLine());

            double total = (number1 + number2 + number3)/4;
            Console.WriteLine(total);

        }
    }
}
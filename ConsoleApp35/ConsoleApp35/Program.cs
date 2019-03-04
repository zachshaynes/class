using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a starting balance:");
            double start = Convert.ToInt32(Console.ReadLine()); //get starting balance

            Console.WriteLine("Enter yearly contribution:");
            int contribute = Convert.ToInt32(Console.ReadLine()); //get yearly contribution

            Console.WriteLine("Enter average return in %:");
            int avg = Convert.ToInt32(Console.ReadLine()); //get average return

            Console.WriteLine("Enter amount of years:");
            int year = Convert.ToInt32(Console.ReadLine()); //get amount of years

            
            Console.WriteLine("Starting balance:");
            Console.WriteLine(start);

            double money = start + contribute;
            double math = avg / 100.0 + 1;
            int counter = 1;
            int yearCounter = 0;
            double result;

            while (year > yearCounter)
            {

                money = start + contribute;
                result = (math * money);
                start = math + result;
                Console.Write("year");
                Console.Write(counter);
                Console.Write(":");
                Console.WriteLine(start);
                yearCounter = yearCounter + 1;
                counter = counter + 1;
            }
          
            
            
            
        
           

            
       
           

          
        }

    }
}
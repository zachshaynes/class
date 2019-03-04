using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a starting number:");
            int start= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an ending number");
            int end= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime Numbers:");

            if (start < 2)
            {
                start = 2;
            }


                while (start < end)
            {

                //check if start is prime 
                int two = 2;
                bool isPrime = true;
                while (two < start)
                {

                    if (start % two == 0)
                    {
                        isPrime = false;

                    }
                    two = two + 1;

                }


                if (isPrime == true)
                {
                    Console.WriteLine(start);
                    

                }
                start = start + 1;
            }



            Console.ReadKey();
        }
    }
}

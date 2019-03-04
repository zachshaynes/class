using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a starting number:");//prompts the user to enter starting number
            int start = Convert.ToInt32(Console.ReadLine());//creates "start" variable start and sets the value to the users typed input

            Console.WriteLine("Enter an ending number");//prompts the user to enter and ending number
            int end = Convert.ToInt32(Console.ReadLine());//creates "end" variable and sets the value to the users typed input

            Console.WriteLine("Prime Numbers:");//writes "Prime Numbers"

            if (start < 2)//sets the value of start to two if it the users input is less than 2 
            {
                start = 2;
            }


            while (start < end)
            {

                //check if start is prime 
                int two = 2;//declares integer 2 and sets the value to 2
                bool isPrime = true;
                while (two < start)
                {

                    if (start % two == 0)//checks if number can be divided by two evenly 
                    {
                        isPrime = false;

                    }
                    two = two + 1; //adds one to variable "two"  

                }

                if (isPrime == true)//if isPrime remains true 
                    {
                        Console.WriteLine(start);//print out start


                    }
                    start = start + 1; //add one to variable "start"
                }
            }
        }
    }













        
    

    


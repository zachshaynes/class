﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            //call MyMathFunction Passing in 5 for A, 6 for B, and 7 for C
            MyMathFunction(5, 6, 7);
            //call MyMathFunction2 Passing in 6 for A, 9 for B, and 12 for C
            MyMathFunction2(6, 9, 12);
            // create a variable called var1 and put the value 12.8 into it
            double var1 = 12.8;
            // create a variable called var2 and put the value 123.5 into it
            double var2 = 123.5;
            // create a variable called var3 and put the value 45.1 into it
            double var3 = 45.1;
            //call MyMathFunction Passing in var1 for A, var2 for B, and var3 for C
            MyMathFunction(var1, var2, var3);
            //call MyMathFunction2 Passing in var1 for A, var2 for B, and var3 for C
            MyMathFunction2(var1, var2, var3);

            //call the PrintStuff function
            PrintStuff();

            //call MinVal and and pass in  7 for A, 12 for B, and 4 for C
            MinVal(7, 12, 4);
            //call MinVal and and pass in  1 for A, 12 for B, and 4 for C
            MinVal(1, 12, 4);
            //call MinVal and and pass in  12 for A, 4 for B, and 999 for C
            MinVal(12, 4, 999);

            //Create a MaxVal function that returns the maximum value from three inputs
            //Do this outside of the main function.

            //call MaxVal and and pass in  7 for A, 12 for B, and 4 for C
            
            //call MaxVal and and pass in  1 for A, 12 for B, and 4 for C
            //call MaxVal and and pass in  12 for A, 4 for B, and 999 for C
        }

        static double MaxVal(double A, double B, double C)
        {
            if (A >= B && A >= C)
            {
                return A;
            }

            else if (B >= A && B >= C)
            {
                return B;
            }

            else return C;
        }






        static double MyMathFunction(double A, double B, double C)
        {
            double answer = A * B + C / A;
            return answer;
        }
        static double MyMathFunction2(double A, double B, double C)
        {
            double answer = (A + B + C) / A;
            return answer;
        }
        static double MinVal(double A, double B, double C)
        {
            if (A <= B && A <= C)
            {
                return A;
            }
            else if (B <= A && B <= C)
            {
                return B;
            }
            else
            {
                return C;
            }
        }
        static void PrintStuff()
        {
            Console.WriteLine("Why do Ghosts love elevators?");
            Thread.Sleep(1000);
            Console.WriteLine("because they lift their spirits!");
            Thread.Sleep(1000);
            Console.WriteLine("Why did the hipster burn his mouth?");
            Thread.Sleep(1000);
            Console.WriteLine("Because he sipped his coffee before it was cool.");
        }
    }

}


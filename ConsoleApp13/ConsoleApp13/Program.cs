using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //copy the following code to a new project and
            //fix the errors in the conversions below 
            //also answer each of the questions in comments.

            int myInt1= 1;//"1"//I changed it to an int
            float myFloat = 10.7f;
            double myDouble = 10.9123457890;
            bool myBool = true;//its not boolean in C#
            long myLong = 123123;
            int myInt = 12;

            myDouble = myFloat;
            myDouble = myInt;
            myDouble = myLong;
            myDouble = myInt1;

            //How come only the string needs to be converted? //Because an integer is needed for a number a string is meant for human readable text.
            

            myInt1 = 1;//"1"
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;

            myFloat = myDouble;
            myFloat = myInt;
            myFloat = myLong;
            myFloat = myString;
            //why does the double need to be cast/converted to a float but it did not need to be done in the opposite direction
            //Because the float is a single precision number while a double hence the name is a double precision number.

            myString = "1";//"1"
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;

            myInt = myDouble;
            myInt = myFloat;
            myInt = myLong;
            myInt = myString;
            //what is the value of myInt after the conversion from myDouble?  why is it not the same value of myDouble


            myString = "1";//"1"
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;

            myLong = myDouble;
            myLong = myFloat;
            myLong = myInt;
            myLong = myString;


            myString = "1";//"1"
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;

            myString = myDouble;
            myString = myFloat;
            myString = myInt;
            myString = myLong;
        }
    }
}

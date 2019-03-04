using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name = Input("What is your Name?");//calls the function "Input" which prompts the user to enter their name and returns it into the variable "name"
                bool tOrF = false;

                int randnum = GenerateNumber();//generates random number
                int i = 0;//integer that will keep track of the amount of guesses
                while (tOrF == false)
                {
                    int guess = GetGuess();//calls the function "get guess" and stores the value into the variable "guess"
                    i = i + 1;

                    tOrF = CheckGuess(randnum, guess);//calls the function get guess with the inputs of "randnum" and "guess"
                    if (tOrF == true)
                    {
                        break;
                    }

                }

                Console.WriteLine("Congratulations:");
                Console.Write(name);
                Console.WriteLine("Your Number was correct!!!");
                Console.WriteLine("Number of Guesses:");
                Console.WriteLine(i);

                string answer = Input("Do you want to play again?");
                if (answer.ToLower().Equals("yes"))
                {
                    continue;
                }

                else if ((answer.ToLower().Equals("no")))
                {
                    return;
                }

            }



        }

        static string Input(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return value;
        }


        static int IntInput(string textToDisplay)
        {
            while (true)
            {
                try
                {
                    int val = Convert.ToInt32(Input(textToDisplay));
                    return val;
                }
                catch
                {
                    Console.WriteLine("Enter an integer");
                    continue;
                }
            }

        }

        static int GenerateNumber()
        {
            Random rand = new Random();
            int n = rand.Next(1, 100);
            return n;
        }

        static int GetGuess()
        {

            while (true)
            {
                int capture = IntInput("enter a number between 1-100:");//prompt the user to guess a number between 1 and 100 (use IntInput you created to do this.
                if (0 < capture && capture <= 100)//if statement makes sure that the number is truly between 1 and 100
                {
                    return capture;//and if it is not betweent those 2 it will re prompt the user to try again until it is correct
                }
            }

        }

        static void PrintHint(int userguessednumber, int secretnumber)//this function holds what the program should print out when the number is too large and when the number is too small
        {


            if (userguessednumber < secretnumber)
            {
                Console.WriteLine("Your number was too small");
            }



            else if (userguessednumber > secretnumber)
            {
                Console.WriteLine("Your number was too Large");

            }


        }

        static bool CheckGuess(int secretnumber, int guessednumber)//this function keeps returning the value of the users guessed number as either false or true
        {
            if (guessednumber == secretnumber)
            {
                return true;
            }

            else
            {
                PrintHint(guessednumber, secretnumber);
                return false;
            }

        }
    }
    
}

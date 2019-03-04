using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name = Input("What is your Name?");
                bool tOrF = false;

                int randnum = GenerateNumber();
                int i = 0;
                while (tOrF == false)
                {
                    int guess = GetGuess();
                    i = i + 1;

                    tOrF = CheckGuess(randnum, guess);
                    if (tOrF == true)
                    {
                        break;
                    }

                }
                //correct
                Console.WriteLine("Your Number was correct");
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

        //function name: IntInput
        //inputs:string to be used as a prompt
        //get input from the user (using Input)
        //this should continue to reprompt the user and get new input until an integer is entered by the user
        //Returns: the integer that the user entered
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
            //What it should do: 
            while (true)
            {
                int capture = IntInput("enter a number between 1-100:");//prompt the user to guess a number between 1 and 100 (use IntInput you created to do this.
                if (0 < capture && capture <= 100)
                {
                    return capture;
                }
            }//while the number returned by the function is not valid have it reask for a number
            //Returns: the number the user entered (should be valid integer between 1-100 at this point)

        }

        static void PrintHint(int userguessednumber, int secretnumber)
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

        static bool CheckGuess(int secretnumber, int guessednumber)
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


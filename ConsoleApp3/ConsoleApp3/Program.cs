using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Everything up here, before the if-statement will
            // always be executed.
            int score;

            Console.Write("Enter your score: ");        // Writes the text out without going to the next line.
            string scoreAsText = Console.ReadLine();
            score = Convert.ToInt32(scoreAsText);

            if (score == 100)
            {
                // The stuff here inside of the if-statement's code
                // block only gets executed when the condition is met--
                // in this case, if the score is 100.

                Console.WriteLine("Perfect score! You win!")

        }
    }
}

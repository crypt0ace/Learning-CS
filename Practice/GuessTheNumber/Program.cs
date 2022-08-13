using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Easy()
        {
            // Getting random number
            Random rand = new Random();

            // Making it between 0-90
            int right = rand.Next(0, 99);

            bool win = false;
            do
            {
                // Getting user input
                Console.WriteLine("Guess a 2 digit number: ");
                string userInput = Console.ReadLine();
                int guess = int.Parse(userInput);

                if (userInput.Length > 2)
                {
                    Console.WriteLine("Please only choose 2 digit number");
                    continue;
                }
                else if (userInput.Length < 2)
                {
                    Console.WriteLine("Please only choose 2 digit number");
                    continue;
                }

                if (guess > right)
                {
                    Console.WriteLine("Too High. Try Lower...");
                }
                else if (guess < right)
                {
                    Console.WriteLine("Too Low. Try Higher...");
                }
                else if (guess == right)
                {
                    Console.WriteLine("You WIN!!");
                    win = true;
                }

            } while (win == false);
        }

        static void Medium()
        {
            // Getting random number
            Random rand = new Random();

            // Making it between 0-999
            int right = rand.Next(0, 999);

            bool win = false;
            do
            {
                // Getting user input
                Console.WriteLine("Guess a 3 digit number: ");
                string userInput = Console.ReadLine();
                int guess = int.Parse(userInput);


                if (userInput.Length > 3)
                {
                    Console.WriteLine("Please only choose 3 digit number");
                    continue;
                }
                else if (userInput.Length < 3)
                {
                    Console.WriteLine("Please only choose 3 digit number");
                    continue;
                }

                if (guess > right)
                {
                    Console.WriteLine("Too High. Try Lower...");
                }
                else if (guess < right)
                {
                    Console.WriteLine("Too Low. Try Higher...");
                }
                else if (guess == right)
                {
                    Console.WriteLine("You WIN!!");
                    win = true;
                }

            } while (win == false);
        }

        static void Hard()
        {
            // Getting random number
            Random rand = new Random();

            // Making it between 0-999
            int right = rand.Next(0, 9999);

            bool win = false;
            do
            {
                // Getting user input
                Console.WriteLine("Guess a 4 digit number: ");
                string userInput = Console.ReadLine();
                int guess = int.Parse(userInput);


                if (userInput.Length > 4)
                {
                    Console.WriteLine("Please only choose 4 digit number");
                    continue;
                }
                else if (userInput.Length < 4)
                {
                    Console.WriteLine("Please only choose 4 digit number");
                    continue;
                }

                if (guess > right)
                {
                    Console.WriteLine("Too High. Try Lower...");
                }
                else if (guess < right)
                {
                    Console.WriteLine("Too Low. Try Higher...");
                }
                else if (guess == right)
                {
                    Console.WriteLine("You WIN!!");
                    win = true;
                }

            } while (win == false);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to guess the number game!");
            Console.WriteLine("What level do you want to choose.");
            Console.WriteLine("Type 1 for Easy. Type 2 for medium. Type 3 for hard.");
            int level = int.Parse(Console.ReadLine());

            if (level == 1)
            {
                Easy();
            }
            else if (level == 2)
            {
                Medium();
            }
            else if (level == 3)
            {
                Hard();
            }
            else
            {
                Console.WriteLine("Please choose one of the given levels.");
            }
        }
    }
}

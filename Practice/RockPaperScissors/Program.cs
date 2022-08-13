using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Options
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, Paper, Scissors SHOOT!");
            string userInput = Console.ReadLine().ToUpper();

            string[] computerChoice = new string[3] { "ROCK", "PAPER", "SCISSOR" };
            Random rnd = new Random();
            int n = rnd.Next(0, 3);

            if (userInput == "ROCK" && computerChoice[n] == "PAPER")
            { 
                Console.WriteLine("You chose Rock.");
                Console.WriteLine("The Computer chose Paper.");
                Console.WriteLine("The computer wins.. :(");
            }
            else if (userInput == "PAPER" && computerChoice[n] == "ROCK") 
            { 
                Console.WriteLine("You chose Paper.");
                Console.WriteLine("The computer chose Rock.");
                Console.WriteLine("You WIN! :)");
            }
            else if (userInput == "SCISSORS" && computerChoice[n] == "ROCK") 
            { 
                Console.WriteLine("You chose Scissors.");
                Console.WriteLine("The computer chose Rock.");
                Console.WriteLine("The computer wins... :(");
            }
            else if (userInput == "ROCK" && computerChoice[n] == "SCISSORS")
            {
                Console.WriteLine("You chose Rock.");
                Console.WriteLine("The computer chose Scissors.");
                Console.WriteLine("You WIN! :)");
            }
            else if (userInput == "PAPER" && computerChoice[n] == "SCISSORS")
            {
                Console.WriteLine("You chose Paper.");
                Console.WriteLine("The computer chose Scissors.");
                Console.WriteLine("The computer wins... :(");
            }
            else if (userInput == "SCISSORS" && computerChoice[n] == "PAPER")
            {
                Console.WriteLine("You chose Scissors.");
                Console.WriteLine("The computer chose Paper.");
                Console.WriteLine("You WIN! :)");
            }
            else
            {
                Console.WriteLine("Its a TIE!");
            }
        }
    }
}

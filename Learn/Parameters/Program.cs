using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo("Hello ");

            // Default values
            Country("USA");
            Country("Canada");
            Country();
            Country("Italy");

            // Multiple values in parameters
            more("Ace", 21);
            more("Dom", 30);
            more("Kendal", 27);

            // Using return
            Console.WriteLine(ans(37));

            // Using named arguments
            usernames(name1: "John", name2: "Bob", name3: "Charles");

            // Multiple values same parameter shit
            int num1 = PlusNumber(10, 10);
            double num2 = PlusNumber(10.5, 3.6);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        static void Demo(string hello)
        {
            Console.WriteLine(hello + "Ahmed!");
        }

        // Default values
        static void Country(string names = "United Kingdom")
        {
            Console.WriteLine("Welcome to " + names);
        }

        // Multiple values in parameters
        static void more(string firstName, int age)
        {
            Console.WriteLine("This is " + firstName + ". He is " + age + " years old.");
        }

        // Using return
        static int ans(int x)
        {
            return (1300 + x);
        }

        // Using named arguments
        static void usernames(string name1, string name2, string name3)
        {
            Console.WriteLine("This is " + name2);
        }

        // Multiple values same parameter shit
        static int PlusNumber(int x, int y)
        {
            return x + y;
        }
        static double PlusNumber(double x, double y)
        {
            return x + y;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Welcome " + username);

            // Converting data type to integer
            Console.WriteLine("Whats your age?: ");
            string age = Console.ReadLine();
            int ageNum = Convert.ToInt32(age);
            Console.WriteLine("You are " + ageNum + " years old.");
        }
    }
}

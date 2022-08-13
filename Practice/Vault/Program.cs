using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the vault");
            Console.WriteLine("Please state your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please state your last name: ");
            string lastName = Console.ReadLine();

            string greeting = $"Welcome {firstName} {lastName}";
            Console.WriteLine(greeting);

            Console.WriteLine("Please enter your 4 digit pass code to enter the vault: ");
            int pass = int.Parse(Console.ReadLine());

            /*
             * We gotta fix this visible pass code in the source code. Hope no one looks at it
             */
            if (pass == 1337)
            {
                Console.WriteLine("Access Granted!");
                Console.WriteLine("Press any key to fetch the flag.");
                Console.ReadKey();
                Console.WriteLine("Here is the secret: FLAG{g00D_J0b}");
            }
            else
            {
                Console.WriteLine("Wrong pass. Did you forget it again " + firstName + "?");
            }
        }
    }
}

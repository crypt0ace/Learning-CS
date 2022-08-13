using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ace";
            Console.WriteLine(name);

            int number = 1337;
            Console.WriteLine(number);

            double dec = 13.37;
            Console.WriteLine(dec);

            char a = 'a';
            Console.WriteLine(a);

            bool t = true;
            Console.WriteLine(t);

            // Assigning variable first giving it the value later
            int testnum;
            testnum = 15;
            Console.WriteLine(testnum);

            // We can aslo overwrite the values of assigned variables
            string demo = "Demo 0";
            demo = "Demo 1";
            Console.WriteLine(demo);

            // Constant variable set
            const string testing = "This is a test";
            // string testing = "Oh no";
            Console.WriteLine(testing);

            // Appending variable to WriteLine
            string demoName = "Ace";
            Console.WriteLine("Hey there " + demoName);

            // Appending variables together
            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            // Using math expressions together
            int o = 10;
            int p = 5;
            Console.WriteLine(o + p);
            
            // Multiple variables with same values
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);
        }
    }
}

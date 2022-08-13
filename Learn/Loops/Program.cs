using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Not yet " + i);
                i++;
            }

            // Do/While Loop
            int a = 5;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 5);

            // For Loop
            for (int b = 0; b < 5; b++)
            {
                Console.WriteLine(b);
            }

            for (int c = 0; c <= 10; c = c + 2)
            {
                Console.WriteLine(c);
            }

            // For Each Loop
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            foreach (string x in days)
            {
                Console.WriteLine(x);
            }

            // Using break to jump out of a loop
            for (int e = 0; e < 10; e++)
            {
                if (e == 5)
                {
                    break;
                } 
                Console.WriteLine(e);
            }

            // Using continue to continue execution
            for (int e = 0; e < 10; e++)
            {
                if (e == 5)
                {
                    continue;
                }
                Console.WriteLine(e);
            }

            // Break in a while loop
            int z = 0;
            while (i < 10)
            {
                Console.WriteLine(z);
                z++;
                if (z == 5)
                {
                    break;
                }
            }
        }
    }
}

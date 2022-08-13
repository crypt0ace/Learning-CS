using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine(days[6]);

            // Changing array object
            days[0] = "demo";
            Console.WriteLine(days[0]); // Output = demo

            // Array length
            Console.WriteLine(days.Length); // Output = 7

            // Looping through array
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

            // Foreach Loop
            foreach (string x in days)
            {
                Console.WriteLine(x);
            }

            //Sorting an array
            Array.Sort(days);
            foreach (string y in days)
            {
                Console.WriteLine(y);
            }

            // Using System.Linq namespace to use Min, Max methods
            int[] myNum = { 1, 2, 3, 4, 5 };
            Console.WriteLine(myNum.Max());  // returns the largest value
            Console.WriteLine(myNum.Min());  // returns the smallest value
            Console.WriteLine(myNum.Sum());  // returns the sum of elements
        }
    }
}

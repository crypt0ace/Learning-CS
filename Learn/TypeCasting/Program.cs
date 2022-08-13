using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit type casting
            int myNum = 50;
            double myDouble = myNum;
            Console.WriteLine(myNum);
            Console.WriteLine(myDouble);

            // Explicit type casting
            double newDouble = 9.87;
            int newNum = (int) newDouble;
            Console.WriteLine(newDouble);
            Console.WriteLine(newNum);

            // Other type conversions
            int myInt = 10;
            double myDub = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDub));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }
    }
}

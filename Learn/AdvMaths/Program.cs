using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvMaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bigger = Math.Max(5, 10);
            Console.WriteLine(bigger);

            int smaller = Math.Min(5, 10);
            Console.WriteLine(smaller);

            double square = Math.Sqrt(64);
            Console.WriteLine(square);

            int positive = Math.Abs(-1337);
            Console.WriteLine(positive);

            double rounded = Math.Round(10.79);
            Console.WriteLine(rounded);
        }
    }
}

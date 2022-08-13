using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 1000 + 30;
            int sum2 = sum + 300;
            int sum3 = sum2 + 7;
            Console.WriteLine(sum3);

            // Other operators
            int mod = 102 % 5;
            Console.WriteLine(mod);

            // Using assignment operators
            int newNum = 10;
            newNum += 5;
            Console.WriteLine(newNum);


        }
    }
}

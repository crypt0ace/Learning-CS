using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Can be called multiple times
            MyMethod();
            MyMethod();
            MyMethod();
        }
        static void MyMethod()
        {
            Console.WriteLine("Hey there!");
        }
    }
}

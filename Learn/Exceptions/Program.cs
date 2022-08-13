using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void checkAge(int age)
        {
            if (age > 18)
            {
                Console.WriteLine("Access Granted - You are old enough.");
            }
            else
            {
                throw new ArithmeticException("Access Denied - Not old enough.");
            }
        }
        static void Main(string[] args)
        {
            checkAge(15);
            checkAge(20);
        }
    }
}

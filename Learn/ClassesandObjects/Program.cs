using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandObjects
{
    class demo
    {
        string test = "Testing";
        static void Main(string[] args)
        {
            demo newDemo = new demo();
            demo newDemo2 = new demo();
            Console.WriteLine(newDemo.test);
            Console.WriteLine(newDemo2.test);

            // Accessing other classes
            car newObj = new car();
            Console.WriteLine(newObj.name);
        }
    }
}

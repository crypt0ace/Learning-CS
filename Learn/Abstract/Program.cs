using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Demo
    {
        public abstract void Method();
        public void Test()
        {
            Console.WriteLine("This is a demo.");
        }
    }

    class Access : Demo
    {
        public override void Method()
        {
            Console.WriteLine("Accessing abstract class from another class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Access newObj = new Access();
            newObj.Test();
            newObj.Method();
        }
    }
}

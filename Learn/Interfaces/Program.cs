using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ITest
    {
        void Test();
    }

    interface IDemo
    {
        void Method();
    }

    class Demo : ITest, IDemo
    {
        public void Test()
        {
            Console.WriteLine("This is a test");
        }

        public void Method()
        {
            Console.WriteLine("This is a demo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo newObj = new Demo();
            newObj.Test();
            newObj.Method();
        }
    }
}

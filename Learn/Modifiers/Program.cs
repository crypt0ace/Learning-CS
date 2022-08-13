using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    class Demo
    {
        private string demo = "Test";
        static void Main(string[] args)
        {
            Demo newObj = new Demo();
            Console.WriteLine(newObj.demo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Access
    {
        public string name = "Ace.";

        public void greet()
        {
            Console.WriteLine("Heyyaa!!");
;       }
    }

    class Intro : Access
    {
        public string start = "Its nice to meet you.";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Intro newObj = new Intro();
            newObj.greet();
            Console.WriteLine(newObj.start);
            Console.WriteLine(newObj.name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Intro
    {
        private string name;

        public string Name
        {
            get;
            set;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Intro newObj = new Intro();
                newObj.Name = "Ace";
                Console.WriteLine(newObj.Name);
            }
        }
    }
}

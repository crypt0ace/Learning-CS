using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructors2
{
    class Intro
    {
        public string fName;
        public string lName;
        public int age;

        public Intro(string first, string last, int ageNum)
        {
            fName = first;
            lName = last;
            age = ageNum;
        }

        static void Main(string[] args)
        {
            Intro newObj = new Intro("Crypt0", "Ace", 22);
            Console.WriteLine("Hey! My name is " + newObj.fName + newObj.lName + ". I'm " + newObj.age + " years old.");
        }
    }
}

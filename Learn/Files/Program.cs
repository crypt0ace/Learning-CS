using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World!";
            File.WriteAllText("text.txt", text);
            string whatWeWrote = File.ReadAllText("text.txt");
            Console.WriteLine(whatWeWrote);
        }
    }
}

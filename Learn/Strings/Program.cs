using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the length of a string
            string a = "ABCDEFGHIJKLMNOPQRESTUVWXYZ";
            Console.WriteLine("The string length is " + a.Length);

            // Convert case
            string conversion = "Hey there!";
            Console.WriteLine(conversion.ToUpper());
            Console.WriteLine(conversion.ToLower());

            // Concatinating strings
            string firstname = "Crypt0";
            string lastname = "Ace";
            string fullname = firstname + lastname;
            Console.WriteLine("Welcome " + fullname);

            // Can also use this to concatenate strings
            Console.WriteLine(string.Concat(firstname + lastname));

            // String Interpolation
            string name = $"My full name is: {firstname} {lastname}";
            Console.WriteLine(name);

            // Accessing strings
            string text = "Hey! Im Ace. Nice to meet you!";
            Console.WriteLine(text[0]);
            Console.WriteLine(text[13]);

            // Finding index of characters
            Console.WriteLine(text.IndexOf("t"));

            // Substring
            int charpos = text.IndexOf("N");
            string good = text.Substring(charpos);
            Console.WriteLine(good);

            // Special characters
            string test = "This is a \"test\" of special characters";
            Console.WriteLine(test);

            string txt = "It\'s alright.";
            Console.WriteLine(txt);

            string ok = "The character \\ is called backslash.";
            Console.WriteLine(ok);

            // Concatenation and Addition
            string num1 = "10";
            string num2 = "20";
            string concat = num1 + num2;
            Console.WriteLine(concat);

            int num3 = 10;
            int num4 = 20;
            int added = num3 + num4;
            Console.WriteLine(added);
        }
    }
}

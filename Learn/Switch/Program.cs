using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What time is it?");
            string user_time = Console.ReadLine();
            int time_for_user = Convert.ToInt32(user_time);

            switch (time_for_user)
            {
                case 9:
                    Console.WriteLine("Good Morning!");
                    break;
                case 12:
                    Console.WriteLine("Good Evening!");
                    break;
                case 6:
                    Console.WriteLine("Good Night!");
                    break;
                default:
                    Console.WriteLine("Have a good day!");
                    break;
            }
        }
    }
}

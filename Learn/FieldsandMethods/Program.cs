using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsandMethods
{
    class Car
    {
        string color = "Red";
        int speed = 200;

        public void Ticket()
        {
            Car car = new Car();
            Console.WriteLine("This " + car.color + " colored car is going " + car.speed + " miles per hour.");
        }

        static void Main(string[] args)
        {
            Car car = new Car();
            car.Ticket();

            // Accessing other classes
            DemoClass demo = new DemoClass();
            demo.name = "Ace";
            demo.age = 22;
            Console.WriteLine("Hey! My name is " + demo.name + ". I'm " + demo.age + " years old.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class AnimalSounds // base class
    {
        public virtual void Sounds()
        {
            Console.WriteLine("This is what these animals sound like!");
        }
    }

    class Dog : AnimalSounds // derived class
    {
        public override void Sounds()
        {
            Console.WriteLine("Woof Woof");
        }
    }

    class Cat : AnimalSounds // derived class
    {
        public override void Sounds()
        {
            Console.WriteLine("Meow Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AnimalSounds sounds = new AnimalSounds();
            AnimalSounds dog = new Dog();
            AnimalSounds cat = new Cat();
            sounds.Sounds();
            dog.Sounds();
            cat.Sounds();
        }
    }
}

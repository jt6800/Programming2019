using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCreateClasses
{
    class Cat
    {
        string species;
        string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void PrintName()
        {
            Console.WriteLine(this.name);
        }

        public void BeHappy()
        {
            Console.WriteLine("purrrr");
            this.SeeLaser();
            this.MakeSound();
        }
        public void SeeLaser()
        {
            Console.WriteLine("*cat pounces*");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCreateClasses
{
    class Animal
    {
        string species;
        string name;

        public Animal(string species, string name)
        {
            this.species = species;
            this.name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Grrr");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}

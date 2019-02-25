using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCreateClasses
{
    class Garfield
    {
        string species;
        string name;

        public Garfield()
        {
            this.species = "Cat";
            this.name = "Garfield";
        }

        public void MakeSound()
        {
            Console.WriteLine("mmmm, lasagna");
        }

        public void PrintName()
        {
            Console.WriteLine(this.name);
        }

        public void BeHappy()
        {
            this.LayOnLap();
        }

        public void LayOnLap()
        {
            Console.WriteLine("*takes a nap*");
        }

        public void SeeLaser()
        {
            this.BeHappy();
        }
    }
}

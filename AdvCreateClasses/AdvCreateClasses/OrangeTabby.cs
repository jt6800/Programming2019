using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCreateClasses
{
    class OrangeTabby
    {
        string species;
        string name;

        public OrangeTabby(string name)
        {
            species = "cat";
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
            this.LayOnLap();
            Console.WriteLine("*takes a nap*");
        }

        public void LayOnLap()
        {
            Console.WriteLine("*takes a nap*");
        }

        public void SeeLaser()
        {
            Console.WriteLine("*cat punces*");
        }
    }
}

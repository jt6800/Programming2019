using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCreateClasses
{
    class RussianBlue
    {
        string species;
        string name;

        public RussianBlue(string name)
        {
            this.species = "cat";
            this.name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Hisss");
        }

        public void PrintName()
        {
            Console.WriteLine(this.name);
        }

        public void BeHappy()
        {
            Console.WriteLine("purrrr");
            this.SeeLaser();
        }
        public void SeeLaser()
        {
            Console.WriteLine("*cat pounces*");
        }
    }
}

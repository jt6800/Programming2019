using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCreateClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal newAnimal = new Animal("fish", "dory");
            Cat newCat = new Cat("joey");
            Dog newDog = new Dog("gracie", true);
            Garfield newGarfield = new Garfield();
            OrangeTabby newOrangeTabby = new OrangeTabby("bobby");
            RussianBlue newRussianBlue = new RussianBlue("jimmy");
        }
    }
}

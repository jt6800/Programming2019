﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjBegClasses
{
    class Animal
        {
            public string species;
            public string name;
            public string color;
            public int age;

            public Animal(string species, string name, string color)
            {
                this.species = species;
                this.name = name;
                this.color = color;
                age = 0;
            }

            public void MakeSound()
            {
                Console.WriteLine("Grrrrr");
                Console.ReadKey();
            }
            public void SetAge(int newAge)
            {
                this.age = newAge;
            }

            public void printDescription()
            {
                Console.Write(name);
                Console.Write(" is a ");
                Console.Write(age);
                Console.Write(" year old ");
                Console.Write(species);
                Console.ReadKey();
            }
            public Animal newAnimal()
            {
            Console.WriteLine("What kind of animal?");
            string species = Console.ReadLine();
            Console.WriteLine("What is it's name?");
            string name = Console.ReadLine();
            Console.WriteLine("What color is animal?");
            string color = Console.ReadLine();
            Animal Animal1 = new Animal(species, name, color);
        }
        }
}

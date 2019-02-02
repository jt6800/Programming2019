using System;

namespace BegClasses
{
    public class Animal
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
        }


    }
}

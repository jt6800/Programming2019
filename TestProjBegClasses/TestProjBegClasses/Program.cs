using System;
using System.Collections.Generic;

namespace TestProjBegClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalList = new List<Animal>();
            bool notExit = true;
            while (notExit = true) {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("a for add, d for delete, e for edit, i for view animals, x for exit");
                string option = Console.ReadLine();
                if (Console.ReadLine() == "a")
                {
                    animalList.add()

                }
                else if (Console.ReadLine() == "m")
                {
                    Animal1.MakeSound();
                }
                else if (Console.ReadLine() == "p")
                {
                    Animal1.printDescription();
                }
                else if (Console.ReadLine() == "x")
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("s for set age, m for make sound, p for print properties, x for exit");


                if (Console.ReadLine() == "s")
                {
                    Console.WriteLine("How old is the animal?");
                    Animal1.SetAge(Convert.ToInt32(Console.ReadLine()));

                }
                else if (Console.ReadLine() == "m")
                {
                    Animal1.MakeSound();
                }
                else if (Console.ReadLine() == "p")
                {
                    Animal1.printDescription();
                }
                else if (Console.ReadLine() == "x")
                {
                    Environment.Exit(0);
                }


            }
        }
    }
}

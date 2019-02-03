using System;

namespace TestProjBegClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of animal?");
            string species = Console.ReadLine();
            Console.WriteLine("What is it's name?");
            string name = Console.ReadLine();
            Console.WriteLine("What color is animal?");
            string color = Console.ReadLine();
            Animal Animal1 = new Animal(species, name, color);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("s for set age, m for make sound, p for print properties, x for exit");
            bool madeSelection = false;
            while (1 == 1) {
                while (madeSelection == false)
                {


                    if (Console.ReadLine() == "s")
                    {
                        Console.WriteLine("How old is the animal?");
                        Animal1.SetAge(Convert.ToInt32(Console.ReadLine()));
                        madeSelection = true;

                    }
                    else if (Console.ReadLine() == "m")
                    {
                        Animal1.MakeSound();
                        madeSelection = true;
                    }
                    else if (Console.ReadLine() == "p")
                    {
                        Animal1.printDescription();
                        madeSelection = true;
                    }
                    else if (Console.ReadLine() == "x")
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}

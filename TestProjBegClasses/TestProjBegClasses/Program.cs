using System;

namespace TestProjBegClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Console.WriteLine("What would you like to do?");
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

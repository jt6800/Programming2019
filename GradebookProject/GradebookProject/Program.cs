using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradebookProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectionNumber;
            int internalID = 0;
            Console.WriteLine("Welcome to JT's Gradebook v0.1");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            MainMenu();

        }

        static void MainMenu()
        {
            
            //Console.WriteLine("Current Section: " + globalSectionName);
            Console.WriteLine("Please enter the option you want");
            Console.WriteLine("1.) Add Assignment to Section");
            Console.WriteLine("2.) Add Assignment to Student");
            Console.WriteLine("3.) Exit");
            Console.Write("Selection: ");
            int selection = intInput();
            if (selection == 1)
            {
                Console.WriteLine("What is the assignment's name?");
                string assignName = Console.ReadLine();
                Console.WriteLine("What is the number of points possible?");
                doubleInput();
                //Add AddAssignmentToSection function reference here
                Console.WriteLine("Assignment added");
                MainMenu();
            }
            else if (selection == 2)
            {
                Console.WriteLine("What is the student's username?");
                string stuUN = Console.ReadLine();
                Console.WriteLine("What is the assignment's name?");
                string assignName = Console.ReadLine();
                Console.WriteLine("What is the number of points possible?");
                doubleInput();
                //Add AddAssignmentToStudent function reference here
                Console.WriteLine("Assignment added");
                MainMenu();
            }
            else if (selection == 3)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please Try Again");
                Console.Clear();
                MainMenu();
            }
        }
        static int intInput()
        {
            int integer = 0;
            bool intEntered = false;
            while (intEntered == false)
            {
                try
                {
                    integer = Convert.ToInt32(Console.ReadLine());
                    intEntered = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a number, please try again");
                    intEntered = false;
                }
            }
            return integer;
        }
        static double doubleInput()
        {
            double doubleNumber = 0;
            bool doubleEntered = false;
            while (doubleEntered == false)
            {
                try
                {
                    doubleNumber = Convert.ToDouble(Console.ReadLine());
                    doubleEntered = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a number, please try again");
                    doubleEntered = false;
                }
            }
            return doubleNumber;
        }
    }
}

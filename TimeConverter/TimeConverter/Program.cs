using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //12:0:0 AM/PM   12pm =noon 12 am = midnight
            //1:59:59 am/pm  
            //errors in the following
            //letter for anything
            //hours >12 or <1 
            //min/sec >59 or <0
            //something other than am/pm
            // Start Initialization Section
            int Hour=0;
            int Minute=0;
            int Second=0;
            string AM_PM="initialize";
            // End Intitialization Section
            Console.WriteLine("Enter hour for 12 hour time"); //Asks for hour
            try
            {
                Hour = Convert.ToInt16(Console.ReadLine()); //tries to read hour as an int, stores in hour
            }
            catch (FormatException) //Handles non-numeric input
            {
                Console.WriteLine("Invalid Input");
                Console.ReadKey();
                Environment.Exit(0);               
            }
            if(Hour>12 || Hour <0) //handles over 12/under 0 errors
            {
                Console.WriteLine("Invalid Input");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("Enter minute for 12 hour time"); //asks for minute
            try
            {
                Minute = Convert.ToInt16(Console.ReadLine()); //tries to read minute as an int, stores in minute
            }
            catch (FormatException) //Handles non-numeric errors
            {
                Console.WriteLine("Invalid Input");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if(Minute>59 || Minute < 0) //handles under 0/over 59 cases
            {
                Console.WriteLine("Invalid Input");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("Enter second for 12 hour time"); //asks for second
            try
            {
                Second = Convert.ToInt16(Console.ReadLine()); //tries to read second as an int, stores in second
            }
            catch (FormatException) //handles non-numeric input
            {
                Console.WriteLine("Invalid Input");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if(Second>59 || Second <0) //handles over 59/under 0 cases
            {
                Console.WriteLine("Invalid Input");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("Enter AM or PM");
            AM_PM=Console.ReadLine();
            if(AM_PM=="AM") //Checks for "AM"
            {
                if (Hour == 12) //handles 12 AM case
                {
                    Hour = 0;
                }
                Console.Write(Hour);
                Console.Write(":");
                Console.Write(Minute);
                Console.Write(":");
                Console.Write(Second);
                Console.ReadKey();
            }
            else if (AM_PM == "am") //Checks for "am"
            {
                if (Hour == 12) //handles 12 AM case
                {
                    Hour = 0;
                }
                Console.Write(Hour); //Following outputs in h:m:s
                Console.Write(":");
                Console.Write(Minute);
                Console.Write(":");
                Console.Write(Second);
                Console.ReadKey();
            }
            else if (AM_PM == "PM") // Checks for "PM"
            {
                Hour = Hour + 12;
                if(Hour==24)
                {
                    Hour = 0;
                }
                Console.Write(Hour); //Following outputs in h:m:s
                Console.Write(":");
                Console.Write(Minute);
                Console.Write(":");
                Console.Write(Second);
                Console.ReadKey();
            }
            else if (AM_PM == "pm")
            {
                Hour = Hour + 12;
                if (Hour == 24)
                {
                    Hour = 12;
                }

                Console.Write(Hour);
                Console.Write(":");
                Console.Write(Minute);
                Console.Write(":");
                Console.Write(Second);
                Console.ReadKey(); 
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.ReadKey();
            }
        }
    }
}

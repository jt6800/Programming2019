using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exit Code Summary:
             * 0 = Success
             * 1 = input error
             */


            double inConvert = 0;
            double outConvert = 0;
            string Unit = "EMPTY";
            Console.WriteLine("Enter a distance");
            try
            {
                inConvert = Convert.ToDouble(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Exiting with error 1");
                Console.ReadKey();
                Environment.Exit(1);
            }
            Console.WriteLine("meters or feet");
            try
            {
                Unit = Console.ReadLine();

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Exiting with error 1");
                Console.ReadKey();
                Environment.Exit(1);
            }
            if (Unit == "meters" || (Unit == "Meters"))
            {
                outConvert = 3.28 * inConvert;
                Console.Write(outConvert);
                Console.Write(" feet");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (Unit == "feet" || (Unit == "Feet"))
            {
                outConvert = inConvert/3.28;
                Console.Write(outConvert);
                Console.Write(" meters");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if ((Unit != "meters") || Unit != "Meters" != (Unit != "feet") || (Unit != "Feet"))
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Exiting with error 1");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
    }
}

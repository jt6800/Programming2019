using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double total = 0;
            Console.WriteLine("enter a number");
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());

            }
            catch (System.FormatException a)
            {
                Console.WriteLine("Input 1 was not a number");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
            Console.WriteLine("enter a number");
            try
            {
                num2 = Convert.ToDouble(Console.ReadLine());

            }
            catch (System.FormatException a)
            {
                Console.WriteLine("Input 2 was not a number");

            }
            Console.WriteLine("enter a number");

            try
            {
                num3 = Convert.ToDouble(Console.ReadLine());

            }
            catch (System.FormatException a)
            {
                Console.WriteLine("Input 3 was not a number");
            }
            Console.WriteLine("enter a number");
            try
            {
                num4 = Convert.ToDouble(Console.ReadLine());

            }
            catch (System.FormatException a)
            {
                Console.WriteLine("Input 4 was not a number");
            }
            total = num1 + num2 + num3 + num4;
            Console.WriteLine("Total is: " + total);
        }
    }
}
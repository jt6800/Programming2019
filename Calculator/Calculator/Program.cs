using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Number1s;
            string Number2s;
            double Number1;
            double Number2;
            double answer;
            string OperatorString;
            Console.WriteLine("Welcome to JT's Calculator");
            Console.WriteLine("Enter number, followed by operator, followed by second number, enter @ at operator to cancel");


            {
                Console.WriteLine("Enter number:");
                Number1s = Console.ReadLine();
                Console.WriteLine("Enter number:");
                Number2s = Console.ReadLine();
                Console.WriteLine("Enter operator:");
                OperatorString = Console.ReadLine();
                Number1 = Convert.ToDouble(Number1s);
                Number2 = Convert.ToDouble(Number2s);
                if ( OperatorString == "@" )
                {
                    Console.WriteLine("Press enter to exit");
                    Console.ReadKey();
                }

               
                
                else if (OperatorString == "+")
                {
                    answer = Number1 + Number2;
                    Console.WriteLine(answer);
                    Console.ReadKey();
                }

                else if (OperatorString == "-")
                {
                    answer = Number1 - Number2;
                    Console.WriteLine(answer);
                    Console.ReadKey();
                }

                else if (OperatorString == "*")
                {
                    answer = Number1 * Number2;
                    Console.WriteLine(answer);
                    Console.ReadKey();
                }

                else if (OperatorString == "/")
                {
                    answer = Number1 / Number2;
                    Console.WriteLine(answer);
                    Console.ReadKey();
                }
            }
        }
    }
}

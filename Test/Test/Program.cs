using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbers = 0;
            double total = 0;
            double numberIncrement = 0;
            double average = 0;
            Console.WriteLine("How many numbers to average?");
            numbers = Convert.ToDouble(Console.ReadLine());
            while (numberIncrement < numbers)
            {
                Console.Write("Enter the number for the ");
                Console.Write(numberIncrement);
                Console.WriteLine(" position");
                total = Convert.ToDouble(Console.ReadLine())+ total;
                numberIncrement++;

            }
            average = total / numbers;
            Console.WriteLine(average);
            Console.ReadKey();

        }
    }
}

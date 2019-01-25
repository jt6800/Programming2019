using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string GradeString;
            int Grade;
            Console.WriteLine("Enter a score:");
            GradeString = Console.ReadLine();
            Grade = Convert.ToInt32(GradeString);
            Console.Write("Your grade: ");
            if ((Grade >= 93))
            {
                Console.Write("A");
                Console.WriteLine();
            }
            if ((Grade >= 90) && ((Grade <= 92)))
            {
                Console.Write("A-");
                Console.WriteLine();

            }
            if ((Grade >= 87) && ((Grade <= 89)))
            {
                Console.Write("B+");
                Console.WriteLine();

            }
            if ((Grade >= 83) && ((Grade <= 86)))
            {
                Console.Write("B");
                Console.WriteLine();

            }
            if ((Grade >= 80) && ((Grade <= 82)))
            {
                Console.Write("B-");
                Console.WriteLine();

            }
            if ((Grade >= 77) && ((Grade <= 79)))
            {
                Console.Write("C+");
                Console.WriteLine();
            }
            if ((Grade >= 73) && ((Grade <= 78)))
            {
                Console.Write("C");
                Console.WriteLine();
            }
            if ((Grade >= 70) && ((Grade <= 72)))
            {
                Console.Write("C-");
                Console.WriteLine();
            }
            if ((Grade >= 67) && ((Grade <= 69)))
            {
                Console.Write("D+");
                Console.WriteLine();
            }
            if ((Grade >= 63) && ((Grade <= 66)))
            {
                Console.Write("D");
                Console.WriteLine();
            }
            if ((Grade >= 60) && (Grade <= 62))
            {
                Console.Write("D-");
                Console.WriteLine();
            }
            if ((Grade <= 60))
            {
                Console.Write("E");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberIndex = 0;
            int testingIndex = 0;
            int iterationIndex = 0;
            while (numberIndex < 10)
            {
                Console.WriteLine(numberIndex);
                numberIndex++;
            }
            while (testingIndex < 500)
            {
                Console.WriteLine("Testing Loops");
                testingIndex++;
            }
            while (iterationIndex < 100)
            {
                Console.Write("current loop iteration: ");
                Console.Write(iterationIndex);
                iterationIndex++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of sequence
            int digit1 = 1;
            int digit2 = 1;
            int digit3 = 7;
            //declaration of test digits
            int testDigit1 = 0;
            int testDigit2 = 0;
            int testDigit3 = 0;
            // sets truth statements
            bool hasFound1 = false;
            bool hasFound2 = false;
            bool hasfound3 = false;

            
            while (hasFound1 == false)
            {
                Console.WriteLine("Enter a number");
                testDigit1 = Convert.ToInt32(Console.ReadLine());
                if (digit1==testDigit1)
                {
                    hasFound1 = true;
                }
            }

            while (hasFound2 == false)
            {
                Console.WriteLine("Enter a number");
                testDigit2 = Convert.ToInt32(Console.ReadLine());
                if (digit2==testDigit2)
                {
                    hasFound2 = true;
                }
            }

            while (hasfound3 == false)
            {
                Console.WriteLine("Enter a number");
                testDigit3 = Convert.ToInt32(Console.ReadLine());
                if (digit3 == testDigit3)
                {
                    hasfound3 = true;
                }
            }

            if (hasFound1 == true && hasFound2 == true && hasfound3 == true)
            {
                Console.WriteLine("Congratulations!");
                
            }

            Console.ReadKey();

        }
    }
}

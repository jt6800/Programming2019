using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int i = 0;
            int ctr = 0;
            int stno = 0;
            int enno = 0;
            int safety = 0;

            Console.WriteLine("Find the prime numbers within a range of numbers:");
            Console.Write("Input starting number of range: ");
            try
            {
                stno = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Input Error");
                Console.ReadKey();
                Environment.Exit(1);
            }
            
            Console.Write("Input ending number of range : ");
            try
            {
                enno = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Input Error");
                Console.ReadKey();
                Environment.Exit(1);
            }
            
            Console.Write("The prime numbers between ");
            Console.Write(stno);
            Console.Write(" and ");
            Console.Write(enno);
            Console.Write(" are : ");
            Console.WriteLine();
            if (stno<0)
            {
                stno = 1;
            }
            if (enno<stno)
            {
                safety = enno;
                enno = stno;
                stno = safety;
            }
            if (stno==enno)
            {
                Console.Write(stno);
                Console.ReadKey();
                Environment.Exit(0);
            }
            for (num = stno; num <= enno; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                    }
                }

                if (ctr == 0 && num != 1)
                {
                    Console.Write(num);
                    Console.Write(" ");
                    Console.WriteLine();
                }
                    

            }
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}

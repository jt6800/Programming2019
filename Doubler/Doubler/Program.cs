using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubler
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = Convert.ToDouble(Console.ReadLine());
            double doubled = number * 2;
            Console.WriteLine(doubled);
            Console.ReadKey();

        }
    }
}

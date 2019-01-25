using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvAverage3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string Number1s = Console.ReadLine();
            Console.WriteLine("Enter a number:");
            string Number2s = Console.ReadLine();
            Console.WriteLine("Enter a number:");
            string Number3s = Console.ReadLine();
            double Number1d = Convert.ToDouble(Number1s);
            double Number2d = Convert.ToDouble(Number2s);
            double Number3d = Convert.ToDouble(Number3s);
            double SumNum1_3 = Number1d + Number2d + Number3d;
            double Average = SumNum1_3 / 3;
            Console.Write("The Average is: ");
            Console.Write(Average);
            Console.ReadKey();
        }
    }
}

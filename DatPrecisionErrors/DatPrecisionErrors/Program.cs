using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPrecisionErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            double Var1 = 1 - 3 * (4 / 3.0 - 1);
            double Var2 = (12 / 11.0 - 1) * 11;
            double Var3 = .1 + .1 + .1 + .1 + .1 + .1 + .1 + .1 + .1 + .1 - 1;
            Console.WriteLine(Var1);
            Console.WriteLine(Var2);
            Console.WriteLine(Var3);
            Console.ReadKey();

        }
    }
}

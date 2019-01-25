using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvVariablePrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int var5;
            int var1;
            int var2;
            var1 = 5;
            var2 = 6;
            var5 = var1 * var2;
            Console.Out.WriteLine(var5);
            var1 = var1 + 1;
            Console.Out.WriteLine(var1);
            var1 = 7;
            var2 = var1 - var2;
            Console.Out.WriteLine(var2);
            var1 = 12;
            var1 = var1 + 7;
            Console.Out.WriteLine(var1);
            var5 = (var1 * var2) - var1;
            Console.Out.WriteLine(var5);
            int var3 = 8;
            var5 = var3 + var1 + var2;
            Console.Out.WriteLine(var5);
            var5 = var5 / var3;
            Console.Out.WriteLine(var5);
            int var4 = 9;
            var3 = var4 - var3;
            Console.Out.WriteLine(var3);
            var5 = var3 * var5;
            Console.Out.WriteLine(var5);
            var5 = var5 + var5;
            var5 = var5 / 3;
            Console.Out.WriteLine(var5);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntVariablePrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string stringVar1 = "Why does Waldo wear a striped shirt? ";
            int myInt = 10;
            string stringVar2 = "Because he does not want to be spotted.";
            Console.WriteLine("the number you entered is: " + myInt);
            Console.Write("the number you entered is: ");
            Console.WriteLine(myInt);
            Console.WriteLine(stringVar1 + stringVar2);
            Console.WriteLine(stringVar1);
            Console.WriteLine(stringVar2);
            Console.Write(stringVar1);
            Console.Write(stringVar2);

            Console.ReadKey();

            

        }
    }
}

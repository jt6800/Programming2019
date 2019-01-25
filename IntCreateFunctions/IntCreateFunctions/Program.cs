using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntCreateFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPrintFunction();
            BobPrinter();
            Add(3, 17);
            Sub(4, 16);
            Add1(2);
        }
        static void MyPrintFunction()
        {
            Console.WriteLine("In MyPrintFunction");
        }
        static void BobPrinter()
        {
            Console.WriteLine("bob bob bob bob bob");
        }
        static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        static int Sub(int num1, int num2)
        {
            int difference = num1 - num2;
            return difference;
        }
        static int Add1(int number)
        {
            number = number + 1;
            return number;
        }

    }
}

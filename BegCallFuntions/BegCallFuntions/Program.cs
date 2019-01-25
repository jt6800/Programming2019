using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegCallFuntions
{
    class Program
    {
        static void Main(string[] args)
        {
            //call MyFunction1
            //call Function2
            //call Function3
            //call ExampleFunction4
            //call TestFunction5
            //call Function2 again
            //call Function2 again
            //call ExampleFunction4 again
            //call Function2 again
            //call TestFunction5 again
            MyFunction1();
            Function2();
            Function3();
            ExampleFunction4();
            TestFunction5();
            Function2();
            Function2();
            ExampleFunction4();
            Function2();
            TestFunction5();
        }
        static void MyFunction1() {
            Console.WriteLine("Printing stuff");
            Console.WriteLine("Here is more stuff to print");
        }
        static void Function2() {
            Console.WriteLine("Hello");
            Console.WriteLine("World");
        }
        static void Function3() {
            Console.WriteLine("This is fun");
            Console.WriteLine("No it is not");
        }
        static void ExampleFunction4() {
            Console.WriteLine("Why did the Scarecrow get a promotion?");
            Console.WriteLine("because he was out standing in his field!");
        }
        static void TestFunction5() {
            Console.WriteLine("Why do chicken coops only have two doors?");
            Console.WriteLine("Because if they had four, they would be chicken sedans!");
        }
    }
}

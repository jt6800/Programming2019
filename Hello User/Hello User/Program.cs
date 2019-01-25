using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_User
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName;
            string Greeting = "Hello ";
            string 
            Console.WriteLine("Hello, what is your name?");
            UserName = Console.ReadLine();
            Console.Write(Greeting + UserName + "!");
            System.Threading.Thread.Sleep(2000);

            Console.ReadKey();

        }
    }
}

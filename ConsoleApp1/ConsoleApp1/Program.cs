using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
            string userName = "<Jonathan>";
            string date = DateTime.Today.ToShortDateString();

            // Use string interpolation to concatenate strings.
            string str = $"Hello {userName}. Today is {date}.";
            System.Console.WriteLine(str);
            Console.ReadLine();

        }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
	class Program
	{
		static void Main(string[] args)
		{
			short over;
			over = 1;
			for (over = 1; over != over + 1; over++)
			{
				Console.WriteLine(over);
			}

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
	class Program
	{
		static void Main(string[] args)
		{
			//This declares and assigns these variables
			//all in one step.
			short levelNumber = 3;
			int score = 0;

			//This declares a variable and assigns it a later point in time
			long aBigNumber;
			aBigNumber = -17;

			//Here is a byte
			byte aSingleByte = 55;

			//Here's Unsigned stuff
			ushort thisHoldsPositivesOnly = 45;
			Console.ReadKey();
		}
	}
}

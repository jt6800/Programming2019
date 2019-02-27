using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intgerList = new List<int>();
            List<int> listOfIntegers = new List<int>();
            List<int> testScores = new List<int>();
            List<double> dblList = new List<double>();
            List<double> listOfDoubles = new List<double>();
            List<double> playerPoints = new List<double>();
            List<string> stringList = new List<string>();
            List<string> listOfStrings = new List<string>();
            List<string> studentName = new List<string>();
            List<int> intList = new List<int>();
            List<double> doubleList = new List<double>();
            intList.Add(12);
            intList.Add(7);
            intList.Add(5);
            intList.Add(3);
            int intElement = intList[0];
            Console.WriteLine(intElement);
            intElement = intList[1];
            Console.WriteLine(intElement);
            intElement = intList[2];
            Console.WriteLine(intElement);
            intElement = intList[3];
            Console.WriteLine(intElement);
            dblList.Add(12.1);
            dblList.Add(5.2);
            dblList.Add(7.3);
            double doubleElement = dblList[0];
            Console.WriteLine(doubleElement);
            doubleElement = dblList[1];
            Console.WriteLine(doubleElement);
            doubleElement = dblList[2];
            Console.WriteLine(doubleElement);
            doubleElement = dblList[3];
            Console.WriteLine(doubleElement);

        }
    }
}

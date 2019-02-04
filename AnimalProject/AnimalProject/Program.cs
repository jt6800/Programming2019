using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void menu()
        {

        }
        
        static dynamic getInput(string inputType)
        {
            dynamic variable;
            if (inputType == "string")
            {
                variable = Console.ReadLine();
                return variable;
            }
            else if (inputType == "int")
            {
                variable = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

}

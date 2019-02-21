using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGradebookProject
{
    class Program
    {
        List<Section> sections = new List<Section>();
        static void Main(string[] args)
        {
            List<Section> sections = new List<Section>();

        }

        int sectionID = 0;
        bool addSection()
        {
            if (sectionID<=6)
            {
                Console.WriteLine("Plese enter the name of the section");
                string sectionName = Console.ReadLine();
                sections.Add(sectionID);

            }
        }
    }
}

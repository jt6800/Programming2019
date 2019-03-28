using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Section
    {
        string sectionName;
        //probably more properties need to be implemented, or at least would make life simpler
        public Section(string sectionName)
        {
            this.sectionName = sectionName;
            List<Student> students = new List<Student>();
            List<Assignment> assignments = new List<Assignment>();
        }    
    }
}

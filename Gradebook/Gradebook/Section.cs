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

        public Section(string sectionName)
        {
            this.sectionName = sectionName;
            List<Student> students = new List<Student>();
            List<Assignment> assignments = new List<Assignment>();
        }    
    }
}

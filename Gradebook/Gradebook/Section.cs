using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Section
    {
        private string sectionName;
        //probably more properties need to be implemented, or at least would make life simpler
        private List<Student> students;

        public Section(string sectionName)
        {
            this.sectionName = sectionName;
            this.students = students;
        }

        public string getSectionName()
        {
            return sectionName;
        }
    }
}

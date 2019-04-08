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

        public bool addStudent(string firstName, string lastName, string username, long phoneNumber)
        {
            //create new student if username doesn't exit and add to studentList
            //returns false of username exists
            //returns true otherwise

            //checks if username exists
            //if exists return false
            //otherwise create student, add to list, return true

            
            int index = getStudentIndexByUsername(username);
            if (index != -1)
            {
                 return false;
            }
            students.Add(new Student(firstName, lastName, username, phoneNumber);
            return true;
        }

        
        private int getStudentIndexByUsername(string username)
        {
            int index = 0; // |  |  |  |
            while (index < students.Count)
            {
                if (username.Equals(students[index].getUsername()))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public int getStudentCountBySection()
        {
            return students.Count;
        }
    }
}

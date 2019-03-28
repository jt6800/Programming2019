using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Student
    {
        string firstName = null;
        string lastName = null;
        long studentID = 0;
        long phoneNumber = 0;
        int absentcount = 0;
        int tardyCount = 0;
        double gradePercent = 0;
        //need to add more properties, read through Gradebook API for more

        public Student(string firstName, string lastName, long studentID, long phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentID = studentID;
            this.phoneNumber = phoneNumber;
            List<Assignment> studentAssignments = new List<Assignment>();
        }
    }
}

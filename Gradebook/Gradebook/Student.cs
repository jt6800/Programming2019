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
        string username = null;
        long phoneNumber = 0;
        int absentcount = 0;
        int tardyCount = 0;
        double gradePercent = 0;
        //need to add more properties, read through Gradebook API for more
        private List<Assignment> assignments;
        public Student(string firstName, string lastName, string username, long phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.phoneNumber = phoneNumber;
            List<Assignment> studentAssignments = new List<Assignment>();
        }

        public string getUsername(int index)
        {
            return username;
        }

    }
}

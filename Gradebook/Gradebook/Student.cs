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
        int absentCount = 0;
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

        public string getUsername()
        {
            return username;
        }

        public bool markTardy()
        {
            tardyCount++;
            return true;
        }

        public bool markAbsent()
        {
            absentCount++;
            return true;
        }

        public bool addAssignment(string assignmentName, int pointsPossible)
        {
            assignments.Add(new Assignment(assignmentName, pointsPossible));
            return true;
        }

        public int returnAbsentCount()
        {
            return absentCount;
        }
        public int returnTardyCount()
        {
            return tardyCount;
        }

        public bool setScore(string assignmentName, int pointsEarned)
        {
            for (int i = 0; i < assignments.Count; i++)
            {
                if (assignments[i].getAssignmentName()==assignmentName)
                {
                    assignments[i].setScore(pointsEarned);
                    return true;
                }
            }
            return false;
        }

        public double returnScore(string assignmentName)
        {
            for (int i = 0; i < assignments.Count; i++)
            {
                if (assignments[i].getAssignmentName() == assignmentName)
                {
                    double score = assignments[i].returnScore();
                    return score;
                }
                
            }
            return 0;
        }

        public double getOverallScore()
        {
            double runningTotalObtained = 0;
            double runningTotalPossible = 0;
            for (int i = 0; i < assignments.Count; i++)
            {
                runningTotalObtained = runningTotalObtained + assignments[i].returnObtained();
                runningTotalPossible = runningTotalPossible + assignments[i].returnPossible();
            }
            return runningTotalObtained/runningTotalPossible;
        }

        public bool checkDuplicateAssignment(string assignmentName)
        {
            for (int i = 0; i < assignments.Count(); i++)
            {
                if (assignmentName == assignments[i].getAssignmentName())
                {
                    return true;
                }
            }
            return false;
        }
    }
}

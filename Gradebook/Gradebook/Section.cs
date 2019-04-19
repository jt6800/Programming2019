﻿using System;
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
            students.Add(new Student(firstName, lastName, username, phoneNumber));
            return true;
        }        
        public int getStudentIndexByUsername(string username)
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
        public bool markTardy(string username)
        {

            int index = getStudentIndexByUsername(username);
            if (index == -1)
            {
                return false;
            }
            students[index].markTardy();
            return true;
        }
        public bool markAbsent(string username)
        {

            int index = getStudentIndexByUsername(username);
            if (index == -1)
            {
                return false;
            }
            students[index].markAbsent();
            return true;
        }
        public bool addAssignment(string username, string assignmentName, int pointsPossible)
        {
            
            int index = getStudentIndexByUsername(username);
            if (index == -1)
            {
                return false;
            }
            if (students[index].checkDuplicateAssignment(assignmentName) == false)
            {
                return false;
            } 
            students[index].addAssignment(assignmentName, pointsPossible);
            return true;
        }

        public bool addAssignmentToSection(string assignmentName, int pointsPossible)
        {
            for (int i = 0; i < students.Count(); i++)
            {
                if (students[i].checkDuplicateAssignment(assignmentName) == false)
                {
                    students[i].addAssignment(assignmentName, pointsPossible);
                }               
            }
            return true;
        }
        public int returnAbsentCount(string username)
        {
            int index = getStudentIndexByUsername(username);
            if (index == -1)
            {
                return 0;
            }
            return students[index].returnAbsentCount();
        }
        public int returnTardyCount(string username)
        {
            int index = getStudentIndexByUsername(username);
            if (index == -1)
            {
                return 0;
            }
            return students[index].returnTardyCount();
        }
        public bool setScore(string username, string assignmentName, int pointsEarned)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].getUsername() == username)
                {
                    students[i].setScore(assignmentName, pointsEarned);
                    return true;
                }
            }
            return false;
        }
        public double returnScore(string username, string assignmentName)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].getUsername() == username)
                {
                    double score = students[i].returnScore(assignmentName);
                    return score;
                }
            }
            return 0;
        }
        public double returnScoreSection(string assignmentName)
        {
            double runningTotal = 0;
            double divisor = students.Count();
            double scoreSection = 0;
            for (int i = 0; i < students.Count; i++)
            {
                runningTotal = runningTotal + (students[i].returnScore(assignmentName));
            }
            scoreSection = runningTotal / divisor;
            return scoreSection;
        }

        public double getOverallScore(string username)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].getUsername() == username)
                {
                    double scoreAvg = students[i].getOverallScore();
                    return scoreAvg;
                }
            }
            return -1;
        }

        public double getOverallScoreAvg()
        {
            double runningTotalAverages = 0;
            double divisor = students.Count();
            if (students.Count() != 0)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    runningTotalAverages = runningTotalAverages + students[i].getOverallScore();
                }
                double overallScoreAvg = runningTotalAverages / divisor;
                return overallScoreAvg;
            }
            return -1;            
        }
    }
}

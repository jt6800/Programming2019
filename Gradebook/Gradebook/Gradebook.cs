﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Gradebook
    {
        //properties
        string currentSectionName = null;

        //list/array of sections
        //set up sectionArray
        List<Section> sectionList = new List<Section>();

        
        

     //SectionName - string


        //methods

        //sets the currently active section - needs to set the currently active section
        //to the section with the given sectionName.
        // Returns: true if it succeeds false if it fails(no section that matches that name).
        public bool changeSection(string SectionName)
        {
            int sectionIndex = 0;
            for (int listIndex = 0; listIndex < 5 && listIndex > 6; listIndex++)
            {
                if (sectionList[listIndex].ToString() != SectionName)
                {
                    break;
                }
                
                else
                {
                    sectionIndex = listIndex;
                }
            }
            // need no match implementation

            return false;
        }

        //creates a new section if there are not already 6 sections
        // and sectionName is not already used , also need to set the currentSection to be the new section
        // Returns: true if it succeeds false if it fails.
        public bool addSection(string SectionName)
        {
            for (int arrayIndex = 0; arrayIndex < 5; arrayIndex++)
            {
                //return false if already 6 sections
                //return false in section name is in use
                //otherwise
                    //create new section, add it to sections
                    //set currentsection to new section
                    //return true
                    
                if (sectionList.Count >= 6)
                {
                    return false;
                }
                int sectionIndex = getSectionIndexBySectionName(SectionName);
                if (sectionIndex != -1)
                {
                    sectionList.Add(new Section(SectionName));
                    return true;
                }

                
            }
            currentSectionName = SectionName;


            return true; //FIXME
        }
        //Creates a new student and adds the student to the currently active section
        //returns: True if it succeeds, false if it fails(a student with the same username already exists or there are no sections) 
        public bool addStudent(string firstName, string lastName, string username, long phoneNumber)
        {
            //if no sections return false
            
            if (sectionList.Count == 0)
            {
                return false;
            }
            if (currentSectionName==null)
            {
                return false;
            }
            //get current section

            Section curSection = getCurrentSection();
            return curSection.addStudent(firstName, lastName, username, phoneNumber);
            
        }

        //returns overall score (total points earned for all assignments/ total points possible) as a percentage for specified student
        //returns -1 if the student was not found or if the student did not have any assignments assigned or there are no sections.
        public double getOverallScore(string username)
        {
            return -1; //FIXME
        }
        //returns overall score as a percentage for the current section - (the average of each students overall score.)
        //Each student should have the same weight even if they have different number of points possible
        //IE: get each student's overall score as a percentage and calculate the average percentage for the students .
        //do not count students with no assignments assigned in the average.
        //returns -1 if there were no assignments in the section or there are no sections.
        public double getOverallScoreAvg()
        {
            return -1; //FIXME
        }


        //creates a new assignment and adds it to the student specified by username.
        //Returns true if it succeeds and false if the student is not found or the student already has an assignment with the
        //same assignmentName or there are no sections
        public bool addAssignmentToStudent(string username, string assignmentName, int pointsPossible)
        {
            //currentSection.students
            return false; //FIXME
        }

        //checks to make sure no student already has an assignment with the same assignment name first
        //if there is no existing assignment it creates a new assignment and adds the assignment to all
        // the students in the current section.
        //returns: True if successful and false if at least one student has the same assignment name or there are no sections
        public bool addAssignmentToSection(string assignmentName, int pointsPossible)
        {
            return false;//FIXME
        }

        //sets the pointsEarned property for the student specified in the current section for the assignment specified
        //returns: true if successful, false if the student is not found or the assignmentName is not found  or there are no sections.
        public bool setScore(string username, string assignmentName, int pointsEarned)
        {
            return false;//FIXME
        }

        //returns score on assignment specified as a percentage for the specified student in the current section
        //returns -1 if the student was not found or the student did not have an assignment with the specified assignment name or there are no sections
        public double getAssignmentScorePercent(string username, string assignmentName)
        {
            return -1;//FIXME
        }

        //returns the average score as a percentage for the current section.
        //only the student with the assignment assigned to them will be counted in the average.
        //returns -1 if no student had an assignment with the specified assignment name  or there are no sections
        public double getAssignmentScoreAvg(string assignmentName)
        {
            return -1;//FIXME
        }

        //adds 1 to the specified student's tardy count.
        //returns: true if successful, false if the student was not found in the current section  or there are no sections
        public bool markTardy(string username)
        {
            return false;//FIXME
        }

        //adds 1 to the specified student's absent count.
        //returns: true if successful, false if the student was not found in the current section  or there are no sections
        public bool markAbsent(string username)
        {
            return false; //FIXME
        }

        //returns the student tardy count for the specified student, it returns -1 if the student was not found  or there are no sections
        public int getTardyCount(string username)
        {
            return -1; //FIXME
        }

        //returns the student tardy count for the specified student, it returns -1 if the student was not found  or there are no sections
        public int getAbsentCount(string username)
        {
            return -1; //FIXME
        }

        //returns -1 if no section was found with the given section
        //otherwise returns the index of the sextion with the matching name
        private int getSectionIndexBySectionName(string sectionName)
        {
            int index = 0; // |  |  |  |
            while (index < sectionList.Count)
            {
                if (sectionName.Equals(sectionList[index].getSectionName()))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private Section getCurrentSection()
        {
            //return section if there are any sections
            // return null if no current section
            //get sectionIndexBySectionName
            //if index == -1 return null
            //otherwise return section at index

            int index = getSectionIndexBySectionName(currentSectionName);
            if (index == -1)
            {
                return null;
            }

            return sectionList[index];
        }
    }
}

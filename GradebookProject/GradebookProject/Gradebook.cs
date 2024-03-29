﻿using System;
using System.Collections.Generic;

namespace GradebookProject
{
    class Gradebook
    {
        // properties
        int sectionNumber;
        int internalID = 0; //sets student internal id to 0
        List<Section> sections = new List<Section>(); //list of sections
                                                      //list of students w/in section
                                                      //array of data
                                                      //list of assignments for redundancy

        //methods from methodsneedtoimplement.txt
        changeSection(string sectionName)
        {
            globalSectionName = sectionName;
        }

        double getOverallScore(String username)
        {
            return ((this.pointsEarned) / (this.pointsPossible));
        }

        double getOverallScoreAvg(string sectionName)
        {
            return ((this.sectionPointsEarned) / (this.sectionPointsPossible));
        }

        bool AddStudent(String firstName, String lastName, string username, long phoneNumber)
        {

        }

        bool addSection()
        {
            Console.WriteLine("Please enter the name of the section");
            string internalSectionName = Console.ReadLine();
            Section.addSection(internalSectionName);
        }

        double getOverallScore(String username); //returns overall score as a percentage for specified student

        double getOverallScoreAvg(String sectionName); //returns overall score as a percentage for a section

        boolean addAssignmentToStudent(String username, String assignmentName, int pointsPossible);

        boolean addAssignmentToSection(String assignmentName, int pointsPossible);

        boolean setScore(String username, String assignmentName, int pointsEarned);

        double getAssignmentScorePercent(String username, String assignmentName); //returns score as a percentage for student in current section

        double getAssignmentScoreAvg(String assignmentName); //returns score as a percentage for current section



        boolean markTardy(String username); //adds 1 to the students tardy count

        boolean markAbsent(String username); //adds 1 to the students absent count

        int getTardyCount(String username);  //returns number of times student was tardy

        int getAbsentCount(String username); //returns number of times student was absent

        
    }
}

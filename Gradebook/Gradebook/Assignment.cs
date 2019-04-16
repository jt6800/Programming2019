using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Assignment
    {
        private string assignmentName;
        private double pointsPossible;
        private double pointsObtained;
        //likely more properties need to be defined

        public Assignment(string assignmentName, double pointsPossible)
        {
            this.assignmentName = assignmentName;
            this.pointsPossible = pointsPossible;
        }
        public string getAssignmentName()
        {
            return assignmentName;
        }
        public bool setScore(int pointsEarned)
        {
            pointsObtained = pointsEarned;
            return true;
        }
        public double returnScore()
        {
            double score = (pointsObtained / pointsPossible)*100;
            return score;
        }

        public double returnPossible()
        {
            return pointsPossible;
        }

        public double returnObtained()
        {
            return pointsObtained;
        }

        
    }
}
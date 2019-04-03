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

        public Assignment(string assignmentName, double pointsPossible, double pointsObtained)
        {
            this.assignmentName = assignmentName;
            this.pointsPossible = pointsPossible;
            this.pointsObtained = pointsObtained;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Students
    {
        string FirstName = null;
        string LastName = null;
        long studentID = 0;
        long phoneNUmber = 0;
        unsafe
	    {

	
            static Students StudentConstructor()

            {
            Students student1 = new Students();
            return student1;
        
            }
        }
    }
}

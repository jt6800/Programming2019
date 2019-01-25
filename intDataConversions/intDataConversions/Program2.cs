using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intDataConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //copy the following code to a new project and//fix the errors in the conversions below
            //also answer each of the questions in comments.
            String myString = "1";//"1"
            float myFloat = 10.7f;
            double myDouble = 10.9123457890;
            bool myBool = true;
            long myLong = 123123;
            int myInt = 12;
            myDouble = myFloat;
            myDouble = myInt;
            myDouble = myLong;
            myDouble = Convert.ToDouble(myString);
            //How come only the string needs to be converted.
            //Because only the string doesn't fit in the float type
            myString = "1";//"1"
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;
            myFloat = (float)myDouble;
            myFloat = myInt;
            myFloat = myLong;
            myFloat = float.Parse(myString);
            //why does the double need to be cast/converted to a float but it did not need to be done in the opposite direction
            //all float fit in a double, but the opposite is not always true
            myString = "1";//"1"
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;
            myInt = (int)myDouble;
            myInt = (int)myFloat;
            myInt = (int)myLong;
            myInt = int.Parse(myString);
            //what is the value of myInt after the conversion from myDouble?  why is it not the same value of myFloat
            //because an int cannot hold a decimal
            myString = "1";//"1"
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;myLong = 123123;
            myInt = 12;
            myLong = (long)myDouble;
            myLong = (long)myFloat;
            myLong = (long)myInt;
            myLong = long.Parse(myString);
            myString = "1";//"1"
            myFloat = 10.7f;
            myDouble = 10.9123457890;
            myBool = true;
            myLong = 123123;
            myInt = 12;
            myString = Convert.ToString(myDouble);
            myString = Convert.ToString(myFloat);
            myString = Convert.ToString(myInt);
            myString = Convert.ToString(myLong);

        }
    }
}

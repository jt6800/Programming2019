using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntObjects
{
    class Student
    {
        static int studentID;
        static string name;
        static double contentGrade;
        static double workHabitGrade;
        static double participation;
        static int age;

        public Student(string Name, int id, int stuage)
        {
            name = Name;
            studentID = id;
            age = stuage;
            contentGrade = 0;
            workHabitGrade = 0;
            participation = 0;
        }
        public Student()
        {
            name = "TestStudent";
            studentID = 1;
            contentGrade = 0;
            workHabitGrade = 0;
            participation = 0;
            age = 18;
        }

        static void SetContentGrade(double grade)
        {
            contentGrade = grade;
        }

        static void SetWorkHabitGrade(double grade)
        {
            workHabitGrade = grade;
        }

        static void SetParticipation(double grade)
        {
            participation = grade;
        }


        static double GetGrade()
        {
            return (.35 * workHabitGrade) + (.4 * contentGrade) + (.25 * participation);
        }
        static void PrintGrade()
        {
            Console.WriteLine((.35 * workHabitGrade) + (.4 * contentGrade) + (.25 * participation));
            Console.ReadKey();
        }
    }
}

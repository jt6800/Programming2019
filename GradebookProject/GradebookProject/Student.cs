namespace GradebookProject
{
    class Student
    {
        string firstName;
        string lastName;
        string username;
        string phoneNumber;
        int internalID;

        bool InternalAddStudent(string firstName, string lastName, string username, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.phoneNumber = phoneNumber;
            return true;
        }

        bool addAssignmentToStudent(string username, string assignmentName, int pointsPossible)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Assignement_1
{
    class Student
    {
        string firstName;
        string lastName;
        string studentNumber;
        float averageScore;

        public Student(string firstName, string lastName, string studentNumber, float averageScore)
        {
            if (firstName != null && lastName != null)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }
            else
            {
                Console.WriteLine("You have to write a correct first and last name");
            }
            this.studentNumber = studentNumber;
            this.averageScore = averageScore;
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }

        public float AverageScore
        {
            get { return averageScore; }
            set { averageScore = value; }
        }

        public string ToString()
        {
            return "The student " + firstName+ " "+ lastName + " has an average score of " + averageScore + " and the student number of the student is " + StudentNumber;
        }

    }
}

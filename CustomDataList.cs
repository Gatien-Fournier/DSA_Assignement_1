using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Assignement_1
{
    class CustomDataList
    {
        LinkedList<Student> studentsList;

        public CustomDataList (LinkedList<Student> studentsList)
        {
            this.studentsList = studentsList;
        }

        public LinkedList<Student> StudentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }

        public void PopulateWithSampleData()
        {
            string firstNameA = "Kylian";
            string lastNameA = "Mbappe";
            string studentNumberA = "FR7";
            float averageScoreA = 90 ;
            Student studentA = new Student(firstNameA, lastNameA, studentNumberA, averageScoreA);
            studentsList.AddFirst(studentA);

            string firstNameB = "Olivier";
            string lastNameB = "Giroud";
            string studentNumberB = "FR9";
            float averageScoreB = 79 ;
            Student studentB = new Student(firstNameB, lastNameB, studentNumberB, averageScoreB);
            studentsList.AddFirst(studentB);

            string firstNameC = "Zinedine";
            string lastNameC = "Zidane";
            string studentNumberC = "FR10";
            float averageScoreC = 94 ;
            Student studentC = new Student(firstNameC, lastNameC, studentNumberC, averageScoreC);
            studentsList.AddFirst(studentC);

            //string firstName = "";
            //string lastName = "";
            //string studentNumber = "";
            //float averageScore = ;
            //Student student = new Student(firstName, lastName, studentNumber, averageScore);
            //studentsList.AddFirst(student);

        }

        public void Add (Student student)
        {
            studentsList.AddFirst(student);
        }

        public Student GetElement (int index)
        {
            Student[] studentsListTab = new Student[studentsList.Count];
            studentsList.CopyTo(studentsListTab, 0);
            return studentsListTab[index - 1];
        }

        public void RemoveByIndex(int index)
        {
            Student[] studentsListTab = new Student[studentsList.Count];
            studentsList.CopyTo(studentsListTab, 0);
            Student removeByIndex = studentsListTab[index - 1];
            studentsList.Remove(removeByIndex);
        }

        public void RemoveFirst()
        {
            studentsList.RemoveFirst();
        }

        public void RemoveLast()
        {
            studentsList.RemoveLast();
        }

        public void DisplayList()
        {
            Console.WriteLine("\nThere is the student list : \n ");
            foreach (Student student in studentsList )
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}

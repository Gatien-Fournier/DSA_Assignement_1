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

        public CustomDataList(LinkedList<Student> studentsList)
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
            float averageScoreA = 90;
            Student studentA = new Student(firstNameA, lastNameA, studentNumberA, averageScoreA);
            studentsList.AddFirst(studentA);

            string firstNameB = "Olivier";
            string lastNameB = "Giroud";
            string studentNumberB = "FR9";
            float averageScoreB = 79;
            Student studentB = new Student(firstNameB, lastNameB, studentNumberB, averageScoreB);
            studentsList.AddFirst(studentB);

            string firstNameC = "Zinedine";
            string lastNameC = "Zidane";
            string studentNumberC = "FR10";
            float averageScoreC = 94;
            Student studentC = new Student(firstNameC, lastNameC, studentNumberC, averageScoreC);
            studentsList.AddFirst(studentC);

            string firstNameD = "Paul";
            string lastNameD = "Pogba";
            string studentNumberD = "FR6";
            float averageScoreD = 88;
            Student studentD = new Student(firstNameD, lastNameD, studentNumberD, averageScoreD);
            studentsList.AddFirst(studentD);

            //string firstName = "";
            //string lastName = "";
            //string studentNumber = "";
            //float averageScore = ;
            //Student student = new Student(firstName, lastName, studentNumber, averageScore);
            //studentsList.AddFirst(student);

        }

        public void Add(Student student)
        {
            studentsList.AddFirst(student);
        }

        public Student GetElement(int index)
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

        public void GetMaxElement()
        {
            Student[] studentsListTab = new Student[studentsList.Count];
            studentsList.CopyTo(studentsListTab, 0);
            float scoreMax = studentsListTab[0].AverageScore;
            int indexMaxElement = 0;
            for (int i = 1; i < studentsList.Count - 1; i++)
            {
                if (scoreMax < studentsListTab[i].AverageScore)
                {
                    scoreMax = studentsListTab[i].AverageScore;
                    indexMaxElement = i;
                }
            }
            Console.WriteLine("The student with the best score is " + studentsListTab[indexMaxElement].FirstName + " " + studentsListTab[indexMaxElement].LastName + ", the student has an average score of " + studentsListTab[indexMaxElement].AverageScore + ".");
        }

        public void GetMinElement()
        {
            Student[] studentsListTab = new Student[studentsList.Count];
            studentsList.CopyTo(studentsListTab, 0);
            float scoreMin = studentsListTab[0].AverageScore;
            int indexMinElement = 0;
            for (int i = 1; i < studentsList.Count - 1; i++)
            {
                if (scoreMin > studentsListTab[i].AverageScore)
                {
                    scoreMin = studentsListTab[i].AverageScore;
                    indexMinElement = i;
                }
            }
            Console.WriteLine("The student with the lowest score is " + studentsListTab[indexMinElement].FirstName + " " + studentsListTab[indexMinElement].LastName + ", the student has an average score of " + studentsListTab[indexMinElement].AverageScore + ".");
        }
        public void Sort(int sortDirection, int sortField)
        {
            int count = studentsList.Count;
            Student[] studentsListTab = new Student[count];
            studentsList.CopyTo(studentsListTab, 0);
            Student[] studentsListFinish = new Student[count];

            if (sortField == 1)
            {

                if (studentsList.Count > 0)
                {
                    string lastWord = studentsListTab[0].FirstName;
                    int indexLastElement = 0;
                    for (int j = count - 1; j >= 0; j--)
                    {
                        for (int i = 1; i < count - 1; i++)
                        {
                            int compare = 0;
                            compare = String.Compare(lastWord, studentsListTab[i].FirstName);
                            if (compare>0)
                            {
                                lastWord = studentsListTab[i].FirstName;
                                indexLastElement = i;
                            }
                        }
                        string firstName = " ";
                        string lastName = " ";
                        string studentNumber = " ";
                        float averageScore = 0;
                        firstName = studentsListTab[indexLastElement].FirstName;
                        lastName = studentsListTab[indexLastElement].LastName;
                        studentNumber = studentsListTab[indexLastElement].StudentNumber;
                        averageScore = studentsListTab[indexLastElement].AverageScore;
                        Student studentCopy = new Student(firstName, lastName, studentNumber, averageScore);

                        Student removeByIndex = studentsListTab[indexLastElement];
                        studentsList.Remove(removeByIndex);

                        studentsListFinish[j] = studentCopy;

                    }
                }
                if (sortDirection == 1)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Student student = studentsListFinish[i];
                        studentsList.AddLast(student);
                    }
                }
                if (sortDirection == 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Student student = studentsListFinish[i];
                        studentsList.AddFirst(student);
                    }
                }
            }

            if (sortField == 2)
            {

                if (studentsList.Count > 0)
                {
                    string lastWord = studentsListTab[0].LastName;
                    int indexLastElement = 0;
                    for (int j = count - 1; j >= 0; j--)
                    {
                        for (int i = 1; i < count - 1; i++)
                        {
                            int compare = 0;
                            compare = String.Compare(lastWord, studentsListTab[i].LastName);
                            if (compare > 0)
                            {
                                lastWord = studentsListTab[i].LastName;
                                indexLastElement = i;
                            }
                        }
                        string firstName = " ";
                        string lastName = " ";
                        string studentNumber = " ";
                        float averageScore = 0;
                        firstName = studentsListTab[indexLastElement].FirstName;
                        lastName = studentsListTab[indexLastElement].LastName;
                        studentNumber = studentsListTab[indexLastElement].StudentNumber;
                        averageScore = studentsListTab[indexLastElement].AverageScore;
                        Student studentCopy = new Student(firstName, lastName, studentNumber, averageScore);

                        Student removeByIndex = studentsListTab[indexLastElement];
                        studentsList.Remove(removeByIndex);

                        studentsListFinish[j] = studentCopy;

                    }
                }
                if (sortDirection == 1)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Student student = studentsListFinish[i];
                        studentsList.AddLast(student);
                    }
                }
                if (sortDirection == 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Student student = studentsListFinish[i];
                        studentsList.AddFirst(student);
                    }
                }
            }

            if (sortField == 3)
            {

                if (studentsList.Count > 0)
                {
                    string lastWord = studentsListTab[0].StudentNumber;
                    int indexLastElement = 0;
                    for (int j = count - 1; j >= 0; j--)
                    {
                        for (int i = 1; i < count - 1; i++)
                        {
                            int compare = 0;
                            compare = String.Compare(lastWord, studentsListTab[i].StudentNumber);
                            if (compare > 0)
                            {
                                lastWord = studentsListTab[i].StudentNumber;
                                indexLastElement = i;
                            }
                        }
                        string firstName = " ";
                        string lastName = " ";
                        string studentNumber = " ";
                        float averageScore = 0;
                        firstName = studentsListTab[indexLastElement].FirstName;
                        lastName = studentsListTab[indexLastElement].LastName;
                        studentNumber = studentsListTab[indexLastElement].StudentNumber;
                        averageScore = studentsListTab[indexLastElement].AverageScore;
                        Student studentCopy = new Student(firstName, lastName, studentNumber, averageScore);

                        Student removeByIndex = studentsListTab[indexLastElement];
                        studentsList.Remove(removeByIndex);

                        studentsListFinish[j] = studentCopy;

                    }
                }
                if (sortDirection == 1)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Student student = studentsListFinish[i];
                        studentsList.AddLast(student);
                    }
                }
                if (sortDirection == 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Student student = studentsListFinish[i];
                        studentsList.AddFirst(student);
                    }
                }
            }

            if (sortField == 4)
            {

                if (studentsList.Count > 0)
                {
                    float scoreMin = studentsListTab[0].AverageScore;
                    int indexMinElement = 0;
                    for (int j = count - 1; j >= 0; j--)
                    {
                        for (int i = 1; i < count - 1; i++)
                        {
                            if (scoreMin > studentsListTab[i].AverageScore)
                            {
                                scoreMin = studentsListTab[i].AverageScore;
                                indexMinElement = i;
                            }
                        }

                        string firstName = " ";
                        string lastName = " ";
                        string studentNumber = " ";
                        float averageScore = 0;
                        firstName = studentsListTab[indexMinElement].FirstName;
                        lastName = studentsListTab[indexMinElement].LastName;
                        studentNumber = studentsListTab[indexMinElement].StudentNumber;
                        averageScore = studentsListTab[indexMinElement].AverageScore;
                        Student studentCopy = new Student(firstName, lastName, studentNumber, averageScore);

                        Student removeByIndex = studentsListTab[indexMinElement];
                        studentsList.Remove(removeByIndex);

                        studentsListFinish[j] = studentCopy;

                    }
                }
                if (sortDirection == 1)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Student student = studentsListFinish[i];
                        studentsList.AddLast(student);
                    }
                }
                if (sortDirection == 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Student student = studentsListFinish[i];
                        studentsList.AddFirst(student);
                    }
                }
            }
        }

        public void DisplayList()
            {
                Console.WriteLine("\nThere is the student list : \n ");
                foreach (Student student in studentsList)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
    }
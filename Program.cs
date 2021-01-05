using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Assignement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo escape;
            LinkedList<Student> newList = new LinkedList<Student>();
            CustomDataList studentsList = new CustomDataList(newList);

            studentsList.PopulateWithSampleData();

            do
            {
                Console.WriteLine("Welcome in the menu !\nThere are the differents possibilities:\nEnter 1 to add a student.\nEnter 2 to get an element with its index.\nEnter 3 to remove an element by its index.\nEnter 4 to remove the first element.\nEnter 5 to remove the last element.\nEnter 6 to display the list.\nEnter 7 to sort.\nEnter 8 to get the student with the best average score.\nEnter 9 to get the student with the worst average score.\n");
                int possibility = Convert.ToInt32(Console.ReadLine());
                switch (possibility)
                {
                    case 1:
                        Console.WriteLine("What is the first name of the student ?");
                        string firstName = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("What is the last name of the student ?");
                        string lastName = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("What is the student number of the student ?");
                        string studentNumber = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("How many grade do you want to enter:");
                        int numberOfGrades = Convert.ToInt32(Console.ReadLine());

                        int[] scores = new int[numberOfGrades];

                        Console.WriteLine("Enter the first grade:");
                        scores[0] = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i < numberOfGrades; i++)
                        {
                            Console.WriteLine("Enter an other grade:");
                            scores[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        float sumGrades = 0;
                        for (int i = 0; i < numberOfGrades; i++)
                        {
                            sumGrades = sumGrades + scores[i];
                        }

                        float averageScores = (sumGrades / numberOfGrades);

                        Student student = new Student(firstName, lastName, studentNumber, averageScores);
                        Console.WriteLine("\nThe new student:\n"+student.ToString()+"\n");
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.WriteLine("\nPlease give an index.\n");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Student studentIndex = studentsList.GetElement(index);
                        Console.WriteLine("Here is the student with the index " + index + " :\n" + studentIndex.ToString());
                        break;

                    case 3:
                        Console.WriteLine("\nPlease give an index.\n");
                        int indexRemove = Convert.ToInt32(Console.ReadLine());
                        studentsList.RemoveByIndex(indexRemove);
                        break;

                    case 4:
                        studentsList.RemoveFirst();
                        Console.WriteLine("The first student is removed.");
                        break;

                    case 5:
                        studentsList.RemoveLast();
                        Console.WriteLine("The last student is removed.");
                        break;

                    case 6:
                        studentsList.DisplayList();
                        break;

                    case 7:
                        Console.WriteLine("Please enter 0 if you want by increasing or 1 if you want a decreasing:");
                        int sortDirection = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter 1 if you want sort by the first name of the student, 2 sort by the last name of the student, 3 sort by the student number or 4 sort by the average grade:");
                        int sortField = Convert.ToInt32(Console.ReadLine());
                        studentsList.Sort(sortDirection, sortField);
                        break;

                    case 8:
                        studentsList.GetMaxElement();
                        break;

                    case 9:
                        studentsList.GetMinElement();
                        break;

                }
                Console.WriteLine("Press escape to quit or another key to return to the menu.");
                escape = Console.ReadKey();
                Console.WriteLine(" ");
            } while (escape.Key != ConsoleKey.Escape);
        }
    }
}

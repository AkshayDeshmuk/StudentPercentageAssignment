using System;
/* Create an Exam Marks program
i. Create an array of Student (RollNo, Name, TotalMarks, Percentage)
(Create Student class and decide which datatype to use for the 3 fields)
ii.Display on Screen "How many students are there in class?" and accept the 
input
iii. Allocate memory for these student
iv. Loop through Student array and ask user to Enter RollNo, Name, etc. 
(Note: Do not ask to enter Percentage)
v.Create a new function void CalculatePercentage(Student students, int size)
vi.Call this function from Main
vii. In the CalculatePercentage function, calculate the Percentage of each 
student
viii. After Percentage is calculated sort the student array, with highest 
Percentage first
ix. Display a nice report for the final Student List along with Percentage */


namespace Day4Assignment
{
    internal class Student
    {
        int rollNo;
        string name;
        int totalMarks;
        float percentage;

        static void CalculatePercentage(Student[] students, int size)
        {
            //calculating percentage
            for (int i = 0; i <size; i++)
            {
                students[i].percentage = (float)students[i].totalMarks * 100 / 500 ;
            }
            //sorting logic
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    Student temp;
                    if (students[i].percentage < students[j].percentage)
                    {
                        temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }

        static void DisplayData(Student[] students)
        {
            string horizontalLines = new string('=', 70);
            char p = '%';
            Console.WriteLine(horizontalLines);
            Console.WriteLine($"|{"Roll No",-10}|{"Name",-27}|{"Marks",-15}|{"Percentage",-13}|");
            Console.WriteLine(horizontalLines);
            foreach (var student in students)
            {
                Console.WriteLine($"|{student.rollNo,-10}|{student.name,-27}|{student.totalMarks,-15}|{ student.percentage,-12}{p}|");
            }

            Console.WriteLine(horizontalLines);
        }
        static void Main(string[] args)
        {
            Console.Write("How many students are there in class:");
            int inputData=Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[inputData];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                Console.Write("Enter your roll no:");
                students[i].rollNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your name:");
                students[i].name = Console.ReadLine();
                Console.Write("Enter total marks:");
                students[i].totalMarks = Convert.ToInt32(Console.ReadLine());
 
            }
            CalculatePercentage(students, inputData);

            DisplayData(students);

        }
    }
}

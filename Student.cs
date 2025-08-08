using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Student
    {
        //Student class

        // Multiple veriables for student's personal data.
        private string FirstName;  
        private string LastName;  
        private int StudentNumber;
        private int quiz1;
        private int quiz2;
        private int FinalExam;
        private string SchoolName;


        // Constructor to initialize all student data.
        public Student(string _FirstName, string _LastName,int _StudentNumber, int _quiz1, int _quiz2, int _FinalExam, string _SchoolName)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            StudentNumber = _StudentNumber;
            quiz1 = _quiz1;
            quiz2 = _quiz2;
            FinalExam = _FinalExam;
            SchoolName = _SchoolName;
        }

        // Show student's personal information.
        public void ShowStudentInformation()
        {
            Console.WriteLine("Student's firstname : " + FirstName);
            Console.WriteLine("Student's lastname : " + LastName);
            Console.WriteLine("Student's number : " + StudentNumber);
        }

        // Calculate and show the average grade.
        public void AverageGrade()
        {
            int avg = (quiz1 + quiz2 + FinalExam) / 3;
            Console.WriteLine("Student's average grade is :"+ avg);
        }

        // Show the student's school name.
        public void ShowSchoolName()
        {
            Console.WriteLine("Student's school name is :" + SchoolName);
        }


    }
}

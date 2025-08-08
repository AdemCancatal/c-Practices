using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Write a student application which has these options.
            // There will be a student and we will be able to see student number, lastname, quiz1, quiz2, final exam and school name.
            // There will be a method named by ShowStudentInformation() and we'll be able to see student's personal information.
            // There will be a method named by AverageGrade() and we will be able to see what is student's average grade.
            // There will be a method named by ShowSchool() and we will be able to see what is the name of student's school.

            Student student1 = new Student("John","Brington",20490,38,77,65,"Vienna Technical University");
            // An object for Student class with name, surname, ID, grades and school name.
            int choose = 0;
            // Initialize the user's menu choice
            do
            {
                Console.WriteLine("----------*----------");
                Console.WriteLine("Which one would you like to operate :");
                Console.WriteLine("Press 1 to see student's personal information.");
                Console.WriteLine("Press 2 to see student's avegage grade.");
                Console.WriteLine("Press 3 to see student's school name.");
                Console.WriteLine("Press 4 to quit");
                Console.WriteLine("----------*----------");
                // Ask user to choose an operation.
                choose = int.Parse(Console.ReadLine());
                // Read user's choice and convert to integer.

                // Perform different actions based on user's choice.
                if (choose == 1)
                {
                    student1.ShowStudentInformation();
                    // Show student information.
                }
                else if (choose == 2)
                {
                    student1.AverageGrade();
                    // Calculate and show student's average grade.
                }
                else if (choose ==3)
                {
                    student1.ShowSchoolName();
                    // Show the name of the school.
                }
                else
                {
                    Console.WriteLine("Quiting the application...");
                    // Exit option.
                }


            }while (choose != 4);
            // Repeat the menu until the user chooses to quit (option 4)

            Console.WriteLine("You have quit the application succesfully.");
            // Show exit message after quitting.
        }
    }
}

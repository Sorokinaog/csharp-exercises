using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.WriteLine("grade: ");
                    double newGrade = double.Parse(Console.ReadLine());

                    students.Add(newStudent, newGrade);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            StringBuilder studentNameGrade = new StringBuilder(); 
            foreach (KeyValuePair<string, double> student in students)
            {
                studentNameGrade.AppendFormat("{0}({1})\n", student.Key, student.Value);
            }
            Console.WriteLine(studentNameGrade);
            double sum = students.Values.Sum();
            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace StudentsBookDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's ID
                    Console.WriteLine("ID number: ");
                    int newId = int.Parse(Console.ReadLine());

                    students.Add(newId, newStudent);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }


            Console.ReadLine();
        }
    }
}

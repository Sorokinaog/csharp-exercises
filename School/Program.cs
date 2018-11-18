using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Student
    {
        string name;
        int studentId;
        int numOfCredits;
        double gpa;

        public string Name
        {
            get { return name; }
            internal set { name = value; }
        }
        public int StudentId { get; set; }
        public int NumOfCredits { get; set; }
        public double Gpa { get; set; }

        private Student(string name, int studentId, int numOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumOfCredits = numOfCredits;
            Gpa = gpa;
        }
    }

    public class Course
    {
        private int roomNumber;
        private  List<Student> students;
        private string teacherName;

        public int RoomNumber { get; set; }
        public List<Student> Students { get; set; }
        public string TeacherName
        {
            get { return teacherName; }
            internal set { teacherName = value; }
        }
    }
}

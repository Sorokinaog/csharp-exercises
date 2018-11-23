using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student (string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double QualityScore = (this.Gpa * this.NumberOfCredits) + (grade * courseCredits); 
            this.NumberOfCredits = this.NumberOfCredits + courseCredits;
            this.Gpa = (QualityScore / this.NumberOfCredits);
        }

        public string GetGradeLevel()
        {
            if (this.NumberOfCredits > 0 & this.NumberOfCredits <= 29)
            {
                return "freshman";
            }
            else if (this.NumberOfCredits <= 59)
            {
                return "sophomore";
            }
            else if (this.NumberOfCredits <= 89)
            {
                return "junior";
            }
            else
            {
                return "senior";
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + " ID: " + StudentId + " Credits: " + NumberOfCredits + " GPA: " + Gpa.ToString("0.00") + " GradeLevel: " + GetGradeLevel();
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Student studentObj = obj as Student;
            return (this.Name == studentObj.Name && this.StudentId == studentObj.StudentId);
        }

        public override int GetHashCode()
        {
            return StudentId;
        }
    }

}

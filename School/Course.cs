using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Course
    {
        private int roomNumber;
        private List<Student> students;
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

using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student olga = new Student("Olga");
            olga.AddGrade(13, 4.0);
            olga.AddGrade(7, 3.0);
            olga.AddGrade(10, 4.0);
            Student max = new Student("Max");
            max.AddGrade(6, 3);

            Console.WriteLine(olga);
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }

}

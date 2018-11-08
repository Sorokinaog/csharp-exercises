using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a radius:");
            int radius = int.Parse(Console.ReadLine());

            while (radius <= 0)
            {
                Console.WriteLine("A radius has to be positive");
                Console.WriteLine("Enter a radius:");
                radius = int.Parse(Console.ReadLine());

            }

            double pi = 3.14159;
            double area = pi * radius * radius;

            Console.WriteLine("The area of a circle with radius " + radius + " " +
                    "is: " + area);
            Console.ReadLine();
        }
    }
}

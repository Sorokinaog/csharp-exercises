using System;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of rectangle: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of rectangle: ");
            int width = int.Parse(Console.ReadLine());
            int area = length * width;
            Console.WriteLine("The area of rectangle with length " + length + ", width " + width + " is " + area);
            Console.ReadLine();
        }
    }
}

using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of miles you have driven: ");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of gas you've consumed (in gallons): ");
            double gallons = double.Parse(Console.ReadLine());
            double MilesRerGallon = miles / gallons;
            Console.WriteLine("Your miles-per-gallon is: "+ MilesRerGallon);
            Console.ReadLine();
        }
    }
}

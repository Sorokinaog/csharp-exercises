using System;

namespace HelloUserName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string Username = Console.ReadLine();

            Console.WriteLine("Hello, " + Username);
            Console.ReadLine();
        }
    }
}

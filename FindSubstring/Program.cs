using System;

namespace FindSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputStr = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("The first sentence of Alice's Adventures in Wonderland is below: \n\n"+InputStr);
            string MyStr = InputStr.ToLower();
            Console.WriteLine("\nEnter the substring to serch in the string above: ");
            string UserStr = (Console.ReadLine()).ToLower();
            bool b = MyStr.Contains(UserStr);
            if (b == true)
            {
                Console.WriteLine("Search substring was found!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Search substring was not found...");
                Console.ReadLine();
            } 

        }
    }
}

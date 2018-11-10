using System;
using System.Collections.Generic;

namespace Printing5letterWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> myList = new List<string> {"banana", "window", "block", "table", "sun"};
            Lists.Print5lettersWords(myList);
            Console.ReadLine();
        }
    }

    public class Lists
    {
        public static void Print5lettersWords(List<string> anyList)
        {
            foreach (string word in anyList)
			{
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
			}
        }


    }
}

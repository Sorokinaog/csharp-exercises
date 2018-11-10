using System;
using System.Collections.Generic;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's create your list of numbers.");
            List<int> myList = new List<int>();
            Console.Write("What is the length of your list? ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter the {0} element of the list :", i + 1);
                myList.Add(int.Parse(Console.ReadLine()));
            }
            

            int sumEvenNumbers = Lists.SumEvenNumbers(myList);
            Console.WriteLine("The sum of even numbers is " + sumEvenNumbers);
            Console.ReadLine();
        }

    }

    public class Lists
    {
        public static int SumEvenNumbers(List<int> anyList)
        {
            int sum = 0;
            foreach (int item in anyList)
            {
                if (item % 2 == 0)
                {
                    sum += item;  
                }
            }
            return sum;
        }
    }

}

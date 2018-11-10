using System;

namespace PrintingArrayValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = new int[] {1,1,2,3,5,8};
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}

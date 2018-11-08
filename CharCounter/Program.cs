using System;
using System.Collections.Generic;

namespace CharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputStr = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            string MyStr = InputStr.Replace(" ", string.Empty).ToLower();
            Dictionary<string, int> Chars = new Dictionary<string, int>();

            do
            {
                string OneChar = MyStr[0].ToString();
                int count = (MyStr.Length - MyStr.Replace(OneChar, string.Empty).Length);
                MyStr = MyStr.Replace(OneChar, string.Empty);
                Chars.Add(OneChar, count);

            } while (MyStr.Length != 0);

            foreach (KeyValuePair<string, int> Char in Chars)
            {
                Console.WriteLine(Char.Key + ": " + Char.Value);
            }
            Console.ReadLine();

        }

    }
}

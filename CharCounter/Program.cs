using System;
using System.Collections.Generic;

namespace CharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            string myStr = inputStr.Replace(" ", string.Empty).ToLower();
            Dictionary<string, int> chars = new Dictionary<string, int>();

            do
            {
                string oneChar = myStr[0].ToString();
                int count = myStr.Length - myStr.Replace(oneChar, string.Empty).Length;
                myStr = myStr.Replace(oneChar, string.Empty);
                chars.Add(oneChar, count);

            } while (myStr.Length != 0);

            foreach (KeyValuePair<string, int> Char in chars)
            {
                Console.WriteLine(Char.Key + ": " + Char.Value);
            }
            Console.ReadLine();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_maintasks
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string sam = Console.ReadLine().ToLower();
            bool s = sam.Contains('a') || sam.Contains('e') || sam.Contains('i') || sam.Contains('o') || sam.Contains('u');
            Console.WriteLine(s);

            if (!s)
            {
                Console.WriteLine("The string does not contain any vowels.");
            }
            else
            {
                Console.WriteLine("The string contains at one vowel.");
            }
        }
    }
}

using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string here: ");
            //reasd first input string
            string entry = Console.ReadLine();

            Console.WriteLine("Enter the character to seach: ");
            //Read char input for search
            char searchInput = Console.ReadLine()[0];
            //Gets INdex of char from string
            int searchIndex = entry.IndexOf(searchInput);
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);
        }
    }
}

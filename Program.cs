using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name and press enter:");
            string name = Console.ReadLine();
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.Substring(1));

        }
    }
}

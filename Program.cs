using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name and press enter:");
            string name = Console.ReadLine();
            string nameUpperCase = String.Format("Upper Case : {0}", name.ToUpper());
            string nameLowerCase = String.Format("Lower Case : {0}", name.ToLower());
            string nameTrimmed = String.Format("Trimmed value : {0}", name.Trim());
            string nameSubString = String.Format("Substring value : {0}", name.Substring(0, 5));

            Console.WriteLine(nameUpperCase);
            Console.WriteLine(nameLowerCase);
            Console.WriteLine(nameTrimmed);
            Console.WriteLine(nameSubString);

        }
    }
}

using System;

namespace Challenge1
{
    class Program
    {
        // refrence -> state = temp >100? "gas" : temp <0 ?"solid":"liquid";
        static void Main(string[] args)
        {
            int temp = 0;
            string tempMessage = string.Empty;
            string inputValue = string.Empty;

            Console.WriteLine("Please enter current temp: ");
            inputValue = Console.ReadLine();
            bool validInteger = int.TryParse(inputValue, out temp);

            if (validInteger)
            {
                tempMessage = temp <= 15 ? "it is too cold here" : (temp >= 16 && temp <= 28) ? "it is ok" : temp > 28 ? "It is hot":"";
                Console.WriteLine(tempMessage);
            }
            else
            {
                Console.WriteLine("Not a valid temperature");
            }
        }
    }
}

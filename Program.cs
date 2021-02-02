using System;

namespace Challenge1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string input = "0" ;
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter next score");
                Console.WriteLine("Current number of entries {0}", count);
                Console.WriteLine("Enter -1 to start calculations");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("---------------------------------------");
                    //calculate average, give answer
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score is {0}", average);
                }
                if(int.TryParse(input, out currentNumber) && currentNumber >0 && currentNumber <21)
                {
                    total += currentNumber;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a valur between 1 and 20.");
                    }
                    continue;
                }
                count++;
            }
            

        }
    }
}

using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Paul";
            string name2 = "Holly";
            string name3 = "Aaron";
            GreetFriend(name1);
            GreetFriend(name2);
            GreetFriend(name3);
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hi " + name + ", my firend!");
      
        }
    }
}

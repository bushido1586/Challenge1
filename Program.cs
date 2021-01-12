using System;

namespace Challenge1
{
    class Program
    {
        static int highscore = 300;
        static string highScorePlayer = "Brad";
        static void Main(string[] args)
        {
            ScoreCalculator("David", 250);
            ScoreCalculator("Martin", 315);
            ScoreCalculator("Brad", 325);

        }
        public static void ScoreCalculator(string playerName, int score)
        {
            if( score > highscore){
                highscore = score;
                highScorePlayer = playerName;
                Console.WriteLine("New High Score is " + score);
                Console.WriteLine("High Score Holder is: " +playerName);
            }else
            {
                Console.WriteLine("The old score stands, please try again. High score is still " +highscore+ " and held by " +highScorePlayer);
            }
        }
    }
}

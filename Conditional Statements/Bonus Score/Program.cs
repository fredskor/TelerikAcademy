using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            if (score >= 1 & score <=3)
            {
                int multiplyScore = score * 10;
                Console.WriteLine(multiplyScore);
            }
            else if (score >= 4 & score <= 6)
            {
                int multiplyScore = score * 100;
                Console.WriteLine(multiplyScore);
            }
            else if (score >= 7 & score <= 9)
            {
                int multiplyScore = score * 1000;
                Console.WriteLine(multiplyScore);
            }
            else if (score > 9 | score <= 0)
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}

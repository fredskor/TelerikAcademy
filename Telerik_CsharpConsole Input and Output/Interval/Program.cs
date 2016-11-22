using System;

namespace Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = n + 1; i < m; i++)
            {
                if (i % 5== 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);             
        }
    }
}

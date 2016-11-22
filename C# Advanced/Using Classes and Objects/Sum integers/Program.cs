using System;
using System.Linq;

namespace Sum_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine(input.Sum());
            //Console.ReadKey();
        }
    }
}

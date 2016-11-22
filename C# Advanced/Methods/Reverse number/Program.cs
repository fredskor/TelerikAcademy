using System;

namespace Reverse_number
{
    class Program
    {
        static string ReversedNumber(string input)
        {
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            return output;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReversedNumber(input));

        }
    }
}

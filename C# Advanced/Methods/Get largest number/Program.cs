using System;

namespace Get_largest_number
{
    class Program
    {
        static int GetMax(int firstNumber, int secondNumber)
        {
            int maxNum = firstNumber;
            if (firstNumber < secondNumber)
            {
                maxNum = secondNumber;
            }
            return maxNum;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            Console.WriteLine(GetMax(a, GetMax(b, c)));
        }
    }
}
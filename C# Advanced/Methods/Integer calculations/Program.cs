using System;
using System.Numerics;

namespace Integer_calculations
{
    class Program
    {
        public static void GetMin(params int[] Numbers)
        {
            int MinNumber = int.MaxValue;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                if (Numbers[curNumber] < MinNumber)
                {
                    MinNumber = Numbers[curNumber];
                }
            }

            Console.WriteLine(MinNumber);
        }


        public static void GetMax(params int[] Numbers)
        {
            int MaxNumber = int.MinValue;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                if (Numbers[curNumber] > MaxNumber)
                {
                    MaxNumber = Numbers[curNumber];
                }
            }

            Console.WriteLine(MaxNumber);
        }

        public static void GetAverage(params int[] Numbers)
        {
            int NumbersSum = 0;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                NumbersSum += Numbers[curNumber];
            }

            Console.WriteLine(((double)NumbersSum / (double)Numbers.Length).ToString("F2"));
        }


        public static void GetSum(params int[] Numbers)
        {
            int NumbersSum = 0;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                NumbersSum += Numbers[curNumber];
            }

            Console.WriteLine(NumbersSum);
        }


        public static void GetProduct(params int[] Numbers)
        {
            BigInteger NumbersProduct = 1;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                NumbersProduct *= Numbers[curNumber];
            }

            Console.WriteLine(NumbersProduct);
        }


        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            double[] dubArr = new double[input.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                dubArr[i] = arr[i];
            }

            GetMin(arr);
            GetMax(arr);
            GetAverage(arr);
            GetSum(arr);
            GetProduct(arr);

        }
    }
}

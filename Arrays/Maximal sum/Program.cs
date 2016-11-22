using System;

namespace Maximal_sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int currentSum = 0;
            int maxSum = int.MinValue;


            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                currentSum += arr[i];

                if (currentSum < arr[i])
                {
                    currentSum = arr[i];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}

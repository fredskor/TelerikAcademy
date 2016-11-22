using System;

namespace Appearance_count
{
    class Program
    {
        static void CountNumber(int[] array, int searchingNumber)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchingNumber)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[n];
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            CountNumber(arr, x);
        }
    }
}

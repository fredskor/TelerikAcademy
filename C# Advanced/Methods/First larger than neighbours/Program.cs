using System;

namespace First_larger_than_neighbours
{
    class Program
    {
        static void FirstLargerNumberInArray(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                try
                {
                    if (array[i + 1] > array[i + 2] && array[i + 1] > array[i])
                    {
                        Console.WriteLine(i + 1);
                        break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine(-1);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }
            FirstLargerNumberInArray(arr);
        }
    }
}

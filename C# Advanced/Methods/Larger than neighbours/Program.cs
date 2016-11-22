using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larger_than_neighbours
{
    class Program
    {
        static void CountLargerNumberInArray(int[] array)
        {
            int counter = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                try
                {
                    if (array[i + 1] > array[i + 2] && array[i + 1] > array[i])
                    {
                        counter++;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine(counter);
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
            CountLargerNumberInArray(arr);
        }
    }
}

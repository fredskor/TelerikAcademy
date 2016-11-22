using System;

namespace Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            int counter = 1;
            int checker = 1;
            int number = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > checker)
                {
                    checker = counter;
                    number = arr[i];
                }
            }
            Console.WriteLine("{0} ({1} times)", number, checker);
        }
    }
}

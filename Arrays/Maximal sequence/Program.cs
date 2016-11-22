using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_sequence
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
            int counter = 1;
            int checker = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    counter++;
                    checker = Math.Max(checker, counter);
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine(checker);
        }
    }
}

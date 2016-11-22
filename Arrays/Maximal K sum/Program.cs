using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_K_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] sumArr = new int[k];
            int item = 1;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int j = 0; j < k; j++)
            {

                sumArr[j] = arr[n - item];
                item++;
            }
            int sum = sumArr.Sum();
            Console.WriteLine(sum);
        }
    }
}

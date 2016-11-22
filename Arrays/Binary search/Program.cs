using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    Console.WriteLine(Array.IndexOf(arr, arr[i]));
                    counter++;
                    break;
                }

            }

            if (counter == 0)
            {
                Console.WriteLine("-1");
            }
        }
    }
}

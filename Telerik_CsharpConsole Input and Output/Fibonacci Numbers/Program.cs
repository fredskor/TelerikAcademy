using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Fibonacci_Numbers
{
    class Program
    {
        public static long Fibonacci(long n)
        {
            long a = 0;
            long b = 1;
            
            for (long i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long[] arr = new long[n];

            for (long i = 0; i < n; i++)
            {
                arr[i] = Fibonacci(i);
            }
            var result = string.Join(", ", arr);
            Console.WriteLine(result);
        }
    }
}

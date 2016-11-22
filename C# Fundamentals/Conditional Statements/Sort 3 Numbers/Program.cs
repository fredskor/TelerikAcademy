using System;

namespace Sort_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            if ((a > b & a > c & b > c) | (a > b & a == c & b > c))
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else if ((a > b & a > c & c > b) | (a > b & c > b & a == c))
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            else if ((b > a & b > c & a > c) | (b > a & b > c & b == c))
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else if ((b > a & b > c & c > a) | (b > a & b > c & b == c))
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            else if ((c > a & c > b & a > b) | (c > a & c > b & a == b))
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else if ((c > a & c > b & b > a) | (c > a & c > b & b == a))
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
            else if (a == b & a == c & b == c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
        }
    }
}

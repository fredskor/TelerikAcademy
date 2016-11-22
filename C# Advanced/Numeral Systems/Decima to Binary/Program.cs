using System;

namespace Decima_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());

            long rest;
            string binary = string.Empty;

            while (dec > 0)
            {
                rest = dec % 2;
                dec /= 2;
                binary = rest.ToString() + binary;
            }

            Console.WriteLine(binary);
        }
    }
}

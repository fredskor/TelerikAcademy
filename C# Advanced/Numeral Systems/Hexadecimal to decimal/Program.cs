using System;
using System.Globalization;

namespace Hexadecimal_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexa = Console.ReadLine();

            long dec = long.Parse(hexa, NumberStyles.HexNumber);

            Console.WriteLine(dec);
        }
    }
}

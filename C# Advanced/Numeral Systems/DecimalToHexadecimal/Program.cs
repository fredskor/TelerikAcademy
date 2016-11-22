using System;
using System.Globalization;

namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());

            string hexaStr = dec.ToString("X");

            long hexa = long.Parse(hexaStr, NumberStyles.HexNumber);

            Console.WriteLine(hexaStr);
        }
    }
}

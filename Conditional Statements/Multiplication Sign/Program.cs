using System;

namespace Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double product = a * b * c;
            if (product > 0)
            {
                Console.WriteLine("+");
            }
            else if (product < 0)
            {
                Console.WriteLine("-");
            }
            else if (product ==0)
            {
                Console.WriteLine("0");
            }
        }
    }
}

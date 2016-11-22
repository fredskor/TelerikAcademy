using System;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double p = 2 * Math.PI * r;
            double a = Math.PI * r * r;
            Console.WriteLine("{0:f2} {1:F2}", p,a);
        }
    }
}

using System;

namespace Triangle_surface_by_three_sides
{
    class Program
    {
        static double SurfaceOfTriangle(double a, double b, double c)
        {
            double semiPerimetr = (a + b + c) / 2;
            double surface = Math.Sqrt(semiPerimetr * (semiPerimetr - a)
                * (semiPerimetr - b)
                * (semiPerimetr - c));
            return surface;
        }

        static void Main(string[] args)
        {
            double aSide = double.Parse(Console.ReadLine());
            double bSide = double.Parse(Console.ReadLine());
            double cSide = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", SurfaceOfTriangle(aSide, bSide, cSide));
            //Console.ReadKey();
        }
    }
}

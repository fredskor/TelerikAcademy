using System;

namespace Triangle_surface_by_two_sides_and_an_angle
{
    class Program
    {
        static double SurfaceOfTriangle(double a, double b, double y)
        {
            double angle = Math.PI * y / 180.0;
            double surface = (a * b * Math.Sin(angle)) / 2;
            return surface;
        }

        static void Main(string[] args)
        {
            double aSide = double.Parse(Console.ReadLine());
            double bSide = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", SurfaceOfTriangle(aSide, bSide, y));
            //Console.ReadKey();
        }
    }
}

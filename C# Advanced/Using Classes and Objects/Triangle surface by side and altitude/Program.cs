using System;

namespace Triangle_surface_by_side_and_altitude
{
    class Program
    {
        static double TriangleSurface(double side, double altitude)
        {
            double half = 0.5;
            double surface = half * side * altitude;

            return surface;
        }

        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", TriangleSurface(side, altitude));
            //Console.ReadKey();
        }
    }
}

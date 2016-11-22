using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please enter sides a, b and the heigh h of trapezoid:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Trapezoid's area is : {0}", (a + b) * h / 2);
    }
}
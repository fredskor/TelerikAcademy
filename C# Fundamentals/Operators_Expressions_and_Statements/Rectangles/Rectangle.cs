﻿using System;

class Rectangle
{
    static void Main()
    {
        Console.WriteLine("Please, enter rectangle’s width and height: ");
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter is {0}", 2 * width + 2 * height);
        Console.WriteLine("Area is {0}", width * height);
    }
}
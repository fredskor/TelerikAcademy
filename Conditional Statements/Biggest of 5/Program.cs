﻿using System;

namespace Biggest_of_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            if (a > b & a> c & a > d & a > e)
            {
                Console.WriteLine(a);      
            }
            else if (b > a & b > c  & b > d & b > e)
            {
                Console.WriteLine(b);
            }
            else if (c > b & c > a & c > d & c > e)
            {
                Console.WriteLine(c);
            }
            else if (d > b & d > c & d > a & d > e)
            {
                Console.WriteLine(d);
            }
            else if (e > b & e > a & e > d & e > c)
            {
                Console.WriteLine(e);
            }
            else if (a == b & a==c & a==d & a==e)
            {
                Console.WriteLine(a);
            }
        }
    }
}

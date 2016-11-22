using System;


namespace Leap_year
{
    class Program
    {
        static void IsLeap(int year)
        {
            bool isLeap = System.DateTime.IsLeapYear(year);
            if (isLeap)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }

        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            IsLeap(year);

        }
    }
}

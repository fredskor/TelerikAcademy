using System;

    class AgeAfterTenYears
    {
        static void Main()
        {
            DateTime ageNow = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            TimeSpan currentAge = (now.Subtract(ageNow));
            Console.WriteLine(new DateTime(currentAge.Ticks).Year - 1);
            Console.WriteLine((new DateTime(currentAge.Ticks).Year - 1) + 10);
        }
    }


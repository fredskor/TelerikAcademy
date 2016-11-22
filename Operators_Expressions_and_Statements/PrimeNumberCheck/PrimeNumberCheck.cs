using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please, enter the number:");
        int num = int.Parse(Console.ReadLine());
        if (num >= 100)
        {
            Console.WriteLine("Error! Please check the number and try again!");
            return;
        }
        if (num < 2)
        {
            Console.WriteLine(false);
            return;
        }
        int i = 2;
        int composite = 0;
        bool checkNum = num % i != 0;
        for (; i <= Math.Sqrt(num); i++)
        {
            if (i != 1 || i != num)
            {
                if (checkNum = num % i != 0)
                {
                    continue;
                }
                else
                {
                    composite++;
                    break;
                }
            }
        }
        if (composite != 0)
        {
            Console.WriteLine(checkNum);
        }
        else
        {
            Console.WriteLine(checkNum);
        }
    }
}
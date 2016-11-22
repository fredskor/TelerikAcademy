using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter the number:");
        int number = int.Parse(Console.ReadLine());
        bool check = number % 2 != 0;
        Console.WriteLine("Number is odd - true. Number is even - false");
        Console.WriteLine(check);
    }
}


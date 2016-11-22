using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Please, enter the number: ");
        int number = int.Parse(Console.ReadLine());
        int firstDigit = number % 10;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = (number / 10 / 10) % 10;
        bool check = thirdDigit == 7;
        Console.WriteLine("{0}", thirdDigit);
    }
}
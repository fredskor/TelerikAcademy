using System;

class MinMaxSumAvarageOfNumbers
{
    static void Main()
    {
        Console.WriteLine("How many numbers are in the sequence?");
        int sequenceLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your numbers: ");
        int sum = new int();
        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < sequenceLength; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < min)
            {
                min = number;
            }
            else if (number > max)
            {
                max = number;
            }
            sum += number;
        }
        float avarage = sum / (float)sequenceLength;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F}",
            min, max, sum, avarage);
    }
}
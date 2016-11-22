using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Please, enter the integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter the position of the bit:");
        int p = int.Parse(Console.ReadLine());
        int nP = n >> p;
        int bit = nP & 1;
        Console.WriteLine(bit);
    }
}

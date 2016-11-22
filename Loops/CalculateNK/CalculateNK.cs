using System;
using System.Numerics;

class CalculateNK
{
    static void Main()
    {

        Console.Write("Please, enter N : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter K : ");
        int k = int.Parse(Console.ReadLine());


        while (!(k > 1 && n > k && n < 100))
        {
            Console.WriteLine("1 < K < N < 100");
            Console.Write("Again, enter N : ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Againe, enter K : ");
            k = int.Parse(Console.ReadLine());
        }


        BigInteger result = 1;
        while (n > k)
        {
            result *= n;
            n--;
        }
        Console.WriteLine(result);
    }
}
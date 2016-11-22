using System;
using System.Numerics;

class CalculateProblem7
{
    static void Main()
    {
        Console.WriteLine("Please, enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter K: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger diffFact = 1;
        int diff = n - k;
        int len = Math.Max(n, k);

        for (int i = 1; i <= len; i++)
        {
            if (i <= n)
            {
                nFact *= i;
            }
            if (i <= k)
            {
                kFact *= i;
            }
            if (i <= diff)
            {
                diffFact *= i;
            }
        }
        BigInteger result = nFact / (kFact * diffFact);
        Console.WriteLine("Result = " + result);
    }
}
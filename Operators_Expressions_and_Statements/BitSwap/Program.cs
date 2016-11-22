using System;

class BitSwap
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int lenght = Math.Min(p, q) + k;

        for (; Math.Min(p, q) < lenght; p++, q++)
        {
            uint firstMask = (uint)(n & 1 << p);
            uint secondMask = (uint)(n & 1 << q);

            if (firstMask != 0)
            {
                n = n | (uint)(1 << q);
            }
            else
            {
                n = n & (uint)(~(1 << q));
            }

            if (secondMask != 0)
            {
                n = n | (uint)(1 << p);
            }
                else
            {
                n = n & (uint)(~(1 << p));
            }
        }
        Console.WriteLine(n);            
    }
}

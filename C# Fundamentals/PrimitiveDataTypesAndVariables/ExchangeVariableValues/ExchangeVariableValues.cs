using System;

    class ExchangeVariableValues
{
        static void Main()
        {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:");
        Console.WriteLine("a =" + " " + a);
        Console.WriteLine("b =" + " " + b);

        a = 10;
        b = 5;
        Console.WriteLine("After:");
        Console.WriteLine("a =" + " " + a);
        Console.WriteLine("b =" + " " + b);
    }
    }


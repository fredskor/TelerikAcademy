using System;

    class ProblemNullValuesArithmetic
    {
        static void Main()
        {
        int? testInteger = null;
        Console.WriteLine("Integer with Null value ---> " + testInteger);
        testInteger = 7;
        Console.WriteLine("Integer with value 7 ---> " + testInteger);
       
        double? testDouble = null;
        Console.WriteLine("Real number with Null value ---> " + testDouble);
        testDouble = 1.7;
        Console.WriteLine("Real number with value 1.7 ---> " + testDouble);
    }
    }


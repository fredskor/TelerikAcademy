using System;

namespace Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "integer":
                    int intNumber = int.Parse(Console.ReadLine());
                    intNumber += 1;
                    Console.WriteLine(intNumber);
                    break;
                case "real":
                    double doubleNumber = double.Parse(Console.ReadLine());
                    doubleNumber += 1;
                    Console.WriteLine("{0:f2}", doubleNumber);
                    break;
                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
            }
        }
    }
}

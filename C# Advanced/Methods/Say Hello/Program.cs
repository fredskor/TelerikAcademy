using System;

namespace Say_Hello
{
    class Say_Hello
    {
        static void WriteHello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            WriteHello(n);
        }
    }
}

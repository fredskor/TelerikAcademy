using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        int triangle = 169;

        Console.WriteLine(" " + " " + " " + (char)triangle);
        Console.WriteLine(" " + " " + (char)triangle + " " + (char)triangle);
        Console.WriteLine(" " + (char)triangle + " " + " " + " " + (char)triangle);
        Console.WriteLine((char)triangle + " " + (char)triangle + " " + (char)triangle + " " + (char)triangle);
    }
}
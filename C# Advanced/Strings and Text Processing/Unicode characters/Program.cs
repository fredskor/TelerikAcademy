using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            output.AppendFormat("\\u{0:X4}", (int)input[i]);
        }

        Console.WriteLine(output.ToString());
    }
}
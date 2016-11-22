using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var startPattern = 0;
            var endPattern = 0;
            var substr = "";
            var substrWithPattern = "";
            var parsed = input;

            while (true)
            {
                startPattern = input.IndexOf("<upcase>");
                endPattern = input.IndexOf("</upcase>");
                if (startPattern == -1)
                {
                    break;
                }
                substrWithPattern = input.Substring(startPattern, endPattern - startPattern + 9);
                substr = input.Substring(startPattern + 8, endPattern - startPattern - 8);
                input = input.Replace(substrWithPattern, substr.ToUpper());
            }
            Console.WriteLine(input);

        }
    }
}
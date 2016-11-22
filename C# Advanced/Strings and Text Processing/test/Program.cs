using System;
using System.Linq;
using System.Text;
 
class ExtractSentences
{
    static char[] ExtractSeparators(string text)
    {
        char[] separators = text.Where(x => !char.IsLetter(x) && x != '.').Distinct().ToArray(); 
        return separators;
    }

    static void Main()
    {
        string word = Console.ReadLine().ToLower();
        string text = Console.ReadLine();
        string[] sentences = text.Split('.').ToArray();

        char[] separators = ExtractSeparators(text);

        StringBuilder filters = new StringBuilder();

        for (int i = 0; i < sentences.Length; i++)
        {
           
            var words = sentences[i].ToLower().Split(separators).ToArray();
            bool isword = words.Any(x => x == word);

            if (isword)
            {
                filters.Append(sentences[i] + ".");
            }
        }

        Console.WriteLine(string.Join(" ", filters));
    }

}
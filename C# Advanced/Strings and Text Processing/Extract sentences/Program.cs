using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            var startIndex = 0;
            var wordIndex = 0;
            var wordPointIndex = 0;
            var lastIndex = 0;
            string newText = string.Empty;
            word = " " + word + " ";
            string wordPoint = " " + word + ".";


            while (text.Contains(word) || text.Contains(wordPoint))
            {
                if (text.Contains(word))
                {
                    wordIndex = text.IndexOf(word);
                    lastIndex = text.IndexOf(".");

                    if (wordIndex > startIndex && wordIndex < lastIndex + 1)
                    {
                        newText += text.Substring(startIndex, lastIndex + 1);
                    }

                    text = text.Remove(startIndex, lastIndex + 1);
                    wordIndex = text.IndexOf(word);
                }
                else if (text.Contains(wordPoint))
                {
                    wordPointIndex = text.IndexOf(wordPoint);
                    lastIndex = text.IndexOf(".");

                    if (wordPointIndex > startIndex && wordPointIndex < lastIndex + 1)
                    {
                        newText += text.Substring(startIndex, lastIndex + 1);
                    }

                    text = text.Remove(startIndex, lastIndex + 1);
                    wordIndex = text.IndexOf(wordPoint);
                }
               
            }
            Console.WriteLine(newText);
        }
    }
}

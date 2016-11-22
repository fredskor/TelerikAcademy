using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Replace_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine();
            //var startIndex = 0;
            //var endIndex = 0;
            //var substrWithPattern = "";
            //var substr = "";

            //while (true)
            //{
            //    startIndex = input.IndexOf("<a");
            //    endIndex = input.IndexOf("</a>");
            //    if (startIndex == -1)
            //    {
            //        break;
            //    }
            //    substrWithPattern = input.Substring(startIndex, endIndex - startIndex + 4);
            //    substr = input.Substring(startIndex + 9, endIndex - startIndex - 19);
            //    input = input.Replace(substrWithPattern, substr.ToUpper());
            //}
            //Console.WriteLine(input);

                string text = Console.ReadLine();
                string parsedHTML = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
                Console.WriteLine(parsedHTML);
            }
        }
    }

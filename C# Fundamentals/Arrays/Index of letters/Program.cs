using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = new char[26];
            int i = 0;

            for (char j = 'a'; j <= 'z'; j++)
            {
                arr[i] = j;
                i++;

            }

            for (int element = 0; element < input.Length; element++)
            {
                char checkIndex = input[element];
                Console.WriteLine(Array.IndexOf(arr, checkIndex));
            }
        }
    }
}

using System;

namespace Series_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] arr = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                arr[i] = text[i].ToString();
            }
            var result = arr[0]; 
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    result += arr[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}

using System;

namespace Adding_polynomials
{
    class Program
    {
        static void Polynomials(int[] firstArr, int[] secondArr)
        {
            int result = 0;
            int len = firstArr.Length;
            string output = "";

            for (int i = 0; i < len; i++)
            {
                result = firstArr[i] + secondArr[i];
                output += result + " ";
            }
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                firstArr[i] = int.Parse(firstLine[i]);
            }
            for (int i = 0; i < n; i++)
            {
                secondArr[i] = int.Parse(secondLine[i]);
            }
            Polynomials(firstArr, secondArr);
        }
    }
}

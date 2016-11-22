using System;
using System.Collections.Generic;

namespace Number_as_array
{
    class Program
    {
        static void SumOfEachArrayIndex(int[] firstArray, int[] secondArray)
        {
            int maxLen = 0;
            int addLen = 0;

            string output = "";
            int sum = 0;
            int temp = 0;

            List<int> firstList = new List<int>(firstArray);
            List<int> secondList = new List<int>(secondArray);


            if (firstArray.Length == secondArray.Length)
            {
                maxLen = firstArray.Length;
            }
            else if (firstArray.Length > secondArray.Length)
            {
                maxLen = Math.Max(firstArray.Length, secondArray.Length);
                addLen = firstArray.Length - secondArray.Length;
                int[] range = new int[addLen];
                secondList.AddRange(range);
            }
            else if (secondArray.Length > firstArray.Length)
            {
                maxLen = Math.Max(firstArray.Length, secondArray.Length);
                addLen = secondArray.Length - firstArray.Length;
                int[] range = new int[addLen];
                firstList.AddRange(range);
            }

            for (int i = 0; i < maxLen; i++)
            {
                sum = firstList[i] + secondList[i] + temp;
                temp = sum / 10;
                output += (sum % 10) + " ";
            }

            Console.WriteLine(output);

        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int firstLen = int.Parse(input[0]);
            int secondLen = int.Parse(input[1]);

            int[] firstArr = new int[firstLen];
            int[] secondArr = new int[secondLen];

            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');

            for (int i = 0; i < firstLen; i++)
            {
                firstArr[i] = int.Parse(firstLine[i]);
            }
            for (int i = 0; i < secondLen; i++)
            {
                secondArr[i] = int.Parse(secondLine[i]);
            }
            SumOfEachArrayIndex(firstArr, secondArr);

        }
    }
}

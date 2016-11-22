﻿using System;
using System.Linq;

namespace Maximal_sum
{
    class Program
    {
        static void Main()
        {

            int[] nAm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nAm[0];
            int m = nAm[1];
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                int[] currentLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int i = 0; i < currentLine.Length; i++)
                {
                    matrix[row, i] = currentLine[i];
                }
            }


            int maxSum = int.MinValue;
            int currentSum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    currentSum = matrix[row, col]
                                + matrix[row, col + 1]
                                + matrix[row, col + 2]
                                + matrix[row + 1, col]
                                + matrix[row + 1, col + 1]
                                + matrix[row + 1, col + 2]
                                + matrix[row + 2, col]
                                + matrix[row + 2, col + 1]
                                + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                    currentSum = 0;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTestTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] rowArr = new int[n * n];
            int[] colArr = new int[n * n];

            int rows = n;
            int cols = n;
            int element = 1;


            int[,] matrix = new int[rows, cols];

            int iRow = 0;
            int iCol = 0;

            for (int i = 0; i < n; i++)
            {
                rowArr[iRow] = i;
                iRow++;

            }
            for (int i = 0; i < n - 1; i++)
            {
                rowArr[iRow] = n - 1;
                iRow++;

            }

            for (int i = ((n * n) / (n * 2)); i > 0; i--)
            {
                rowArr[iRow] = i;
                iRow++;
            }

            for (int i = 0; i < n-1; i++)
            {
                rowArr[iRow] = n -n;
                iRow++;
            }

            for (int i = 1; i <= ((n * n) / (n * 2)); i++)
            {
                rowArr[iRow] = i;
                iRow++;
            }
            for (int i = ((n * n) / (n * 2)); i > 0; i--)
            {
                rowArr[iRow] = i;
                iRow++;
            }


            for (int i = 0; i < n; i++)
            {
                colArr[iCol] = n - n;
                iCol++;
            }


            for (int i = 1; i <= n - 1; i++)
            {
                colArr[iCol] = i;
                iCol++;
            }

            for (int i = 0; i < n - 1; i++)
            {
                colArr[iCol] = n - 1;
                iCol++;

            }

            for (int i = ((n * n) / (n * 2)); i > 0; i--)
            {
                colArr[iCol] = i;
                iCol++;
            }

            for (int i = 1; i < n -1; i++)
            {
                for (int j = 1; j < n-1; j++)
                {
                    colArr[iCol] = i;
                    iCol++;
                }
            }

            int rowws = 0;
            int colls = 0;

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[rowArr[rowws], colArr[colls]] = element;
                    element++;
                    rowws++;
                    colls++;
                }

            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

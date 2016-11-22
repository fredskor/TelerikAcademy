using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
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

            // rows
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
        
            for (int i = ((n * n) / (n * 2)); i >= 0; i--)
            {
                rowArr[iRow] = i;
                iRow++;
            }
      
            for (int i = 0; i < ((n * n) / (n * 2)); i++)
            {
                for (int j = 0; j < ((n * n) / (n * 2)); j++)
                {
                    rowArr[iRow] = i;
                    iRow++;
                }
            }

            for (int i = ((n * n) / (n * 2)); i >= 1; i--)
            {
                rowArr[iRow] = i;
                iRow++;
            }



            // cols
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
            for (int i = 1; i <= ((n * n) / (n * 2)); i++)
            {
                colArr[iCol] = i;
                iCol++;
            }

            for (int i = 0; i < ((n * n) / (n * 2)); i++)
            {
                colArr[iCol] =((n * n) / (n * 2));
                iCol++;
            }

            foreach (var item in rowArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in colArr)
            {
                Console.WriteLine(item);
            }

            //int roww = 0;
            //int coll = 0;

            //for (int col = 0; col < cols; col++)
            //{
            //    for (int row = 0; row < rows; row++)
            //    {
            //        matrix[rowArr[roww], colArr[coll]] = element;
            //        element++;
            //        roww++;
            //        coll++;
            //    }

            //}

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
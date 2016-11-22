using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char s = char.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            int element = 1;
            int[] arrRows = new int[n * n];
            int[] arrCols = new int[n * n];

            int[,]matrix = new int[rows,cols];

            // s == 'a'
            if (s == 'a')
            {
                for (int col = 0; col < cols; col++)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        matrix[row, col] = element;
                        element++;
                    }

                }

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(matrix[row, col]);
                        if (col != matrix.GetLength(0) - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

            }

            if (s == 'b')
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < rows; row++)
                        {
                            matrix[row, col] = element;
                            element++;
                        }
                    }
                    else

                        for (int row = rows - 1; row >= 0; row--)
                        {
                            matrix[row, col] = element;
                            element++;
                        }

                }

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(matrix[row, col]);
                        if (col != matrix.GetLength(0) - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

                for (int col = 0; col < cols; col++)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        matrix[row, col] = element;
                        element++;
                    }
                }
                // s == 'b'
            }

                // s == 'c'
                if (s == 'c')
                {
                    int num = n - 1;
                    int max = n - 1;
                    int index = 0;

                    int numC = 1;
                    int maxC = n - 1;
                    int indexC = 0;

                    for (int i = n - 1; i >= 0; i--)
                    {
                        for (int j = n - 1; j >= max; j--)
                        {
                            arrRows[index] = num;
                            num++;
                            index++;
                        }

                        num = i - 1;
                        max--;
                    }

                    for (int i = n - 1; i >= 0; i--)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            arrRows[index] = j;
                            index++;
                        }

                    }



                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            arrCols[indexC] = j;
                            indexC++;
                        }

                    }

                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= maxC; j++)
                        {
                            arrCols[indexC] = numC;
                            numC++;
                            indexC++;
                        }

                        numC = i + 1;
                        maxC--;
                    }


                    int roww = 0;
                    int coll = 0;

                    for (int col = 0; col < cols; col++)
                    {
                        for (int row = 0; row < rows; row++)
                        {
                            matrix[arrRows[roww], arrCols[coll]] = element;
                            element++;
                            roww++;
                            coll++;
                        }

                    }

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(matrix[row, col]);
                        if (col != matrix.GetLength(0) - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }


                //s == d
                if (s == 'd')
                {
                    int[] rowArr = new int[n * n];
                    int[] colArr = new int[n * n];


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

                    for (int i = 0; i < n - 1; i++)
                    {
                        rowArr[iRow] = n - n;
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

                    for (int i = 1; i < n - 1; i++)
                    {
                        for (int j = 1; j < n - 1; j++)
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
                            Console.Write(matrix[row, col]);
                        if (col != matrix.GetLength(0) - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                        Console.WriteLine();
                    }
                }
            }

        }
    }


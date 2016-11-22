using System;

namespace Sequence_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] Sizes = n.Trim(' ').Split(' ');

            int rows = int.Parse(Sizes[0]);
            int cols = int.Parse(Sizes[1]);

            string[][] arr = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                arr[i] = Console.ReadLine().Trim(' ').Split(' ');
            }

            int maxSeq = 0;
            int current = 1;

            for (int row = 0; row < rows; row++)
            {
                current = 1;

                for (int col = 1; col < cols; col++)
                {
                    if (arr[row][col] == arr[row][col - 1])
                    {
                        current++;
                    }
                    else
                    {

                        if (current > maxSeq)
                        {
                            maxSeq = current;
                        }

                        current = 1;
                    }
                }

                if (current > maxSeq)
                {
                    maxSeq = current;
                }
            }


            for (int col = 0; col < cols; col++)
            {
                current = 1;

                for (int row = 1; row < rows; row++)
                {
                    if (arr[row][col] == arr[row - 1][col])
                    {
                        current++;
                    }
                    else
                    {

                        if (current > maxSeq)
                        {
                            maxSeq = current;
                        }
                        current = 1;
                    }
                }

                if (current > maxSeq)
                {
                    maxSeq = current;
                }
            }

            for (int Col = 1; Col < cols; Col++)
            {
                current = 1;

                for (int curMod = 1; curMod <= Math.Min(Col, rows - 1); curMod++)
                {
                    if (arr[0 + curMod][Col - curMod] == arr[0 + (curMod - 1)][Col - (curMod - 1)])
                    {
                        current++;
                    }
                }

                if (current > maxSeq)
                {
                    maxSeq = current;
                }
            }

            for (int Row = 1; Row < rows; Row++)
            {
                current = 1;

                for (int curMod = 1; curMod <= Math.Min(rows - 1 - Row - 1, cols - 2); curMod++)
                {
                    if (arr[Row + curMod][(cols - 1) - curMod] == arr[Row + (curMod + 1)][(cols - 1) - (curMod + 1)])
                    {
                        current++;
                    }
                }

                if (current > maxSeq)
                {
                    maxSeq = current;
                }
            }

            for (int Row = rows - 2;
                     Row >= 0;
                     Row--)
            {
                current = 1;

                for (int curMod = 1;
                    curMod <= Math.Min(rows - Row - 1, cols - 1);
                    curMod++)
                {
                    if (arr[Row + curMod][0 + curMod] ==
                        arr[Row + (curMod - 1)][0 + (curMod - 1)])
                    {
                        current++;
                    }
                }

                if (current > maxSeq)
                {
                    maxSeq = current;
                }
            }

            for (int Row = 1;
                     Row < rows - 1;
                     Row++)
            {
                current = 1;

                for (int curMod = 1; curMod <= Math.Min(Row - 1, cols - 1); curMod++)
                {
                    if (arr[Row - curMod][(cols - 1) - curMod] ==
                        arr[Row - (curMod - 1)][(cols - 1) - (curMod - 1)])
                    {
                        current++;
                    }
                }

                if (current > maxSeq)
                {
                    maxSeq = current;
                }
            }
            Console.WriteLine(maxSeq);
        }
    }
}

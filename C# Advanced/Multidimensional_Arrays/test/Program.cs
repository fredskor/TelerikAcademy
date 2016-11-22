using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

          public static void PrintTheMatrix(short[,] toPrint)
        {
            for (int row = 0; row < toPrint.GetLength(1); row++)
            {
                for (int col = 0; col < toPrint.GetLength(0); col++)
                {
                    Console.Write(toPrint[col, row]);

                    if (col != toPrint.GetLength(0) - 1)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
}

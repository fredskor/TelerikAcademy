using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_a_Sequence
{
    class Program
    {
        static void Main()
        {
            int numberToPrint;
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    numberToPrint = i;
                }
                else
                {
                    numberToPrint = i * (-1);
                }
                Console.WriteLine(numberToPrint);
            }
        }
    }
}
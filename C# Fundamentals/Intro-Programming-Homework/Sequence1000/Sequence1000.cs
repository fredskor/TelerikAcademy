﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToPrint;
            for (int i = 2; i <= 1001; i++)
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

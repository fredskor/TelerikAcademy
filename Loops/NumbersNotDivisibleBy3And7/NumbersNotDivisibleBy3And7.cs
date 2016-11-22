using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if ((i % 7 == 0) || (i % 3 == 0))
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

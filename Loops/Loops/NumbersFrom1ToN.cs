using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Output: ");
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

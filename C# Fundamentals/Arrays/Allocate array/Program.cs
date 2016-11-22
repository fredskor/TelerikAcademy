using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allocate_array
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            for (long i = 0; i < n; i++)
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}

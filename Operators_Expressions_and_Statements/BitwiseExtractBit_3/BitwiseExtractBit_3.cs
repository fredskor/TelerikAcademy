using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseExtractBit_3
{
    class BitwiseExtractBit_3
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int p = 2;
            int nP = n >> p;
            int bit = nP & 1;
            Console.WriteLine(bit);
        }
    }
}

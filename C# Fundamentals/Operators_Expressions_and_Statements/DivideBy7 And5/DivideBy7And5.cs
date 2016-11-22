using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());
            bool num7 = (number % 7) == 0;
            bool num5 = (number % 5) == 0;
            if (number == 0)
            {
                num7 = false;
            }
            Console.WriteLine("Divided by 7 and 5 in the same time? {0}", num7 && num5);
        }
    }
}

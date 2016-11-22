using System;
using System.Linq;

namespace Hexadecimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexstring = Console.ReadLine();
            string binarystring = String.Join(String.Empty, hexstring.Select(
            c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
            Console.WriteLine(binarystring.TrimStart(new Char[] { '0'}));
        }
    }
}

using System;

namespace Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            char[] aArr = a.ToCharArray();
            char[] bArr = b.ToCharArray();
            bool equalCheck = false;

            if (aArr.Length == bArr.Length)
            {
                for (int i = 0; i < aArr.Length; i++)
                {
                    if (aArr[i] > bArr[i])
                    {
                        Console.WriteLine(">");
                        equalCheck = true;
                        break;
                    }
                    else if (aArr[i] < bArr[i])
                    {
                        Console.WriteLine("<");
                        equalCheck = true;
                        break;
                    }
                }
                if (equalCheck == false)
                {
                    Console.WriteLine("=");
                }

            }
            else if (aArr.Length > bArr.Length)
            {
                Console.WriteLine(">");
            }
            else if (aArr.Length < bArr.Length)
            {
                Console.WriteLine("<");
            }
        }
    }
}

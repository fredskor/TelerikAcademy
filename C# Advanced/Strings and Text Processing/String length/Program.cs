using System;
using System.Collections.Generic;
using System.Linq;


namespace String_length
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            List<String> list = new List<string>();
            list = s.Select(c => c.ToString()).ToList();

            while (list.Count < 20) list.Add("*");
            list.ForEach(Console.Write);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_URL
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] delimiters = new char[] { ':', '/' };
            string[] arr = input.Split(delimiters);

            var protocol = arr[0];
            var server = arr[3];
            //var resource = "/";
            var resource = new StringBuilder();
            resource.Append("/");

            for (int i = 4; i < arr.Length; i++)
            {
                resource.Append(arr[i] + "/");
            }
            resource.Remove(resource.Length - 1, 1);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}

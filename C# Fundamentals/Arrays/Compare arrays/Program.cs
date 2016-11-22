using System;

namespace Compare_arrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            bool ifEquel = true;

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            while (counter < n)
            {
                int input = int.Parse(Console.ReadLine());
                firstArr[counter] = input;
                counter++;

            }
            counter = 0;
            while (counter < n)
            {

                int input = int.Parse(Console.ReadLine());

                secondArr[counter] = input;
                counter++;

            }

            for (int i = 0; i < n; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    ifEquel = false;
                }
            }

            if (ifEquel == true)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }

    }
}

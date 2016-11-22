using System;


namespace Sum_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMuch = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= howMuch; i++)
            {
                double n = double.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine(sum);

        }
    }
}

using System;

class ComparingFloats
{
   
    static void Main()
    {

        double lineA = double.Parse(Console.ReadLine());
        double lineB = double.Parse(Console.ReadLine());
        CompareNumbers((decimal)lineA, (decimal)lineB);
        
    }
  
    private static void CompareNumbers(decimal numberA, decimal numberB)
    {
       
        if (Math.Abs(numberA - numberB) < 0.000001m)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
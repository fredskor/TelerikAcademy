using System;
using System.Linq;
using System.Numerics;


class OneSystemToAnyOther
{
    static void Main()
    {

        BigInteger baseX = BigInteger.Parse(Console.ReadLine());
        if (baseX < 2) throw new ArgumentOutOfRangeException();

        string number = StringParse();

        BigInteger baseY = BigInteger.Parse(Console.ReadLine());
        if (baseY < 2 || baseY > 16) throw new ArgumentOutOfRangeException();

        string result = ConvertFromDecimalToBaseY(ConvertToDecimal(number.ToArray(), baseX), baseY);
        Console.WriteLine(result.ToUpper());

    }

    static string StringParse()
    {
        string number = Console.ReadLine();


        if (number.Any(t => t < 'A' && t > 'Z' && t < 'a' && t > 'z' && t < '0' && t > '9'))
        {
            throw new ArgumentException();
        }

        number = MakeAllLettersLarge(number);

        return number;
    }


    static string MakeAllLettersLarge(string number)
    {
        char[] digits = number.ToArray();

        for (int i = 0; i < digits.Length; i++)
            digits[i] = char.ToUpper(number[i]);

        return string.Join("", digits);
    }



    static BigInteger ConvertToDecimal(char[] number, BigInteger baseX)
    {
        BigInteger result = 0;
        BigInteger pow = 1;

        for (int i = number.Length - 1; i >= 0; i--, pow *= baseX)
            result += (number[i] >= 'A') ? (number[i] - 'A' + 10) * pow : (number[i] - '0') * pow;

        return result;
    }


    static string ConvertFromDecimalToBaseY(BigInteger number, BigInteger baseY)
    {
        string result = string.Empty;

        while (number > 0)
        {
            BigInteger remainder = number % baseY;

            result = remainder >= 10 ? (char)('A' + remainder - 10) + result : remainder + result;

            number /= baseY;
        }

        return result;
    }


    static bool IsValidInput(string number, string result, BigInteger baseX, BigInteger baseY)
    {
        return String.CompareOrdinal(ConvertFromDecimalToBaseY(ConvertToDecimal(result.ToArray(), baseY), baseX), number) == 0;
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace Prog1;

public static class B2I
{
    public static int BiToInt(int n)
    {
        int i;
        int res = 0, base1 = 1;
        for (i = n; i > 0; i = i / 10)
        {
            int lastDigit = i % 10;
            res += lastDigit * base1;
            base1 *= 2;
        }
        return res;
    }
    public static void Main()
    {
        Console.WriteLine("Enter the Binary Number: ");
        string numS = Console.ReadLine();
        int num = Int32.Parse(numS);

        int dec = BiToInt(num);
        Console.WriteLine("The decimal value is " + dec);
    }
}


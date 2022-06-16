using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        List<long> list = new List<long>();
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            var n = (long)(Convert.ToInt32(Console.ReadLine()));
            list.Add(n);
        }

        foreach (long number in list)
        {
            long three = (number - 1) / 3;
            long five = (number - 1) / 5;
            long fifteen = (number - 1) / 15;

            long num1 = 3 * (three * (three + 1) / 2);
            long num2 = 5 * (five * (five + 1) / 2);
            long num3 = 15 * (fifteen * (fifteen + 1) / 2);

            Console.WriteLine(num1 + num2 - num3);
        }
    }

}

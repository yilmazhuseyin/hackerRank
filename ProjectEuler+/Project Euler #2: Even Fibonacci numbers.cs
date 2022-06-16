using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        List<long> list = new List<long>();
        for (int a0 = 0; a0 < t; a0++)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            list.Add(n);
        }

        foreach (var num in list)
        {
            long f1 = 0;
            long f2 = 1;
            long sum = 0;
            while (f1 + f2 < num)
            {
                if ((f1 + f2) % 2 == 0) sum += f1 + f2;
                long temp = f2;
                f2 = f1 + f2;
                f1 = temp;
            }
            Console.WriteLine(sum);
        }
        
    }
}

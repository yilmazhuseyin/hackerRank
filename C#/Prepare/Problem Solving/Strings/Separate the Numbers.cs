using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'separateNumbers' function below.
     *
     * The function accepts STRING s as parameter.
     */

    public static void separateNumbers(string s)
    {
         if (s.Length == 1 || Convert.ToInt64(s.ElementAt(0)) == 0)
        {
            Console.WriteLine("NO");
            return;
        }

        long num = 0;
        bool mark = false;

        char[] arr = s.ToCharArray();

        for (int i = 1; i <= arr.Length / 2; i++)
        {
            String first = s.Substring(0, i);
            long temp = Convert.ToInt64(first);
            num = temp;

            String k = Convert.ToString(num);
            while (k.Length < s.Length)
            {
                k += Convert.ToString(++temp);
            }

            if (k.Equals(s))
            {
                mark = true;
                break;
            }
        }

        if (mark == true)
            Console.WriteLine("YES " + num);
        else
            Console.WriteLine("NO");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            Result.separateNumbers(s);
        }
    }
}

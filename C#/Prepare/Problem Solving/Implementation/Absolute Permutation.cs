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
     * Complete the 'absolutePermutation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     */

    public static List<int> absolutePermutation(int n, int k)
    {
         List<int> result = new List<int>();
        if (k != 0)
        {
            if (n % 2 == 1) return new List<int>() { -1};

            if (n % 2 == 0 && n % (k * 2) == 0)
            {
                int j = 1;
                for (int i = 1; i <= n; i++)
                {
                    if (j <= k)
                    {
                        result.Add(i + k);
                    }
                    else
                    {
                        result.Add(i - k);
                    }

                    j++;
                    if (j > k * 2) j = 1;
                }
                return result;
            }
            else
            {
                return new List<int>() { -1 };
            }
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                result.Add(i);
            }
            return result;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> result = Result.absolutePermutation(n, k);

            textWriter.WriteLine(String.Join(" ", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

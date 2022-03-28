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
     * Complete the 'fairRations' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY B as parameter.
     */

    public static string fairRations(List<int> B)
    {
        var result = 0;

        if (B.Count % 2 == 0)
        {
            foreach (var item in B)
            {
                if (item % 2 == 0)
                    result++;
            }

            if (result == B.Count / 2)
            {
                return "NO";
            }
        }
        else if (result == B.Count)
            return "NO";

        result = 0;
        for (int i = B.Count - 1; i >= 0; i--)
        {
            if (B[i] % 2 != 0)
            {
                if (i + 1 > B.Count - 1)
                {
                    B[i]++;
                    B[i - 1]++;
                    result += 2;
                }else if(i - 1 < 0)
                {
                    B[i]++;
                    B[i + 1]++;
                    result += 2;
                }
                else
                {
                    B[i]++;
                    if (B[i + 1] % 2 == 0)
                        B[i - 1]++;
                    else
                        B[i + 1]++;

                    result += 2;
                }

            }
        }
        var final = 0;
        foreach (var item in B)
        {
            if (item % 2 == 0)
                final++;
        }
        if (final == B.Count)
            return result.ToString();
        else
            return "NO";
        
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int N = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

        string result = Result.fairRations(B);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

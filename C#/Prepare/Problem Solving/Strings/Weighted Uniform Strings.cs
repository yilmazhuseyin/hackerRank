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
     * Complete the 'weightedUniformStrings' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER_ARRAY queries
     */

    public static List<string> weightedUniformStrings(string s, List<int> queries)
    {
        List<int> weights = new List<int>();
        int sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i != 0 && s[i - 1] != s[i] )
                sum = 0;

            sum += (int)s[i] - 97 + 1;
            weights.Add(sum);
        }

        List<string> result = new List<string>();

        foreach (var item in queries)
        {
            if (weights.IndexOf(item) != -1)
                result.Add("Yes");
            else
                result.Add("No");
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> queries = new List<int>();

        for (int i = 0; i < queriesCount; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
            queries.Add(queriesItem);
        }

        List<string> result = Result.weightedUniformStrings(s, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

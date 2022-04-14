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
     * Complete the 'funnyString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string funnyString(string s)
    {
        var arr = s.ToCharArray();
        var arr2 = arr.Reverse().ToArray();
        var count3 = 0;

        var count = new List<int>();
        var count2 = new List<int>();

        for (int i = 0; i < arr.Length - 1; i++)
            count.Add(Math.Abs((int)arr[i] - (int)arr[i+1]));

        for (int i = 0; i < arr.Length - 1; i++)
            count2.Add(Math.Abs((int)arr2[i] - (int)arr2[i + 1]));

        for (int i = 0; i < count.Count; i++)
        {
            if (count[i] - count2[i] != 0)
                count3++;

            if (count3 > 0) break;
        }

        return (count3 == 0 ? "Funny" :  "Not Funny");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            string result = Result.funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

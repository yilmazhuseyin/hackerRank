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
     * Complete the 'encryption' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string encryption(string s)
    {
        string trimmed = s.Replace(" ", "");

        List<string> result = new List<string>();

        double ceiling = Math.Ceiling(Math.Sqrt(trimmed.Length));
        double floor = ceiling - 1;

        while (trimmed.Length > 0)
        {
            string word = "";

            for (int i = 0; i < ceiling; i++)
            {
                if(i < trimmed.Length)
                    word += trimmed[i];
            }

            result.Add(word);

            if ((int)ceiling < trimmed.Length)
                trimmed = trimmed.Remove(0, (int)ceiling);

            if (result.Sum(x=>x.Length) == s.Length)
                break;
        }

        List<string> result2 = new List<string>();
        

        var maxLengt = result.OrderByDescending(x => x.Length).First().Length;
        int k = 0;
        while (k < maxLengt)
        {
            string word2 = "";
            foreach (var item in result)
            {
                if (k < item.Length)
                    word2 += item[k];
            }

            result2.Add(word2);
            k++;
        }

        return String.Join(" ", result2);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.encryption(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

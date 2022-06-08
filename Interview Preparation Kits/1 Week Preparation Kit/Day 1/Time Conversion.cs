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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        if (s.ElementAt(s.Length - 2) == 'A')
        {
            if (s.ElementAt(0) == '1' && s.ElementAt(1) == '2')
                return $"00:{s.ElementAt(3)}{s.ElementAt(4)}:{s.ElementAt(6)}{s.ElementAt(7)}";
            else
                return $"{s.ElementAt(0)}{s.ElementAt(1)}:{s.ElementAt(3)}{s.ElementAt(4)}:{s.ElementAt(6)}{s.ElementAt(7)}";
        }else
        {
            if (s.ElementAt(0) == '1' && s.ElementAt(1) == '2')
                return $"12:{s.ElementAt(3)}{s.ElementAt(4)}:{s.ElementAt(6)}{s.ElementAt(7)}";
            else
            {
                int time = Convert.ToInt32($"{s.ElementAt(0)}" + $"{s.ElementAt(1)}");
                return $"{time + 12}:{s.ElementAt(3)}{s.ElementAt(4)}:{s.ElementAt(6)}{s.ElementAt(7)}";
            }
               
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

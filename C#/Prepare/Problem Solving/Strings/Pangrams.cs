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
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        var count = 0;
        var stringList = new List<string>();
        var stringList2 = new List<string>();

        foreach (var item in s)
        {
            stringList.Add(Char.ToString(item).ToLower());
        }       
        foreach (var letter in stringList)
        {
            if (!stringList2.Contains(letter))
            {
                stringList2.Add(letter);
                if ((int)(Convert.ToChar(letter)) >= 97 && (int)(Convert.ToChar(letter)) <= 122)
                    count++;
            }
        }

        return count == 26 ? "pangram" : "not pangram";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

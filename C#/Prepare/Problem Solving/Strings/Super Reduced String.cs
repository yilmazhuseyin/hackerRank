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
     * Complete the 'superReducedString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string superReducedString(string s)
    {
        StringBuilder stringBuilder = new StringBuilder(s);
        int x = 0;
        while (x < stringBuilder.Length - 1)
        {
            if (stringBuilder[x] == stringBuilder[x + 1])
            {
                stringBuilder.Remove(x, 2);
                if (x > 0)
                    x--;
            }
            else x++;
        }
        if (stringBuilder.Length > 0)
            return stringBuilder.ToString();
        else
            return "Empty String";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.superReducedString(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

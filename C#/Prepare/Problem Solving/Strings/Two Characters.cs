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
     * Complete the 'alternate' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int alternate(string s)
    {
        char[] distinct = s.Distinct().ToArray();
        string tempStr = s;
        char tempChar = '\0';
        int iteration = 0;
        List<int> matches = new List<int>();

        foreach (var i in distinct)
        {
            foreach (var j in distinct)
            {
                if ((s.Count(x => x == i) == s.Count(x => x == j) || Math.Abs(s.Count(x => x == i) - s.Count(x => x == j)) == 1) && i != j) 
                {
                    tempStr = s; 
                    tempStr = Regex.Replace(tempStr,$"[^{i}{j}]", string.Empty, RegexOptions.IgnoreCase);
                    iteration = 0;
                    tempChar = '\0';
                    foreach (var m in tempStr) 
                    {                          
                        if (tempChar != m)
                        {
                            tempChar = m;
                            iteration++;
                            if (iteration == tempStr.Length)
                            {                                
                                matches.Add(tempStr.Length); 
                            }
                        }
                    }
                }
            }
        }

        return matches.Count() == 0 ? 0 : matches.Max();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int result = Result.alternate(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

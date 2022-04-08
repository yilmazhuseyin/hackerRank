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
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int marsExploration(string s)
    {
        var count = 0;
        List<char> slist = new List<char>();
        foreach (var item in s)
        {
            slist.Add(item);
        }
     
        for (int i = 0; i < slist.Count; i+=3)
        {
            if(i<slist.Count)
            if ((int)slist[i] != 83)
                count++;
        }

        for (int i = 1; i < slist.Count; i += 3)
        {
            if (i < slist.Count)
                if ((int)slist[i] != 79)
                    count++;
        }

        for (int i = 2; i < slist.Count; i += 3)
        {
            if (i < slist.Count)
                if ((int)slist[i] != 83)
                    count++;
        }

        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

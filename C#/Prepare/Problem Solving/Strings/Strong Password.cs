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
     * Complete the 'minimumNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING password
     */

    public static int minimumNumber(int n, string password)
    {
        var count = 0;
        var count1 = "";
        var count2 = "";
        var count3 = "";
        var count4 = "";
        List<string> yes = new List<string>();
        foreach (char letter  in password)
        {
            if ((int)(letter) >= 48 && (int)(letter) <= 57)
                count1 = "yes";
            else if ((int)(letter) >= 97 && (int)(letter) <= 122)
                count2 = "yes";
            else if ((int)(letter) >= 65 && (int)(letter) <= 90)
                count3 = "yes";
            else if ((int)(letter) >= 33 && (int)(letter) <= 47)
                count4 = "yes";
        }
        yes.Add(count1);
        yes.Add(count2);
        yes.Add(count3);
        yes.Add(count4);

        foreach (var item in yes)
        {
            if (item == "yes")
                count++;
        }

        return Math.Max(6 - n, 4 - count);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}

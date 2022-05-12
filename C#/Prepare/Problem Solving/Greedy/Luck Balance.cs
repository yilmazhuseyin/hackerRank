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
     * Complete the 'luckBalance' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. 2D_INTEGER_ARRAY contests
     */

    public static int luckBalance(int k, List<List<int>> contests)
    {
        List<int> important = new List<int>();
        List<int> notImportant = new List<int>();
        List<int> orderedList = new List<int>();
        int total = 0;

        foreach (var item in contests)
        {
            if (item[1] == 1)
                important.Add(item[0]);
            else 
                notImportant.Add(item[0]);
        }

        orderedList = important.OrderByDescending(a => a).ToList();

        for (int i = k; i < orderedList.Count; i++)
            orderedList[i] = orderedList[i] * -1;
        
        foreach (var item in orderedList)
            total += item;

        for (int i = 0; i < notImportant.Count; i++)
            total += notImportant[i];
        return total;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> contests = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            contests.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(contestsTemp => Convert.ToInt32(contestsTemp)).ToList());
        }

        int result = Result.luckBalance(k, contests);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

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
     * Complete the 'countSort' function below.
     *
     * The function accepts 2D_STRING_ARRAY arr as parameter.
     */

    public static void countSort(List<List<string>> arr)
    {
        var sl = new SortedList<int, StringBuilder>();
        for (var i = 0; i < arr.Count(); i++)
        {
            var key = int.Parse(arr[i][0]);
            if (!sl.ContainsKey(key))
            {
                sl.Add(key, new StringBuilder());
            }
            if (i < arr.Count / 2)
            {
                sl[key].Append("- ");
            }
            else
            {
                sl[key].Append($"{arr[i][1]} ");
            }
        }
        var sb = new StringBuilder();
        foreach (var kvp in sl)
        {
            sb.Append(kvp.Value);
        }
        Console.WriteLine($"{sb.ToString()} ");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> arr = new List<List<string>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        Result.countSort(arr);
    }
}

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
     * Complete the 'serviceLane' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY cases
     */

    public static List<int> serviceLane(List<int> width, List<List<int>> cases)  //I changed 'int n' to 'List<int> width'
    {
        var minList = new List<int>();
        foreach (var twoNum in cases)
        {
            var first = twoNum[0];
            var second = twoNum[1];
            var list = new List<int>();
            for (int i = first; i <= second; i++)
            {
                list.Add(width[i]);
            }
            minList.Add(list.Min());
        }
        return minList;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        List<int> width = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(widthTemp => Convert.ToInt32(widthTemp)).ToList();

        List<List<int>> cases = new List<List<int>>();

        for (int i = 0; i < t; i++)
        {
            cases.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(casesTemp => Convert.ToInt32(casesTemp)).ToList());
        }

        List<int> result = Result.serviceLane(width, cases); //I changed 'n' to 'width'

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

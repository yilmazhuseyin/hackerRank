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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double cP = 0;
        double cN = 0;
        double cZ = 0;

        foreach (var item in arr)
        {
            if (item > 0) cP++;
            if (item < 0) cN++;
            if (item == 0) cZ++;
        }

        Console.WriteLine(String.Format("{0:0.000000}", cP / arr.Count));
        Console.WriteLine(String.Format("{0:0.000000}", cN / arr.Count));
        Console.WriteLine(String.Format("{0:0.000000}", cZ / arr.Count));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

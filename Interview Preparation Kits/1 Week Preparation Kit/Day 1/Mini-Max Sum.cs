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
using System.Numerics;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        BigInteger minSum = 0;
        BigInteger maxSum = 0;

        List<BigInteger> maxSumList = new List<BigInteger>();
        List<BigInteger> minSumList = new List<BigInteger>();

        foreach (BigInteger item in arr.OrderByDescending(x => x).Take(arr.Count - 1).ToList())
            maxSumList.Add(item);

        foreach (BigInteger item in arr.OrderBy(x => x).Take(arr.Count - 1).ToList())
            minSumList.Add(item);

        foreach (var item in maxSumList)
            maxSum += item;

        foreach (var item in minSumList)
            minSum += item;

        Console.WriteLine(minSum + " " + maxSum);
       
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}

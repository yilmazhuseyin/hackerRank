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
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int findMedian(List<int> arr)
    {
        List<int> sorted = new List<int>();
        sorted = arr.OrderBy(x => x).ToList();

        return sorted[(sorted.Count / 2)];
    }

}

class Solution
{
    public static void Main(string[] args)
    {



        List<int> arr = new List<int>() { 0, 1, 2, 4, 6, 5, 3 };

        int result = Result.findMedian(arr);

        Console.WriteLine(result);

        Console.ReadLine();
    }
}

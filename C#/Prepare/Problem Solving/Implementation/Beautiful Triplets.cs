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
     * Complete the 'beautifulTriplets' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static int beautifulTriplets(int d, List<int> arr)
    {
        var count = 0;
        foreach (var number in arr)
        {
            if(arr.Any(x=>x == number + d) && arr.Any(x => x == number + (2*d)))
            {
                count++;
            }
        }

        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {


        int d = 1;

        List<int> arr = new List<int>(){2,2,3,4,5};

        int result = Result.beautifulTriplets(d, arr);

        Console.WriteLine(result);

        Console.ReadLine();
    }
}

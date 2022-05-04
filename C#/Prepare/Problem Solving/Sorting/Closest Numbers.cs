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
     * Complete the 'closestNumbers' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> closestNumbers(List<int> arr)
    {
        var sortedList = arr.OrderBy(x => x).ToList();
        List<int> dif = new List<int>();
        List<int> resultList = new List<int>();
        int j = 1;
        for (int i = 0; i < sortedList.Count; i++)
        {
            if (j <= sortedList.Count - 1)
            {
                dif.Add(Math.Abs(sortedList[i]-sortedList[j]));
            }
            j++;
        }

        var minDif = dif.Min();

        int k = 1;
        for (int i = 0; i < sortedList.Count; i++)
        {
            if (k <= sortedList.Count - 1 && (Math.Abs(sortedList[i] - sortedList[k]) == minDif))
            {
                resultList.Add(sortedList[i]);
                resultList.Add(sortedList[k]);
            }
            k++;
        }

        return resultList;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.closestNumbers(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

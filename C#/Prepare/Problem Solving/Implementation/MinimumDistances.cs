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
     * Complete the 'minimumDistances' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int minimumDistances(List<int> a)
    {
        List<int> matchedNumbers = new List<int>();
        List<int> MinDists = new List<int>();
        foreach (var number in a)
        {
            var count = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (number == a[i])
                    count++;
            }

            if (count > 1)
                matchedNumbers.Add(number);
        }

        matchedNumbers = matchedNumbers.Distinct().ToList();

        foreach (var number in matchedNumbers)
        {
            List<int> distances = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (number == a[i])
                    distances.Add(i);
            }

            while(distances.Count > 2)
            {
                distances.Remove(distances.Max());
            }

            MinDists.Add(distances[1] - distances[0]);
        }

         if (MinDists.Count == 0)
            return -1;
        else
        return MinDists.Min();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

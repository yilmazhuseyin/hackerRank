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
     * Complete the 'almostSorted' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void almostSorted(List<int> arr)
    {
        List<int> sorted = arr.OrderBy(x => x).ToList();
        int count = 0;
        List<int> indexes = new List<int>();
        for (int i = 0; i < sorted.Count(); i++)
        {
            if (arr[i] == sorted[i])
                count++;
            else
                indexes.Add(i);
                
        }
        if (count == sorted.Count) Console.WriteLine("yes");

        if(count == sorted.Count - 2)
        {
            Console.WriteLine($"yes");
            Console.WriteLine($"swap {indexes[0] + 1} {indexes[1] + 1}");
        }
        else
        {
            int startIndex = indexes[0];
            int endIndex = indexes[indexes.Count - 1];
            int secondCount = 0;
            int k = endIndex - 1;
            for (int i = startIndex + 1; i < endIndex; i++)
            {
                if (arr[i] == sorted[k])
                {
                    secondCount++;
                    k--;
                }
                    
            }
            if(secondCount == endIndex - startIndex - 1)
            {
                Console.WriteLine($"yes");
                Console.WriteLine($"reverse {startIndex + 1} {endIndex + 1}");
            }else
                Console.WriteLine("no");
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.almostSorted(arr);
    }
}

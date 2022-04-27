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
     * Complete the 'insertionSort1' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static void insertionSort1(int n, List<int> arr)
    {
        int ourN = arr[n - 1];
        if(ourN < arr[0])
        {
            for (int i = n - 1; i >= 0; i--)
            {
                if (i == 0 && ourN <= arr[0])
                {
                    arr[i] = ourN;
                    Console.WriteLine(String.Join(" ", arr));
                }
                else if (ourN <= arr[i - 1])
                {
                    arr[i] = arr[i - 1];
                    Console.WriteLine(String.Join(" ", arr));
                }
                else if ((ourN > arr[i - 1] && ourN < arr[i + 1]))
                {
                    arr[i] = ourN;
                    Console.WriteLine(String.Join(" ", arr));
                }
            }
        }
        else
        {
            for (int i = n - 1; i > 0; i--)
            {
                if (i == 0 && ourN <= arr[0])
                {
                    arr[i] = ourN;
                    Console.WriteLine(String.Join(" ", arr));
                }
                else if (ourN <= arr[i - 1])
                {
                    arr[i] = arr[i - 1];
                    Console.WriteLine(String.Join(" ", arr));
                }
                else if ((ourN > arr[i - 1] && ourN < arr[i + 1]))
                {
                    arr[i] = ourN;
                    Console.WriteLine(String.Join(" ", arr));
                }
            }
        }}

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort1(n, arr);
    }
}

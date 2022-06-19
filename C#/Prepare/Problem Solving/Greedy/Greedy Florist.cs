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

class Solution {
    // note
    // Complete the getMinimumCost function below.
    static int getMinimumCost(int k, int[] c) {

        int n = c.Length;
        int minCost = 0;
        int tempCount = 0;
        int previousPurchases = 0;

        Array.Sort(c);

        if(k >= n){
            for(int i = 0; i < n; i++)
                minCost += c[i];
        }
        else{
            for(int i = n - 1; i >= 0; i--){
                if(tempCount == k){
                    tempCount = 0;
                    previousPurchases++;
                }
                minCost += (previousPurchases + 1) * c[i];
                tempCount++;
            }
        }

        return minCost;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int minimumCost = getMinimumCost(k, c);

        textWriter.WriteLine(minimumCost);

        textWriter.Flush();
        textWriter.Close();
    }
}

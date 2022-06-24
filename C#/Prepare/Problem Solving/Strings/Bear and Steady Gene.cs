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
     * Complete the 'steadyGene' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING gene as parameter.
     */

    public static int steadyGene(string gene)
    {
        int result = gene.Length;
        int left = 0;
        var dictionary = new Dictionary<char, int>
                { { 'A', 0 }, { 'C', 0 }, { 'T', 0 }, { 'G', 0 } };

        foreach (var g in gene) 
            dictionary[g]++;

        for (var right = 0; right < gene.Length; right++)
        {
            dictionary[gene[right]]--;

            while (left < gene.Length && dictionary.All(d => d.Value <= gene.Length / 4))
            {
                result = Math.Min(result, right - left + 1);
                dictionary[gene[left]] += 1;
                left++;
            }
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string gene = Console.ReadLine();

        int result = Result.steadyGene(gene);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

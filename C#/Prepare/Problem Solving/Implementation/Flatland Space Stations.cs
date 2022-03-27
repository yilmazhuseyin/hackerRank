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

    // Complete the flatlandSpaceStations function below.
    static int flatlandSpaceStations(int n, int[] c) {
        
         List<int> distances = new List<int>();

        Array.Sort(c);

    for (var i = 0; i < c.Count() - 1; i++)
        {
            var dist = (Math.Abs(c[i + 1] - c[i]) / 2);

            distances.Add(dist);
    }

        var before = Math.Abs(c[0] - 0);
        var after = Math.Abs(n - c[c.Count() - 1]) - 1;

        distances.Add(before);
        distances.Add(after);
        return distances.Max();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = flatlandSpaceStations(n, c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

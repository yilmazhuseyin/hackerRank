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
     * Complete the 'cavityMap' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static List<string> cavityMap(List<string> grid)
    {
        
         for (int i = 1; i < grid.Count - 1; i++)
        {
            for (int j = 1; j < grid[i].Length - 1; j++)
            {
                int middleUpper = (int)char.GetNumericValue(grid[i - 1][j]);
                int left = (int)char.GetNumericValue(grid[i][j - 1]);
                int right = (int)char.GetNumericValue(grid[i][j + 1]);
                int middleUnder = (int)char.GetNumericValue(grid[i + 1][j]);

                var adjacent = new int[4]
                {
                        middleUpper,
                left,                   right,
                        middleUnder
                };

                if (adjacent.Any(a => a < 0)) continue;


                int ij = (int)char.GetNumericValue(grid[i][j]);

                if (adjacent.All(a => a < ij))
                    grid[i] = grid[i].Remove(j, 1).Insert(j, "X");

            }
        }

        return grid;
    }
    

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> grid = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string gridItem = Console.ReadLine();
            grid.Add(gridItem);
        }

        List<string> result = Result.cavityMap(grid);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

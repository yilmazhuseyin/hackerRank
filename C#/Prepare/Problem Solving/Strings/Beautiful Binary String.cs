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
     * Complete the 'beautifulBinaryString' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING b as parameter.
     */

    public static int beautifulBinaryString(string b)
    {
        var charArr = b.ToCharArray();
        var count = 0;
        for (int i = 0; i < charArr.Length - 2; i++)
        {
            if (charArr[i] == '0' && charArr[i + 1] == '1' && charArr[i + 2] == '0')
            {
                count++;
                i += 2;
            }
        }
        return (count == 0 ? 0 : count);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string b = "0101010";

        int result = Result.beautifulBinaryString(b);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}

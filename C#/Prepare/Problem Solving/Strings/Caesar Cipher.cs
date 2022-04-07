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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        var abc = "abcdefghijklmnopqrstuvwxyz";
        List<char> abcList = new List<char>();
        List<int> uppers = new List<int>();

        foreach (var item in abc)
        {
            abcList.Add(item);
        }
        List<char> lastList = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if ((int)s[i] >= 65 && (int)s[i] <= 90)
                uppers.Add(i);
        }
        var lower = "";
        foreach (var item in s)
        {
            lower += item;
        }

        lower = lower.ToLower();

        foreach (char l in lower)
        {
            var index = abcList.IndexOf(l);
            if (index == -1)
                lastList.Add(l);
            else
            {
                if(index + k > abcList.Count - 1)
                {
                    var m = (index + k) % abcList.Count; 
                    var lastIndex = m;
                    lastList.Add(abcList[lastIndex]);
                }
                else
                    lastList.Add(abcList[index + k]);
            }
        }

        for (int i = 0; i < uppers.Count; i++)
        {
            lastList[uppers[i]] = char.Parse(Char.ToString(lastList[uppers[i]]).ToUpper());
        }

        var resultStr = "";
        foreach (var item in lastList)
        {
            resultStr += item;
        }
        return resultStr;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = "Hello_World!";

        int k = 4;

        string result = Result.caesarCipher(s, k);

        Console.WriteLine(result);

        Console.ReadLine();
    }
}

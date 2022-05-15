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
     * Complete the 'decentNumber' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void decentNumber(int n)
    {
        var res = new StringBuilder();
        while(n%3>0){
            n-=5;
            res.Append("33333");
        }
        if(n < 0){
            Console.WriteLine("-1");
        }else{
            n = n/3;
            var res2 = new StringBuilder();
            while(n>0){
                res2.Append("555");
                n--;
            }
            Console.WriteLine(res2.ToString()+res.ToString());
        }
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.decentNumber(n);
        }
    }
}

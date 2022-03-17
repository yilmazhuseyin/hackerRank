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
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

    public static void kaprekarNumbers(int p, int q)
    {
         var count = 0;
         for (int i = p; i <= q; i++)
        {
            List<char> charPowNumbers = new List<char>();
            List<char> reverseCharPowNumbers = new List<char>();
            List<char> firstNumber = new List<char>();
            List<char> secondNumber = new List<char>();
            var lastFirstNumber = "0";
            var lastSecondNumber = "0";
            var total = 0;

            var digit = 0;
            foreach (var number in i.ToString())
            {
                digit++;
            }

            var pow = Math.Pow(i, 2);

            foreach (var number in pow.ToString())
            {
                charPowNumbers.Add(number);
            }

            reverseCharPowNumbers = charPowNumbers;
            reverseCharPowNumbers.Reverse();

            for (int k = 0; k < digit; k++)
            {
                firstNumber.Add(reverseCharPowNumbers[k]);
            }

            for (int k = digit; k < reverseCharPowNumbers.Count; k++)
            {
                secondNumber.Add(reverseCharPowNumbers[k]);
            }

            firstNumber.Reverse();
            secondNumber.Reverse();

            foreach (var number in firstNumber)
            {
                lastFirstNumber += number;
            }

            foreach (var number in secondNumber)
            {
                lastSecondNumber += number;
            }

            total = Convert.ToInt32(lastFirstNumber) + Convert.ToInt32(lastSecondNumber);

            if (total == i)
            {
                Console.Write(total + " ");
                count++;
            }
        }
           if(count == 0)
            Console.Write("INVALID RANGE");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}

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
     * Complete the 'jimOrders' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts 2D_INTEGER_ARRAY orders as parameter.
     */

    public static List<int> jimOrders(List<List<int>> orders)
    {
        List<int> result = new List<int>();
        Dictionary<int,int> o1 = new Dictionary<int, int>();
        Dictionary<int,int> o2 = new Dictionary<int, int>();
        int sum = 0;
        int index = 1;
        for (int i = 0; i < orders.Count; i++)
        {
            foreach (var item in orders[i])
            {
                sum += item;
            }
            o1.Add(index, sum);
            index++;
            sum = 0;
        }

        o2 = o1.OrderBy(x => x.Value).ToDictionary(x=>x.Key, x=>x.Value);

        foreach (var item in o2.Keys)
        {
            result.Add(item);
        }

        return result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
       
        List<List<int>> orders = new List<List<int>>();

        List<int> list1 = new List<int>() {1,3};
        List<int> list2 = new List<int>() {2,3 };
        List<int> list3 = new List<int>() {3,3 };

        orders.Add(list1);
        orders.Add(list2);
        orders.Add(list3);

        List<int> result = Result.jimOrders(orders);

        Console.WriteLine(String.Join(" ", result));
        Console.ReadLine();
    }
}

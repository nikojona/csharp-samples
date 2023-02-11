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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int numPostives = 0;
        int numNegatives = 0;
        int numZero = 0;
        double f = 0.000000;
        List<double> ans = new List<double>();
        // List<int> arr = new List<int>() { 2, 3, 0, -1, -2, 3 };
        int countArr = arr.Count;
        
        foreach(int value in arr) 
        {
            if (value > 0) {
                numPostives += 1;
            } else if (value < 0) {
                numNegatives += 1;
            } else {
                numZero += 1;
            }
        }
        
        Console.WriteLine("{0:N6}", Decimal.Divide(numPostives, countArr));
        Console.WriteLine("{0:N6}", Decimal.Divide(numNegatives, countArr));
        Console.WriteLine("{0:N6}", Decimal.Divide(numZero, countArr));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

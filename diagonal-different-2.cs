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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int x = 0;
        int y = 0;
        int z = 0;
        List<int> numbers1 = new List<int>();
        List<int> numbers2 = new List<int>();
        
        foreach (var subArr in arr)
        {
            y = 0;
            if (x == 0) 
            {
                z = subArr.Count -1;
            }
          
            foreach (var value in subArr)
            {
                if (x == y) {
                    numbers1.Add(value);
                }
                
                if(z == y) {
                    numbers2.Add(value);
                } 
                y += 1;
            }
            x += 1;
            z -= 1;
        }
        int a = 0;
        int b = 0;
        int c = 0;
        foreach(int number in numbers1) {
          a += number;
        }
        
        foreach(int number in numbers2) {
          b += number;
        }
        
        c = a - b;
        if (c < 0) {
          c = c * (-1);
        }
        return c;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

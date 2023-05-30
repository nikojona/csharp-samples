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
     * Complete the 'longestSubarray' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int longestSubarray(List<int> arr)
    {
        List<int> numbers = new List<int>();
        int n = arr.Count;
        int max = 1;
        int i,j;
        
        for(i = 0; i < n-1; i++){
            numbers.Add(arr[i]);
            
            for(j = i+1; j < n; ){
                if(Math.Abs(arr[i]-arr[j])<2) {
                    if(!numbers.Contains(arr[j])) {
                        if(numbers.Count == 2) {
                            break;
                        } else {
                            numbers.Add(arr[j]);   
                        }
                    }  
                } else {
                    break;    
                }
                j++;                
            }
            max = Math.Max(max,j-i);
            numbers.Clear();
        }
        Console.WriteLine(max);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < arrCount; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        int result = Result.longestSubarray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

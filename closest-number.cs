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
     * Complete the 'closestNumbers' function below.
     *
     * The function accepts INTEGER_ARRAY numbers as parameter.
     */

    public static void closestNumbers(List<int> numbers)
    {
        int n = numbers.Count;
        numbers.Sort();
        int minDiff = numbers[1] - numbers[0];
        
        for(int i = 2; i < n; i++) {
            // Console.WriteLine(numbers[i]);
            minDiff = Math.Min(minDiff, numbers[i] - numbers[i-1]);
        }
        
        for (int i = 1; i < n; i++) {
            if ((numbers[i] - numbers[i-1]) == minDiff) {
                Console.WriteLine(numbers[i-1] + " " + numbers[i]);
            }    
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int numbersCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> numbers = new List<int>();

        for (int i = 0; i < numbersCount; i++)
        {
            int numbersItem = Convert.ToInt32(Console.ReadLine().Trim());
            numbers.Add(numbersItem);
        }

        Result.closestNumbers(numbers);
    }
}

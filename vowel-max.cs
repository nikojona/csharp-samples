// https://onecompiler.com/csharp/3yxkn67cf


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

class Solution
{
  static Boolean isvowel(char ch) {
      return (ch == 'a' || ch == 'e' ||
              ch == 'i' || ch == 'o' ||
              ch == 'u');
  }
  
  static Boolean isvalid(string theString) {
    int n = theString.Length;

    for(int i = 0; i < n; i++) {
      if (!isvowel(theString[i]))
        return false;
    }
  return true;
  }
  
  public static void Main(string[] args)
  {
    string s = "sepedalipatbarubelidipasar";
    int k = 10;
    
    int sLength = s.Length - k;
    int maxTempInt = 0;
    string maxTempStr = "";
    string temp = "";
    
    for(int x = 0; x <= sLength; x++) {
      temp = s.Substring(x, 10);
      // Console.WriteLine(temp);
      
      List<string> vowels1 = new List<string>();
      List<string> vowels2 = new List<string>();
      for(int y = 0; y < k; y++) {
        if (isvalid(temp[y].ToString())){
            vowels1.Add(temp[y].ToString());
        }
      }
      
      vowels2 = vowels1.Distinct().ToList();
      // Console.WriteLine("---------");
      // foreach(string a in vowels2) {
      //   Console.WriteLine("{0}", a);
      // }
      
      // Console.WriteLine(vowels2.Count+" . "+maxTempInt);
      if (vowels2.Count > maxTempInt) {
        maxTempStr = temp;
        maxTempInt = vowels2.Count;
        Console.WriteLine(maxTempStr+" : "+maxTempInt);
      }
    }
  }
}

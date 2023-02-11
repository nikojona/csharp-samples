using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  static void Display(List<List<int>> list)
    {
        int x = 0;
        int y = 0;
        int z = 0;
        List<int> numbers1 = new List<int>();
        List<int> numbers2 = new List<int>();
        
        foreach (var sublist in list)
        {
          y = 0;
          if (x == 0) {
            z = sublist.Count -1;
          }
          
          // Console.WriteLine("z: "+z);
          foreach (var value in sublist)
          {
            
            Console.Write(y);
            Console.Write(':');
            Console.Write(value);
            Console.Write(' ');
            
            if (x == y) {
              numbers1.Add(value);
            }
            
            if(z == y) {
              numbers2.Add(value);
            }
            
            y += 1;
          }
          Console.WriteLine();
          
          x += 1;
          z -= 1;
        }
        
        int a = 0;
        int b = 0;
        int c = 0;
        foreach(int number in numbers1) {
          // Console.Write(number);
          // Console.Write(' ');
          a += number;
        }
        
        // Console.WriteLine(" ");
        // Console.WriteLine("----");
        
        foreach(int number in numbers2) {
          // Console.Write(number);
          // Console.Write(' ');
          b += number;
        }
        
        Console.WriteLine("a: "+a+" - b: "+b);
        c = a - b;
        if (c < 0) {
          c = c * (-1);
        }
        Console.WriteLine("result: "+c);
        
    }

		public static void Main(string[] args)
		{
		  // Part 1: add rows and columns to the List.
        List<List<int>> list = new List<List<int>>();
        var rand = new Random();
        for (int i = 0; i < 3; i++)
        {
            // Put some integers in the inner lists.
            List<int> sublist = new List<int>();
            // int top = rand.Next(1, 4);
            for (int v = 0; v < 3; v++)
            {
                sublist.Add(rand.Next(1, 9));
            }
            // Add the sublist to the top-level List.
            list.Add(sublist);
        }
        // Display the List.
        Display(list);
        
		}
	}
}

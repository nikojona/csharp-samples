using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            int rows = 9;

            List<int> ar = new List<int>() {10,20,20,10,10,30,50,10,20};
            List<int> myList = ar.Distinct().ToList();
            ar.Sort();
            int x = myList.Count;
            int y = 0;
            int z = 0;
            
            int[,] array = new int[x, 2];
            
            array[0, 0] = myList[0];
            
            for(int i = 0; i < x; i++){
                array[i, 0] = myList[i];
                
                for(int j = 0; j < rows; j++){
                    // Console.WriteLine("array["+i+", 0]: "+array[i, 0]);
                    // Console.WriteLine("ar["+j+"]: "+ar[j]);
                    if(array[i, 0] == ar[j]) {
                        y++;
                    }
                }
                array[i, 1] = y;
                y = 0;
                
                // Console.WriteLine("array["+i+", 0]: "+array[i, 0]);
                // Console.WriteLine("array["+i+", 1]: "+array[i, 1]);
                z += array[i, 1] / 2;
            }
            Console.WriteLine(4 / 2); // 10
            Console.WriteLine(3 / 2); // 20
            Console.WriteLine("z: "+z);
        }
    }
}

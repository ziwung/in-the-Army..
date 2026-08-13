using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
class ID99{
    static void Main(){
        int N = int.Parse(Console.ReadLine()!);
        int[,] nods = new int[N,2];
        for(int i = 0; i<N; i++){
            int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            nods[i,0]= input[0];
            nods[i,1]= input[1];
        }
    }
}
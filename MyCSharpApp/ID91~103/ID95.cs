using System;
using System.Linq;
using System.Collections.Generic;
class ID95{
    static void Main(){
        int N = int.Parse(Console.ReadLine()!);
        int[] ID95_class = new int[N]; int[] score = new int[N];
        for(int i = 0; i<N; i++){
            int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            ID95_class[i] = input[0];
            score = input[1];
        }
        int Q = int.Parse(Console.ReadLine());
        for(int i=0;i<Q;i++){
            
        }
    }
}
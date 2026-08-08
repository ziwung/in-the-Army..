// using System;
// using System.Linq;
// using System.Collections.Generic;
// class ID94{
//     static void Main(){
//         int N = int.Parse(Console.ReadLine()!);
//         int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int[] A = new int[N-2];
//         for(int i =0; i<N-2; i++){
//             A[i] = (input[i]>input[i+1])? input[i+1]:input[i];
//         }
//         int ans = A.Sum()+input[0]+input[N-2];
//         Console.WriteLine(ans);
//     }
// }
// using System;
// using System.Linq;
// using System.Collections.Generic;
// class ID91{
//     static void Main(){
//         int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int N = input[0];
//         int X = input[1];
//         int count = 0;
//         for(int i = 1; i<=N-2; i++){
//             for(int j = i+1; j<=N-1 ; j++){
//                 for(int k = j+1; k<=N; k++){
//                     if(i+j+k == X){
//                         count++;
//                     }
//                 }
//             }
//         }
//         Console.WriteLine(count);
//     }
// }
// using System;
// using System.Linq;
// using System.Collections.Generic;
// class ID92{
//     static void Main(){
//         int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int N = input[0]; int ans = 1; int ans2 = N;
//         for(int i=2; i*i<=N; i++){
//             if(N%i==0){
//                 ans = i;
//                 ans2 = N/i;
//             }
//         }
//         Console.WriteLine(ans*2+ans2*2);
//     }
// }
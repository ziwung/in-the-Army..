// using System;
// using System.Linq;
// using System.Collections.Generic;
// class ID97{
//     static void Main(){
//         long[] input = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
//         long L = input[0]; long R = input[1];
//         int max = 1000000;int[] sosu = new int[max+1];
//         Array.Fill(sosu,1); sosu[0] = 0; sosu[1] = 0;
    
//         for(int i = 4; i<max; i += 2)
//         {
//             sosu[i] = 0;
//         }
//         for(int i = 3; i*i<max; i += 2)
//         {
//             for(int j = i*2; j<max; j += i)
//             {
//                 sosu[j] = 0;
//             }
//         }
//         int sum = 0;
//         for(long i = L; i<=R; i++)
//         {
//             sum += sosu[i];
//         }
//         Console.WriteLine(sum);
//     }
// }
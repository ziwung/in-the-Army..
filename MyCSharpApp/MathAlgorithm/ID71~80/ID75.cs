// using System;
// using System.Linq;
// class ID75
// {
//     static void Main(){
//         int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int N = input.Length; int ans = 0;
//         for(int i = 0; i < N; i++)
//         {
//             int temp = 1;
//             for(int j =0; j<N-i-1; j++)
//             {
//                 temp *=N-j-1;
//                 temp /=j+1;
//             }
//             ans += input[i]*temp;
//         }
//         Console.WriteLine(ans);
//     }
// }
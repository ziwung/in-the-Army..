// using System;
// using System.ComponentModel.DataAnnotations;
// using System.Linq;
// class ID66
// {
//     static void Main()
//     {
//         int N = int.Parse(Console.ReadLine()!);
//         int K = int.Parse(Console.ReadLine()!);

//         int minusCount=0;
//         for(int a=1; a <= N; a++)
//         {
//             int l = Math.Max(1,a-(K-1));
//             int r = Math.Min(N,a+(K-1));
//             for(int b = l; b <=r; b++)
//             {
//                 for(int c = l; b <=r; b++)
//                 {
//                     if (Math.Abs(b - c) < K)
//                     {
//                         minusCount++;
//                     }
//                 }
//             }
//         }
//         int ans = N*N*N - minusCount;
//         Console.WriteLine(ans);
//     }
// }
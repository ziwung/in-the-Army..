using System;
using System.Linq;
using System.Collections.Generic;
class Q18
{
    static void Main()
    {
        // // A18 (내 풀이 최대최소에서만 이 방식이 유효함 이런경우에는 참거짓 dp가 맞음)
        // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        // int N = input[0]; int S = input[1];
        // int[,] dp = new int[N+1,S+1];

        // for(int i = 1; i<N+1; i++)
        // {
        //     for(int j = 1; j<S+1; j++)
        //     {
        //         if(j<A[i-1]){
        //             dp[i,j] = dp[i-1,j];
        //         }
        //         else
        //         {
        //             dp[i,j] = dp[i-1,j-A[i-1]]+A[i-1];
        //         }
        //     }
        // }
        // if(dp[N,S] == S)
        // {
        //     Console.WriteLine("Yes");
        // }else Console.WriteLine("No");
        // // 찐고수의 풀이(bool dp)
        // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        // int N = input[0]; 
        // int S = input[1];

        // // dp[i, j]: i번째까지 수를 사용하여 합 j를 만들 수 있는지 여부
        // bool[,] dp = new bool[N + 1, S + 1];

        // // 합이 0인 경우는 항상 만들 수 있음 (공집합)
        // for (int i = 0; i <= N; i++)
        // {
        //     dp[i, 0] = true;
        // }

        // for (int i = 1; i <= N; i++)
        // {
        //     int currentVal = A[i - 1];
        //     for (int j = 1; j <= S; j++)
        //     {
        //         // 1. i번째 수를 쓰지 않고 이전 상태 그대로 가져오는 경우
        //         dp[i, j] = dp[i - 1, j];

        //         // 2. i번째 수를 사용할 수 있는 경우 (현재 만드려는 합 j가 현재 수보다 크거나 같을 때)
        //         if (j >= currentVal)
        //         {
        //             dp[i, j] = dp[i - 1, j] || dp[i - 1, j - currentVal];
        //         }
        //     }
        // }

        // if (dp[N, S])
        // {
        //     Console.WriteLine("Yes");
        // }
        // else
        // {
        //     Console.WriteLine("No");
        // }
    }
}
// class Q17
// {
//     static void Main()
//     {
//         // A17
//         int N = int.Parse(Console.ReadLine()!);
//         int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int[] B = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

//         int[] dp = new int[N]; dp[1] = A[0]; int[] dptrack = new int[N]; dptrack[1] = 0;
//         for(int i = 2; i<N; i++)
//         {
//             if (dp[i - 1] + A[i - 1] < dp[i - 2] + B[i - 2])
//             {
//                 dp[i] = dp[i-1]+A[i-1];
//                 dptrack[i] = i-1;
//             }
//             else
//             {
//                 dp[i] = dp[i-2]+B[i-2];
//                 dptrack[i] = i-2;
//             }
//         }
//         int curri = N-1;
//         while (curri > 0)
//         {
//             Console.WriteLine(dptrack[curri]+1);
//             curri = dptrack[curri];
//         }
//     }
// }
// class Q16
// {
//     static void Main()
//     {
//         // // A16
//         // int N = int.Parse(Console.ReadLine()!);
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[] B = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

//         // int[] dp = new int[N];dp[1] = A[0];
//         // for(int i = 2; i<N; i++)
//         // {
//         //     dp[i]=(dp[i-1]+A[i-1]<dp[i-2]+B[i-2])? dp[i-1]+A[i-1]:dp[i-2]+B[i-2];
//         // }
//         // Console.WriteLine(dp[N-1]);

//         // // B16
//         // int N = int.Parse(Console.ReadLine()!);
//         // int[] h = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[] dp = new int[N]; dp[0] = 0; dp[1] = Math.Abs(h[0]-h[1]);
         
//         // for(int i = 2; i < N; i++)
//         // {
//         //     dp[i] = (dp[i-1]+Math.Abs(h[i-1]-h[i])<dp[i-2]+Math.Abs(h[i-2]-h[i]))? dp[i-1]+Math.Abs(h[i-1]-h[i]) : dp[i-2]+Math.Abs(h[i-2]-h[i]);
//         // }
//         // Console.WriteLine(dp[N-1]);
//     }
// }
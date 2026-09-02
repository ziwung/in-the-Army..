using System;
using System.Linq;
using System.Collections.Generic;
class Q23
{
    // A23 (비트 dp)
    static void Main()
    {
        int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int n = input[0]; int m = input[1]; int[,] A = new int[m,n];
        for(int i =0; i<m; i++)
        {
            int[] input1 = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            for(int j = 0; j<n; j++)
            {
                A[i,j] = input1[j];
            }
        }
        int n1 = (int)Math.Pow(2,n)-1;
        int[,] dp = new int[m+1,n1+1];
        for(int i = 0; i<m+1; i++)
            for(int j = 0; j<n1+1; j++) dp[i,j] = 100;
        dp[0,0] = 0;
        for(int i = 1; i<=m; i++)
        {
            for(int j = 0; j<=n1; j++)
            {
                int[] already = new int[n];
                for(int k = 0; k<n; k++){
                    if((j & (1<<k)) != 0)already[k] = 1;
                }
                int sum = 0;
                for(int k = 0; k < n; k++){
                    if(already[k] == 1 || A[i-1,k] == 1)
                    {
                        sum += (int)Math.Pow(2,k);
                    }
                }

                dp[i,j] = Math.Min(dp[i-1,j], dp[i,j]);
                dp[i,sum] = Math.Min(dp[i-1,j]+1, dp[i,sum]);
            }   
        }
        Console.WriteLine(dp[m,n1]);
    }
}

// class Q22{
//     static void Main(){
//         // // A22
//         // int N = int.Parse(Console.ReadLine()!);
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[] B = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[] dp = new int[N+1];
//         // for(int i = 1; i<N; i++)
//         // {
//         //     if (dp[A[i - 1]] < dp[i] + 100)
//         //     {
//         //         dp[A[i-1]] = dp[i] + 100;
//         //     }
//         //     if (dp[B[i-1]] < dp[i] + 150)
//         //     {
//         //         dp[B[i-1]] = dp[i] + 150;
//         //     }
//         // }
//         // Console.WriteLine(dp[N]);

//     //     // B22
//     //     int N = int.Parse(Console.ReadLine()!);
//     //     int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//     //     int[] B = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//     //     int[] dp = new int[N];
//     //     Array.Fill(dp,int.MaxValue);
//     //     dp[0] = 0;
//     //     for(int i = 0; i<N-1; i++)
//     //     {
//     //         dp[i+1] = Math.Min(dp[i+1],dp[i]+A[i]);
//     //         if(i != N-2) dp[i+2] = Math.Min(dp[i+2],dp[i]+B[i]);
//     //     }
//     //     for(int i = 0; i<N; i++) Console.WriteLine(dp[i]);
//     }
// }
// class Q21
// {
//     static void Main()
//     {
//         // // A21
//         // int N = int.Parse(Console.ReadLine()!);
//         // int[] target = new int[N+2]; int[] score = new int[N+2];
//         // for(int i = 1; i<N+1; i++)
//         // {
//         //     int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         //     target[i] = input[0];
//         //     score[i] = input[1];
//         // }
//         // int[,] dp = new int[N+2,N+2];  //score

//         // for(int i = 1; i < N+1; i++)
//         // {
//         //     for(int j = N; j>=i; j--)
//         //     {
//         //         int l = target[i-1]; int r = target[j+1];
//         //         int score1 = 0; int score2 = 0;
//         //         if(l <= j && l >= i)  score1 = score[i-1];
//         //         if(r >=i && r <= j) score2 = score[j+1];

//         //         if (i == 1)
//         //         {
//         //             dp[i,j] = dp[i,j+1]+ score2;
//         //         }
//         //         else if (j == N)
//         //         {
//         //             dp[i,j] = dp[i-1,j]+ score1;
//         //         }
//         //         else
//         //         {
//         //             dp[i,j] = Math.Max(dp[i,j+1]+ score2,dp[i-1,j]+ score1);
//         //         }
//         //     }
//         // }
//         // int max = 0;
//         // for(int i = 1; i<=N; i++)
//         // {
//         //     if(max<dp[i,i])max = dp[i,i];
//         // }
//         // Console.WriteLine(max);

//         // B21
//         int N = int.Parse(Console.ReadLine()!);
//         string S = Console.ReadLine()!;
//         S = '#' + S; // S에 #은 무조건 안들어간다 가정
//         int[,] dp = new int[N,N];
//         for(int i = 2; i<N; i++)
//         {
//             for(int j = N-2; j>=i-1; j--)
//             {
//                 if(S[i-1] == S[j+1])
//                 {
//                     dp[i,j] = dp[i-1,j+1] + 1;
//                     break;
//                 }
//                 else
//                 {
//                     dp[i,j] = dp[i-1,j+1];
//                 }
//             }
//         }
//         int max = 0;
//         for(int i = 1; i<=N; i++)
//         {
//             if(max<dp[i,i])max = dp[i,i];
//         }
//         Console.WriteLine(max);
//     }
// }
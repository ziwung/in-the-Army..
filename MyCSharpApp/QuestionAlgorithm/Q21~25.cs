using System;
using System.Linq;
using System.Collections.Generic;

class Q21
{
    static void Main()
    {
        // // A21
        // int N = int.Parse(Console.ReadLine()!);
        // int[] target = new int[N+2]; int[] score = new int[N+2];
        // for(int i = 1; i<N+1; i++)
        // {
        //     int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        //     target[i] = input[0];
        //     score[i] = input[1];
        // }
        // int[,] dp = new int[N+2,N+2];  //score

        // for(int i = 1; i < N+1; i++)
        // {
        //     for(int j = N; j>=i; j--)
        //     {
        //         int l = target[i-1]; int r = target[j+1];
        //         int score1 = 0; int score2 = 0;
        //         if(l <= j && l >= i)  score1 = score[i-1];
        //         if(r >=i && r <= j) score2 = score[j+1];

        //         if (i == 1)
        //         {
        //             dp[i,j] = dp[i,j+1]+ score2;
        //         }
        //         else if (j == N)
        //         {
        //             dp[i,j] = dp[i-1,j]+ score1;
        //         }
        //         else
        //         {
        //             dp[i,j] = Math.Max(dp[i,j+1]+ score2,dp[i-1,j]+ score1);
        //         }
        //     }
        // }
        // int max = 0;
        // for(int i = 1; i<=N; i++)
        // {
        //     if(max<dp[i,i])max = dp[i,i];
        // }
        // Console.WriteLine(max);

        // B21
        int N = int.Parse(Console.ReadLine()!);
        string S = Console.ReadLine()!;
        S = '#' + S; // S에 #은 무조건 안들어간다 가정
        int[,] dp = new int[N,N];
        for(int i = 2; i<N; i++)
        {
            for(int j = N-2; j>=i-1; j--)
            {
                if(S[i-1] == S[j+1])
                {
                    dp[i,j] = dp[i-1,j+1] + 1;
                    break;
                }
                else
                {
                    dp[i,j] = dp[i-1,j+1];
                }
            }
        }
        int max = 0;
        for(int i = 1; i<=N; i++)
        {
            if(max<dp[i,i])max = dp[i,i];
        }
        Console.WriteLine(max);
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
class Q19
{
    static void Main()
    {
        //  // A19
        // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        // int N = input[0]; int W = input[1]; List<int>[] prod = new List<int>[N];
        // for(int i = 0; i<N; i++)
        // {
        //     int[] input2 = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        //     prod[i] = new List<int>();
        //     prod[i].Add(input2[0]);
        //     prod[i].Add(input2[1]);
        // }
        // int[,] dp = new int[N+1,W+1];
        // for(int i = 1; i<N+1; i++)
        // {
        //     int curriwei = prod[i-1][0];
        //     for(int j = 1; j < W+1; j++)
        //     {
        //         if(curriwei <= j)
        //         {
        //             dp[i,j] = Math.Max(dp[i-1,j-curriwei]+prod[i-1][1],dp[i-1,j]);
        //         }else dp[i,j] = dp[i-1,j]; 
                 
        //     }
        // }
        // int ans = 0;
        // for(int i = 0; i<W+1; i++) Math.Max(ans,dp[N,i]);
        // Console.WriteLine(ans);

        // B19
var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int N = input[0]; 
        long W = input[1];
        int[] weights = new int[N];
        int[] values = new int[N];
        int maxPossibleValue = 0;
        for (int i = 0; i < N; i++)
        {
            var item = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            weights[i] = item[0];
            values[i] = item[1];
            maxPossibleValue += values[i];
        }
        // dp[v] = 가치 v를 만들기 위한 최소 무게
        long[] dp = new long[maxPossibleValue + 1];
        Array.Fill(dp, long.MaxValue);
        dp[0] = 0; // 가치 0을 만드는 데 필요한 무게는 0

        for (int i = 0; i < N; i++)
        {
            int w = weights[i];
            int v = values[i];

            for (int j = maxPossibleValue; j >= v; j--)
            {
                if (dp[j - v] != long.MaxValue)
                {
                    dp[j] = Math.Min(dp[j], dp[j - v] + w);
                }
            }
        }

        // 무게가 W 이하인 경우 중 가장 큰 가치 찾기
        int ans = 0;
        for (int i = 0; i <= maxPossibleValue; i++)
        {
            if (dp[i] <= W)
            {
                ans = i;
            }
        }

        Console.WriteLine(ans);
    }
}
// class Q18
// {
//     static void Main()
//     {
//         // // A18 (내 풀이 최대최소에서만 이 방식이 유효함 이런경우에는 참거짓 dp가 맞음)
//         // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int N = input[0]; int S = input[1];
//         // int[,] dp = new int[N+1,S+1];
//         // for(int i = 1; i<N+1; i++)
//         // {
//         //     for(int j = 1; j<S+1; j++)
//         //     {
//         //         if(j<A[i-1]){
//         //             dp[i,j] = dp[i-1,j];
//         //         }
//         //         else
//         //         {
//         //             dp[i,j] = dp[i-1,j-A[i-1]]+A[i-1];
//         //         }
//         //     }
//         // }
//         // if(dp[N,S] == S)
//         // {
//         //     Console.WriteLine("Yes");
//         // }else Console.WriteLine("No");

//         // // 찐고수의 풀이(bool dp)
//         // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int N = input[0]; 
//         // int S = input[1];
//         // bool[] dp = new bool[S + 1]; dp[0] = true;
//         // for (int i = 1; i <= N; i++)
//         // {
//         //     int currentVal = A[i - 1];
//         //     for (int j = S; j >= currentVal; j--)
//         //     {
//         //         if (dp[j - currentVal])
//         //         {
//         //             dp[j] = true;
//         //         }
//         //     }
//         // }
//         // if (dp[S])
//         // {
//         //     Console.WriteLine("Yes");
//         // }
//         // else
//         // {
//         //     Console.WriteLine("No");
//         // }

//         // // B18
//         // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int N = input[0]; 
//         // int S = input[1];
//         // bool[] dp = new bool[S + 1]; dp[0] = true;
//         // for (int i = 1; i <= N; i++)
//         // {
//         //     int currentVal = A[i - 1];
//         //     for (int j = S; j >= currentVal; j--)
//         //     {
//         //         if (dp[j - currentVal])
//         //         {
//         //             dp[j] = true;
//         //         }
//         //     }
//         // }
//         // int curri = S; List<int> ans = new List<int>(); ans.Add(curri);
//         // // 지금 잘못구현해놨는데 Stack 컬랙션으로 선택한거 Pop하면서 찾아야 할듯..
//         // while(curri > 0)
//         // {
//         //     int i = 0; bool isfound = true;
//         //     while(isfound)
//         //     {
//         //         if(dp[curri - A[i]])
//         //         {
//         //             curri = curri - A[i];
//         //             ans.Add(A[i]);
//         //             isfound = false;
//         //         }
//         //         i++;
//         //     }
//         // }
//         // for(int i = ans.Count-1; i>=0; i--)
//         // {
//         //     Console.WriteLine(ans[i]);
//         // }
//     }
// }
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
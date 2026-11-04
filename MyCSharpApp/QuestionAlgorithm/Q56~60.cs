using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
class Q56_60{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    private static  string[] line = new string[0];
    private static int lineIdx = 0;
    private static string NextToken(){
        while(lineIdx >= line.Length){
            string s = sr.ReadLine()!;
            if(s == null) return null!;
            line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            lineIdx = 0;
        }
        return line[lineIdx++];
    }
    public static int B = 31;
    public static int M = 10007;
    private static int NextInt() => int.Parse(NextToken())!;
    private static long NextLong() => long.Parse(NextToken()!);
    static void Main()
    {
        // // A56
        // int N = NextInt(); //글자수
        // int Q = NextInt(); //쿼리수
        // string S = NextToken(); //글
        // int[] hashcode = new int[N+1]; hashcode[0] = 0; hashcode[1] = S[0];
        // for(int i = 1; i<=N; i++)
        // {
        //     hashcode[i] = (hashcode[i-1]*B + S[i-1])%M;
        // }
        // for(int i = 0; i<Q; i++)
        // {
        //     if(CulHash(hashcode,NextInt(),NextInt()) == CulHash(hashcode, NextInt(), NextInt()))
        //     {
        //         Console.WriteLine("yes");
        //     }
        //     else Console.WriteLine("No");
        // }

        // // B56
        // int N = NextInt(); // 글자수
        // int Q = NextInt(); // 쿼리수
        // string S = NextToken(); // 문자
        // int[] hashcode = new int[N+1]; hashcode[0] = 0;
        // int[] Rhashcode = new int[N+1]; hashcode[0] = 0;
        // for(int i = 1; i<=N; i++)
        // {
        //     hashcode[i] = (hashcode[i-1]*B + S[i-1])%M;
        //     Rhashcode[i] = (Rhashcode[i-1]*B + S[N-i])%M;
        // }
        // for(int i = 0; i<Q; i++)
        // {
        //     int first = NextInt();
        //     int secound = NextInt();
        //     if (CulHash(hashcode, first, secound) == CulHash(Rhashcode,N-secound+1, N-first+1))
        //     {
        //         Console.WriteLine("회문 맞음");
        //     } else Console.WriteLine("회문 아님");
        // }

        // // A57
        // int N = NextInt();
        // int Q = NextInt();
        // int[,] dp = new int[29,N]; //2^29일 N개의 구멍
        // for(int i = 0; i<N; i++)
        // {
        //     dp[0,i] = NextInt();
        // }
        // for(int i = 1; i<29; i++)
        // {
        //     for(int j = 0; j<N; j++)
        //     {
        //         dp[i,j] = dp[i-1,(dp[i-1,j]-1)];
        //     }
        // }
        // for(int i = 0; i<Q; i++)
        // {
        //     int startHoll = NextInt()-1;
        //     long day = NextLong();
        //     int k = 0;
        //     while((1L<<k) <= day)
        //     {
        //         if((day&1L << k) > 0)
        //         {
        //             startHoll = dp[k,startHoll]-1;
        //         }
        //         k++;
        //     }
        //     Console.WriteLine(startHoll+1);
        // }

        // // B57
        // int N = NextInt();
        // int Q = NextInt();
        // int[,] dp = new int[29,N+1];
        // for(int i = 1; i<=N; i++)
        // {
        //     int now = i;
        //     int temp = 0;
        //     while(now != 0)
        //     {
        //         temp -= now%10;
        //         now /= 10; 
        //     }
        //     dp[0,i] = now + temp;
        // }
        // for(int i = 0; i<Q; i++)
        // {
        //     int K = NextInt();
        //     int wanna = NextInt();
        //     int k = 0;
        //     while((1L<<k) <= K)
        //     {
        //         if((K&1L << k) > 0)
        //         {
        //             wanna = dp[k,wanna];
        //         }
        //         k++;
        //     }
        //     Console.WriteLine(wanna);
        // }

        // A58 (세그먼트 트리 RMQ)
        int N = NextInt();
        int Q = NextInt();
        int len = 2;
        while(N > len)
        {
            len *= 2;
        }
        int[] narray = new int[len*2];
        for(int i = 0; i<Q; i++)
        {
            if(NextToken() == "1")
            {
                PushNum(len, narray,NextInt(),NextInt());
            }else Console.WriteLine(Quary(narray,NextInt(),NextInt(),1,len,1));
        }
    }
    static void PushNum (int N, int[] array, int pos, int num)
    {
        int temp = N+pos-1;
        array[temp] = num;
        temp = temp/2;
        while(temp != 1)
        {
            array[temp] = Math.Max(array[temp*2],array[temp*2+1]);
            temp /= 2;
        }
    }
    static int Quary (int[] array,int l, int r, int a, int b, int u)
    {
        if(r <= a || l >= b) return -1000000;
        if(l <= a && b <= r) return array[u];
        int m = (a+b)/2;
        int ans1 = Quary(array,l,r,a,m,u*2);
        int ans2 = Quary(array,l,r,m+1,b,u*2+1);
        return Math.Max(ans1,ans2);
    }
    static int CulHash(int[] hashcode, int start, int end)
    {
        int result = (hashcode[end]-Gudup(B,end-start+1)*hashcode[start-1]) %M;
        return (result % M + M) % M;
    }
    static int Gudup(int a, int b)
    {
        int i = 0;
        int ans = 1;
        while (b >= 1<<i)
        {
            if ((b & 1 << i++) > 0)
            {
                ans *= a;
                ans %= M;
            }
            a = (a*a)%M;
        }
        return ans;
    }
}
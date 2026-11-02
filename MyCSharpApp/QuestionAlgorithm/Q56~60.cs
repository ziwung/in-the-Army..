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

        // A57
        int N = NextInt();
        int Q = NextInt();
        int[] A = new int[N];
        int[,] dp = new int[29,N]; //29일 N개의 구멍
        for(int i = 0; i<29; i++)
        {
            for(int j = 0; j<N; j++)
            {
                
            }
        }
        for(int i = 0; i<Q; i++)
        {
            
        }
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
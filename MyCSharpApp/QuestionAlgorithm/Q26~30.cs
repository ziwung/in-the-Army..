using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
class Q30
{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    private static  string[] line = new string[0];
    private static int lineIdx = 0;

    private static string NextToken(){
        while(lineIdx >= line.Length){
            string s = sr.ReadLine()!;
            if(s == null) return null;
            line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            lineIdx = 0;
        }
        return line[lineIdx++];
    }
    private static int NextInt() => int.Parse(NextToken())!;
    private static char NextChar() => char.Parse(NextToken());
    static void Main()
    {
        
    }
}
// class Q29
// {
//     private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
//     private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
//     private static  string[] line = new string[0];
//     private static int lineIdx = 0;

//     private static string NextToken(){
//         while(lineIdx >= line.Length){
//             string s = sr.ReadLine()!;
//             if(s == null) return null;
//             line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//             lineIdx = 0;
//         }
//         return line[lineIdx++];
//     }
//     private static int NextInt() => int.Parse(NextToken())!;
//     private static char NextChar() => char.Parse(NextToken());
//     static void Main()
//     {
//         // A29 & B29
//         long a = NextInt();
//         long b = NextInt();
//         int i=0; long ans = 1; int tm = 1000000007;
//         while (b >= 1L<<i)
//         {
//             if((b&1L<<i++) > 0)
//             {
//                 ans *= a;
//                 ans %= tm;
//             }
//             a = (a*a) % tm;
//         }
//         sw.WriteLine(ans);
//         sw.Close();
//     }
// }
// class Q28
// {
//     private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
//     private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
//     private static  string[] line = new string[0];
//     private static int lineIdx = 0;

//     private static string NextToken(){
//         while(lineIdx >= line.Length){
//             string s = sr.ReadLine()!;
//             if(s == null) return null;
//             line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//             lineIdx = 0;
//         }
//         return line[lineIdx++];
//     }
//     private static int NextInt() => int.Parse(NextToken())!;
//     private static char NextChar() => char.Parse(NextToken());
//     static void Main()
//     {
//         // // A28
//         // int N = NextInt();
//         // char[] sign = new char[N];
//         // int[] num = new int[N];
//         // for(int i =0; i<N; i++)
//         // {
//         //     sign[i] = NextChar();
//         //     num[i] = NextInt(); 
//         // }
//         // int ans = 0;
//         // for(int i = 0 ;i<N; i++)
//         // {
//         //     if(sign[i] == '+') ans += num[i];
//         //     else if(sign[i] == '-') ans -= num[i];
//         //     else ans *= num[i];

//         //     if(ans<0) ans += 10000;
//         //     ans%=10000; 
//         // }
//         // sw.WriteLine(ans);
//         // sw.Close();

//         // // B28 (기본적인 풀이)
//         // int N = NextInt();
//         // int thenum = 1000000007;
//         // int[] pibonachi = new int[N+1]; pibonachi[1] = 1; pibonachi[2] = 1;
//         // for(int i = 3; i <= N; i++)
//         // {
//         //     pibonachi[i] = (pibonachi[i-1] + pibonachi[i-2])%thenum;
//         // }
//         // sw.WriteLine(pibonachi[N]);
//         // sw.Close();
//     }
// }
// class Q27
// {
//     private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
//     private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
//     private static  string[] line = new string[0];
//     private static int lineIdx = 0;

//     private static string NextToken(){
//         while(lineIdx >= line.Length){
//             string s = sr.ReadLine()!;
//             if(s == null) return null;
//             line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//             lineIdx = 0;
//         }
//         return line[lineIdx++];
//     }
//     private static int NextInt() => int.Parse(NextToken())!;
//     static void Main()
//     {
//         // A27, B27
//         int A = NextInt();
//         int B = NextInt();
//         sw.WriteLine(GetGCD(A,B));
//         sw.WriteLine(GetLCM(A,B));
//         sw.Close();
//     }
//     static int GetGCD(int a, int b) => (b == 0)? a : GetGCD(b,a%b); 
//     static int GetLCM(int a, int b)
//     {
//         int gdc = GetGCD(a,b);
//         return (a/gdc)*b; //오버플로우 방지
//     }
// }
// class Q26
// {
//     // 이제부터 StreamReader Writer를 써보겠습니다. (코테 대비)
//     private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
//     private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
//     private static  string[] line = new string[0];
//     private static int lineIdx = 0;

//     private static string NextToken(){
//         while(lineIdx >= line.Length){
//             string s = sr.ReadLine()!;
//             if(s == null) return null;
//             line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//             lineIdx = 0;
//         }
//         return line[lineIdx++];
//     }
//     private static int NextInt() => int.Parse(NextToken())!;
//     static void Main()
//     {
//         // // A26
//         // int Q = NextInt();
//         // int[] q = new int[Q]; string[] ans = new string[Q];
//         // for(int i = 0; i<Q; i++)
//         // {
//         //     q[i] = NextInt();
//         // }
//         // for(int i = 0; i<Q; i++)
//         // {
//         //     int now = q[i];
//         //     if(now%2 == 0)
//         //     {
//         //         ans[i] = "Yes";
//         //     }
//         //     else
//         //     {
//         //         int j = 3;
//         //         while(j*j <= now)
//         //         {
//         //             if(now%j == 0)
//         //             {
//         //                 ans[i] = "No";
//         //                 break;
//         //             }
//         //             j += 2;
//         //         }
//         //         if(ans[i] != "No") ans[i] = "Yes";
//         //     }
//         // }
//         // for(int i = 0; i<Q; i++)
//         // {
//         //     sw.WriteLine(ans[i]);
//         // }
//         // sw.Close();

//         // // B26 (에라토스테네스의 체)
//         // int N = NextInt();
//         // int thenum = 1000001;
//         // int[] ara = new int[thenum];
//         // Array.Fill(ara,1); ara[0] = 0; ara[1] = 0;
//         // for(int i = 4; i<thenum; i+=2)
//         // {
//         //     ara[i] = 0;
//         // }
//         // for(int i = 3; i*i<thenum; i += 2)
//         // {
//         //     if(ara[i] == 1){
//         //         int start = i*i;
//         //         while(start < thenum)
//         //         {
//         //             ara[start] = 0;
//         //             start += i*2;
//         //         }
//         //     }
//         // }
//         // int ans = 0;
//         // for(int i = 2; i<= N; i++)
//         // {
//         //     ans += ara[i];
//         // }
//         // sw.WriteLine(ans);
//         // sw.Close();
//     }
// }
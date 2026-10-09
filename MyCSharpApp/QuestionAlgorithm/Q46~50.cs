using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
class Q49
{
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
    private static int NextInt() => int.Parse(NextToken())!;
    static void Main()
    {
        int t = NextInt();
        int[] a = new int[20];
        string ans = "S";
        for(int i = 0; i<t; i++)
        {
            int[] maybe = new int[4];
            int[] count = new int[3];
            int p = NextInt()-1; int q = NextInt()-1; int r = NextInt()-1;
            if(a[p]<2&&a[p]>-2)count[a[p]+1]++; 
            if(a[q]<2&&a[q]>-2)count[a[q]+1]++;
            if(a[r]<2&&a[r]>-2)count[a[r]+1]++;
            for(int j = 0; j<3; j++)
            {
                maybe[count[j]]++;
            }
            int maxvalue=0;
            if(maybe[1] != 2&& maybe[1] != 3){
                maxvalue = Array.IndexOf(count,count.Max());
                if (maxvalue == 2)
                {
                    a[p]--; a[q]--; a[r]--;
                    ans += "B";
                }
                else
                {
                    a[p]++; a[q]++; a[r]++;
                    ans += "A";
                }
            }
            else
            {
                if(maybe[1] == 3||maybe[0]==3)
                {
                    a[p]--; a[q]--; a[r]--;
                    ans += "B";
                }
                else
                {
                    if(count[1] == 1)
                    {
                        a[p]++; a[q]++; a[r]++;
                        ans += "A";
                    }
                    else
                    {
                        a[p]--; a[q]--; a[r]--;
                        ans += "B";
                    }
                }
            }
        }
        for(int i = 1; i <= t; i++)
        {
            Console.WriteLine($"{ans[i]}");
        }
    }
}
// class Q45{
//     private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
//     private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
//     private static  string[] line = new string[0];
//     private static int lineIdx = 0;
//     private static string NextToken(){
//         while(lineIdx >= line.Length){
//             string s = sr.ReadLine()!;
//             if(s == null) return null!;
//             line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//             lineIdx = 0;
//         }
//         return line[lineIdx++];
//     }
//     private static int NextInt() => int.Parse(NextToken())!;
//     private static double NextDouble() => double.Parse(NextToken())!;
//     static void Main()
//     {
//         // A46
//         int n = NextInt();
//         double[] x = new double[n]; double[] y = new double[n];
//         for(int i = 0; i<n; i++)
//         {
//             x[i] = NextDouble();
//             y[i] = NextDouble();
//         }
//         bool[] visited = new bool[n]; visited[0] = false; int[] ans = new int[n]; int count = 0; int now = 0; int curri = 0;
//         while(count < n){
//             double nowdis = 100000;
//             for(int i = 1; i<n; i++)
//             {
//                 if(visited[i]){
//                     double a = Math.Sqrt(Math.Pow(x[now] - x[i], 2) + Math.Pow(y[now] - y[i], 2));
//                     if(nowdis > a)
//                     {
//                         nowdis = a;
//                         curri = i;
//                     }
//                 }
//             }
//             visited[curri] = false;
//             ans[count] = now;
//             now = curri;
//             count++;            
//         }
//         for(int i = 0; i<n; i++)
//         {
//             Console.WriteLine(ans[i]);
//         }
//     }
// }
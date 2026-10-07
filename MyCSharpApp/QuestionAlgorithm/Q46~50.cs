using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
class Q45{
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
    private static double NextDouble() => double.Parse(NextToken())!;
    static void Main()
    {
        // A46
        int n = NextInt();
        double[] x = new double[n]; double[] y = new double[n];
        for(int i = 0; i<n; i++)
        {
            x[i] = NextDouble();
            y[i] = NextDouble();
        }
        bool[] visited = new bool[n]; visited[0] = false; int[] ans = new int[n]; int count = 0; int now = 0; int curri = 0;
        while(count < n){
            double nowdis = 100000;
            for(int i = 1; i<n; i++)
            {
                if(visited[i]){
                    double a = Math.Sqrt(Math.Pow(x[now] - x[i], 2) + Math.Pow(y[now] - y[i], 2));
                    if(nowdis > a)
                    {
                        nowdis = a;
                        curri = i;
                    }
                }
            }
            visited[curri] = false;
            ans[count] = now;
            now = curri;
            count++;            
        }
        for(int i = 0; i<n; i++)
        {
            Console.WriteLine(ans[i]);
        }
    }
}
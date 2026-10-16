using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
// class Q50{
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
//     static void Main()
//     {
        
//     }
// }
// class Q49 // 장지웅 존나 장하다!
// {
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
//     static int Width = 2;
//     static void Main() // 싸지방 히터에서 피썩은내 남 ㅅㅂ;
//     {
//         int t = NextInt();
//         State[] a = new State[Width]; //상위 width개를 유지하는 배열
//         for(int j = 0; j < Width; j++) a[j] = new State(); 
        
//         State[] temp = new State[Width * 2]; //상위 width개를 계산하기위한 임시저장배열
//         for(int j = 0; j < Width * 2; j++) temp[j] = new State();
//         string ans = "S";
//         for(int i = 0; i<t; i++)
//         {
//             int count = 0;
//             int p=NextInt(); int q=NextInt(); int r=NextInt();
//             for(int j = 0; j<Width*2; j+=2) //임시배열에 값 저장
//             {
//                 Array.Copy(a[count].X, temp[j].X,20); temp[j].score = a[count].score;
//                 Array.Copy(a[count].X, temp[j+1].X,20); temp[j+1].score = a[count].score;
//                 temp[j].X[p]++; temp[j].X[q]++; temp[j].X[r]++;
//                 temp[j+1].X[p]--; temp[j+1].X[q]--; temp[j+1].X[r]--; 
//                 count++;
//             }
//             for(int j = 0; j<Width*2; j++) //임시배열 점수계산
//             {
//                 for(int k = 0; k<20; k++) if(temp[j].X[k] == 0) temp[j].score++;
//             }
//             Array.Sort(temp);
//             for(int j = 0; j<Width; j++) // 상위 width개 a배열에 저장(copy)
//             {
//                 Array.Copy(temp[j].X, a[j].X,20); a[j].score = temp[j].score;
//             }
//         }
//         Console.WriteLine(a[0].score);
//     }
// }
// class State : IComparable<State>
// {
//     public int score = 0;
//     public int[] X = new int[20];

//     public int CompareTo(State other)
//     {
//         if(other == null) return 1;
//         return other.score.CompareTo(this.score);   
//     }
// }
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
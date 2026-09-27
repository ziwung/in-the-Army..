using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
// class Q39
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
//     static void Main(){
//         // //A39
//         // int n = NextInt();
//         // Tiumm[] ti = new Tiumm[n];
//         // for(int i = 0; i<n; i++)
//         // {
//         //     ti[i] = new Tiumm();
//         //     ti[i].start = NextInt();
//         //     ti[i].end = NextInt();
//         // }
//         // ti.Sort();
//         // int curri = 0; int next = 1; int count = 1;
//         // while(next < n)
//         // {
//         //     if(ti[curri].end <= ti[next].start)
//         //     {
//         //         curri = next;
//         //         count++;
//         //     }
//         //     next++;
//         // }
//         // Console.WriteLine(count);

//         // B39
//         int d = NextInt();
//         int n = NextInt();
//         Tiumm[] ti = new Tiumm[n];
//         for(int i = 0; i<n; i++)
//         {
//             ti[i] = new Tiumm();
//             ti[i].start = NextInt(); // 돈
//             ti[i].end = NextInt(); // 날짜 (xi)
//         }
//         ti.Sort(); // 날짜 기준으로 정렬

//         int ticount = 0; 
//         int mounysum = 0; 
//         PriorityQueue<int, int> til = new PriorityQueue<int, int>();

//         for(int i = 1; i <= d; i++)
//         {
//             while (ticount + 1 < n && i >= ti[ticount + 1].end)
//             {
//                 ticount++;
//                 til.Enqueue(ti[ticount].start, -ti[ticount].start); // 돈이 큰 순서대로 나오도록 음수 우선순위 지정
//             }
//             if (til.Count > 0)
//             {
//                 mounysum += til.Dequeue();
//             }
//         }
//         Console.WriteLine(mounysum);
//     }
//     public class Tiumm : IComparable<Tiumm>
//     {
//         public int start;
//         public int end;
//         public Tiumm(int s, int e)
//         {
//             start = s;
//             end = e;
//         }
//         public Tiumm()
//         {
//             start = 0;
//             end = 0;
//         }
//         // A39용
//         // public int CompareTo(Tiumm other)
//         // {
//         //     if (other == null) return 1;
//         //     int result = this.end.CompareTo(other.end);
//         //     if (result == 0)
//         //     {
//         //        return this.start.CompareTo(other.start);
//         //     }
//         //     return result;
//         // }
//         public int CompareTo(Tiumm other)
//         {
//             if (other == null) return 1;
//             int result = this.end.CompareTo(other.end);
//             if (result == 0)
//             {
//                return other.start.CompareTo(this.start);
//             }
//             return result;
//         }
//     }
// }
// class Q38
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
//     static void Main()
//     {
//         // // A38
//         // int D = NextInt(); int N = NextInt();
//         // int[] L = new int[N];
//         // int[] R = new int[N];
//         // int[] H = new int[N];
//         // for(int i = 0; i<N; i++){
//         //     L[i] = NextInt();
//         //     R[i] = NextInt();
//         //     H[i] = NextInt();
//         // }
//         // //계산
//         // int currin = 0; int curriend = R[0]; int sum = 0;
//         // for(int i = 1; i<D; i++)
//         // {
//         //     if (i < curriend)
//         //     {
//         //         sum += H[currin];
//         //     }
//         //     else
//         //     {
//         //         int min = Math.Min(H[currin],H[currin+1]);
//         //         sum += min;
//         //         currin += 1;
//         //         curriend = R[currin];
//         //     }
//         // }
//         // sum += H[currin];
//         // Console.WriteLine(sum);

//         // B38
//         int n = NextInt();
//         int[] s = new int[n-1];
//         int[] pluslim = new int[n]; pluslim[0] = 1;
//         int[] minuslim = new int[n]; minuslim[0] = 1;
//         s[0] = NextInt();
//         for(int i = 1; i< n-1; i++)
//         {
//             s[i] = NextInt();
//         }
//         int count = 1;
//         for(int i = 1; i<n; i++)
//         {
//             if(s[i-1] == 1)
//             {
//                 pluslim[i] = count++;
//             }
//             else
//             {
//                 pluslim[i] = 1;
//                 count = 1;
//             }
//         }
//         count = 1;
//         for(int i = n-1; i>=0; i--)
//         {
//             if(s[i-1] == -1)
//             {
//                 minuslim[i] = count++;
//             }
//             else
//             {
//                 minuslim[i] = 1;
//                 count = 1;
//             }
//         }
//         int sum = 0;
//         for(int i = 0; i<n; i++)
//         {
//             sum += Math.Max(pluslim[i],minuslim[i]);
//         }
//         Console.WriteLine(sum);
//     }
// }
// class Q37
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
//     static void Main()
//     {
//         // // A37
//         // int n = NextInt(); int m = NextInt(); int b = NextInt();
//         // int[] a = new int[n]; int[] c = new int[m];
//         // for(int i = 0; i< n; i++)
//         // {
//         //     a[i] = NextInt();
//         // }
//         // for(int i = 0; i<m; i++)
//         // {
//         //     c[i] = NextInt();
//         // }
//         // int sum = a.Sum()*m + c.Sum()*n + b*n*m;
//         // Console.WriteLine(sum);

//         // B37
//         long n = (long)NextInt();
//         long sum = 0;
//         long maxC = 1;
//         while(maxC <= n)
//         {
//             long higher = n / (maxC*10);
//             long center = (n / maxC) %10;
//             long lower = n % maxC;

//             sum += higher * maxC * 45L;
//             for(int i = 0; i<center; i++)
//             {
//                 sum += i*maxC;
//             }
//             sum += center*(lower+1);
//             maxC *= 10;
//         }
        
//         Console.WriteLine(sum);
//     }
// }
// class Q36{
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
//         // // A36
//         // int n = NextInt(); int k = NextInt();
//         // if(k < (n*2-2) && k%2 == 1) Console.WriteLine("불가능");
//         // else Console.WriteLine("가능");

//         // B36
//         int n = NextInt(); int k = NextInt(); int[] a = new int[n];
//         for(int i = 0; i < n; i++)
//         {
//             a[i] = NextInt();
//         }
//         int turnOnCount = 0;
//         for(int i = 0; i < n; i++)
//         {
//             if(a[i] == 1) turnOnCount++; 
//         }
//         if(k%2 == turnOnCount%2){
//             Console.WriteLine("가능");
//         }else Console.WriteLine("불가능");
//     }
// }
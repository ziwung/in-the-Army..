// using System;
// using System.IO;
// using System.Linq;
// using System.Collections.Generic;
// class Q35
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
//         // A35
//         int n = NextInt();
//         int[,] dp = new int[n+1,n+1];
//         for(int i = 1; i <= n; i++)
//         {
//             dp[n,i] = NextInt();
//         }
//         for(int i = n-1; i > 0; i--)
//         {
//                 for(int j = i; j >0; j--){
//                 if(i%2 == 1) // 최대인경우 턴
//                 {
//                     dp[i,j] = Math.Max(dp[i+1,j], dp[i+1,j+1]);
//                 }
//                 else //최소 턴
//                 {
//                     dp[i,j] = Math.Min(dp[i+1,j], dp[i+1,j+1]);
//                 }
//             }
//         }
//         Console.WriteLine(dp[1,1]);
//     }
// }
// class Q34{
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
//         // // A34
//         // int n = NextInt(); int x = NextInt(); int y = NextInt();
//         // int[] a = new int[n];
//         // for(int i = 0; i < n; i++)
//         // {
//         //     a[i] = NextInt(); // 커스텀 메서드 입력
//         // }
//         // int xorSum = GetGrundy(a[0],x,y);
//         // for(int i = 1; i<n; i++)
//         // {
//         //     xorSum = xorSum^GetGrundy(a[i],x,y);
//         // }
//         // if(xorSum == 0)
//         // {
//         //     Console.WriteLine("후수필승");
//         // }else Console.WriteLine("선수필승");

//         // B34
//         int n = NextInt();
//         int[] a = new int[n];
//         for(int i = 0; i < n; i++)
//         {
//             a[i] = NextInt(); // 커스텀 메서드 입력
//         }
//         int xorSum = GetGrundy2(a[0]);
//         for(int i = 1; i<n; i++)
//         {
//             xorSum = xorSum^GetGrundy2(a[i]);
//         }
//         if(xorSum == 0)
//         {
//             Console.WriteLine("후수필승");
//         }else Console.WriteLine("선수필승");
//     }
//     public static int GetGrundy2(int a)
//     {
//         int ans = a%5;
//         if (ans == 4)
//         {
//             return 2;
//         }else if(ans < 4 && ans > 1)
//         {
//             return 1;
//         }else return 0;
//     }
//     public static int GetGrundy(int a, int x, int y)
//     {
//         int[] num = new int[a+1];
//         (int min, int max) = (x>y) ? (y,x) : (x,y);
//         for(int i =0; i<min; i++)
//         {
//             num[i] = 0;
//         }
//         for(int i = min; i<a+1; i++)
//         {
//             int[] nums = new int[3];
//             for(int j = 0; j<3; j++)
//             {
//                 nums[j] = j;
//             }
//             nums[num[i-min]] = int.MaxValue;
//             if(i>=max) nums[num[i-max]] = int.MaxValue;
//             num[i] = nums.Min();
//         }
//         return num[a];
//     }
// }
// class Q33
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
//         // // A33
//         // int n = NextInt();
//         // int[] a = new int[n];
//         // for(int i = 0; i < n; i++) a[i] = NextInt();
//         // int XORsum = a[0];
//         // for(int i = 1; i < n; i++)
//         // {
//         //     XORsum = XORsum^a[i];
//         //     Console.WriteLine(XORsum);
//         // }
//         // if(XORsum == 0)
//         // {
//         //     Console.WriteLine("후수필승");
//         // }else Console.WriteLine("선수필승");

//         // // B33
//         // int h = NextInt();
//         // int w = NextInt();
//         // if((h^w) == 0){
//         //     Console.WriteLine("후수필승");
//         // }else Console.WriteLine("선두필승");
//     }
// }
// class Q32
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
//         // // A32
//         // int n = NextInt(); int a = NextInt(); int b = NextInt();
//         // (int max, int min) = (a>b) ? (a,b):(b,a);
//         // int[] dp = new int[n+1+max]; 
//         // for(int i = n+max; i >= n-min; i--)
//         // {
//         //     dp[i] = -1;
//         // }
//         // for(int i = n-min-1; i >= 0; i--)
//         // {
//         //     if(dp[i+a] == -1 || dp[i+b] == -1)
//         //     {
//         //         dp[i] = 1;
//         //     }
//         //     else
//         //     {
//         //         dp[i] = -1;
//         //     }
//         // }
//         // Console.WriteLine(dp[0]);

//         // B32
//         int n = NextInt();
//         int k = NextInt();
//         int[] a = new int[k];
//         for(int i = 0; i < k; i++)
//         {
//             a[i] = NextInt();
//         }
//         int max = a.Max(); int min = a.Min();
//         int[] dp = new int[n+max+1];
//         for(int i = n; i<n+max; i++)
//         {
//             dp[i] = -1;
//         }
//         for(int i = n-1; i >= 0; i--)
//         {
//             bool canWin = false;
//             foreach(int x in a)
//             {
//                 if(dp[i + x] == -1)
//                 {
//                     canWin = true;
//                     break;
//                 }
//             }
//             dp[i] = canWin ? 1 : -1;
//         }
//         Console.WriteLine(dp[0]);
//     }
// }
// class Q31
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
//     private static char NextChar() => char.Parse(NextToken());
//     static void Main()
//     {
//         // // A31
//         // long n = long.Parse(Console.ReadLine()!);
//         // long a = n/5;
//         // long b = n/3;
//         // long c = n/15;
//         // Console.WriteLine(a+b-c);

//         // // B31
//         // long n = long.Parse(Console.ReadLine()!);
//         // long a = n/5; long b = n/3; long c = n/7;
//         // long ab = n/15; long bc = n/21; long ac = n/35;
//         // long ans = a+b+c -(ab+bc+ac) + (n/105);
//         // Console.WriteLine(ans);
//     }
// }
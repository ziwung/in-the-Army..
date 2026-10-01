using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
class Q42
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
        
    }
}
// class Q41
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
//         // // A41
//         // int n = NextInt();
//         // int[] a = new int[n];
//         // for(int i =0; i<n; i++)
//         // {
//         //     a[i] = NextInt();
//         // }
//         // bool ans = false;
//         // for(int i = 0; i < n - 2; i++)
//         // {
//         //     if(a[i]==0&&a[i+1]==0&&a[i+2]==0) ans = true;
//         //     if(a[i]==1&&a[i+1]==1&&a[i+2]==1) ans = true;
//         // }
//         // Console.WriteLine(ans);

//         // // B41
//         // int X = NextInt(); int Y = NextInt();
//         // char start = (X>Y)? 'X':'Y';
//         // string ans = "{start}";
//         // while (X == 1 && Y == 1)
//         // {
//         //     if (X > Y)
//         //     {
//         //         X = X-Y;
//         //         ans += 'X';
//         //     }
//         //     else if(X==Y)
//         //     {
//         //         ans = "판정불가";
//         //     }
//         //     else
//         //     {
//         //         Y = Y-X;
//         //         ans +='Y';
//         //     }
//         //     Console.WriteLine(ans);
//         // }
//     }
// }


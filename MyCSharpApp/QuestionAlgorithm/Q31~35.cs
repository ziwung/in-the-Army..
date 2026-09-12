using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
class Q32
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
    private static char NextChar() => char.Parse(NextToken());
    static void Main()
    {
        // A32
        int n = NextInt(); int a = NextInt(); int b = NextInt();
        (int max, int min) = (a>b) ? (a,b) : (b,a);
        if (n - max)
        {
            
        }
    }
}
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
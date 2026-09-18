using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
class Q37
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
        // // A37
        // int n = NextInt(); int m = NextInt(); int b = NextInt();
        // int[] a = new int[n]; int[] c = new int[m];
        // for(int i = 0; i< n; i++)
        // {
        //     a[i] = NextInt();
        // }
        // for(int i = 0; i<m; i++)
        // {
        //     c[i] = NextInt();
        // }
        // int sum = a.Sum()*m + c.Sum()*n + b*n*m;
        // Console.WriteLine(sum);

        // B37
        long n = (long)NextInt();
        long sum = 0;
        for(long i = 1; i<=9; i++)
        {
            for(long j = 10; j<1000000000000000L; j *= 10) sum += i*(n/j);
        }
        for(long i = 10;  i<1000000000000000L; i *= 10)
        {
            for(int j = 1; j <= (n%i)/(i/10); j++)
            {
                sum += j;
            }
        }
        Console.WriteLine(sum);
    }
}
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
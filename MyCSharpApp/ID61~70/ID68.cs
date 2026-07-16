using System;
using System.Linq;
class ID68
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine()!);
        int[] V = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

        
    }
    static int GDC(int a, int b) => (b==0) ? a:GDC(b,a%b); // 최소공배수
    static int LCM(int a, int b) => a*b/GDC(a,b);
}
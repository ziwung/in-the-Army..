// using System;
// using System.Linq;
// using System.Runtime.InteropServices;
// class ID68
// {
//     static void Main()
//     {
//         int N = int.Parse(Console.ReadLine()!);
//         int K = int.Parse(Console.ReadLine()!);
//         int[] V = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        

//         int ans = 0;
//         for(int i = 1; i < (1<<K); i++)
//         {
//             int cnt =0;
//             int lcm = 1;
//             for(int j=0; j<K; j++)
//             {
//                 if((i & (1 << j)) != 0)
//                 {
//                     cnt+=1;
//                     lcm = LCM(lcm,V[j]);
//                 }
//             }
//             int num = N/lcm;
//             if (cnt % 2==1)  //선택 갯수 홀수라면
//             {
//                 ans += num;
//             }
//             else
//             {
//                 ans -= num;
//             }
//         }
//         Console.WriteLine(ans);
//     }
//     static int GDC(int a, int b) => (b==0) ? a:GDC(b,a%b); // 최대공약수
//     static int LCM(int a, int b) => a*b/GDC(a,b); //최소공배수
// }
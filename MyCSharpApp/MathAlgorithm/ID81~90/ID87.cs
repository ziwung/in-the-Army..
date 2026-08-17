// using System;
// using System.Linq;
// using System.Numerics;
// class ID86
// {
//     static void Main()
//     {
//         long N = long.Parse(Console.ReadLine()!);
//         if (N == 1)
//         {
//             Console.WriteLine(1);
//         }
//         else
//         {
//             long ans = (N*(1+N)/2);
//             ans %= 1000000007;
//             ans *= ans;
//             Console.WriteLine(ans%1000000007); // tlqkf 합동법
//         }
//     }
// }
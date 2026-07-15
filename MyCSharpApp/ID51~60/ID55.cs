// using System;
// using System.Runtime.InteropServices.Marshalling;

// class ID55
// {
//     static long Mod = 1000000007;
//     static void Main()
//     {
//         long N = long.Parse(Console.ReadLine()!);

//         if (N == 1 || N == 2)
//         {
//             Console.WriteLine("1");
//         }

//         long[,] ror = new long[2, 2]
//         {
//             {3,1},
//             {1,0}
//         };
//         long[,] temp = new long[2, 2]
//         {
//             {2,1},
//             {1,0}
//         };

//         long n = N-3;
//         while (n > 0)
//         {
//             if (n % 2 != 0)
//             {
//                 ror = Power(ror,temp);
//             }
//             n /= 2;
//             temp = Power(temp,temp);
//         }
//         Console.WriteLine(ror[0,0]);
//     }
//     static long[,] Power(long[,] temp, long[,] temp2)
//     {
//         long[,] res = new long[2,2];
//         for(int i = 0; i < 2; i++)
//         {
//             for(int j=0; j<2; j++)
//             {
//                 res[i,j] = ((temp[i,0]*temp2[0,j])%Mod + (temp[i,1]*temp2[1,j])%Mod);
//             }
//         }
//         return res;
//     }
// }
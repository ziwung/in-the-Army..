// using System;
// using System.Linq;
// class ID67
// {
//     static void Main()
//     {
//         int H = int.Parse(Console.ReadLine()!);
//         int W = int.Parse(Console.ReadLine()!);
//         int[,] crossSumi=new int[H,W];
//         int[,] crossSum=new int[H,W];

//         for(int i =0; i < H; i++)
//         {
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//             for(int j = 0; j < W; j++)
//             {
//                 crossSumi[i,j] = input[j];
//             }
//         }

//         for(int i = 0; i < H; i++)
//         {
//             for(int j =0; j < W; j++)
//             {
//                 int sum = 0;
//                 for(int l = 0; l<H; l++)
//                 {
//                     sum += crossSumi[l,j];
//                 }
//                 for(int m = 0; m<H; m++)
//                 {
//                     sum += crossSumi[i,m];
//                 }
//                 crossSum[i,j] = sum - crossSumi[i,j];
//             }
//         }

//         for(int i =0; i<H; i++)
//         {
//             for(int j = 0; j < W; j++)
//             {
//                 Console.Write($"{crossSum[i,j]} ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
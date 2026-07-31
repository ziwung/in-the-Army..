// using System;
// using System.Linq;
// class ID85
// {
//     static void Main()
//     {
//         int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int N = input[0]; int X = input[1]; int Y = input[2]; bool canDo = false;

//         for(int i = 1; i < N - 2; i++)
//         {
//             for(int j = i; j < N - 1; j++)
//             {
//                 for(int k = j; k < N; k++)
//                 {
//                     for(int l = k; l <= N; l++)
//                     {
//                         if(i+j+k+l == X)
//                         {
//                             if(i*j*k*l == Y)
//                             {
//                                 canDo = true;
//                                 break;
//                             }
//                         }
//                     }
//                 }
//             }
//         }     
//         Console.WriteLine(canDo);   
//     }
// }
// using System;
// using System.Linq;
// class ID64
// {
//     static void Main()
//     {
//         int N = int.Parse(Console.ReadLine()!);
//         int K = int.Parse(Console.ReadLine()!);
//         int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

//         if (A.Sum() > K)
//         {
//             Console.WriteLine("불가능");
//         }
//         else
//         {
//             if ((K - A.Sum()) % 2 == 0)
//             {
//                 Console.WriteLine("가능");
//             }
//             else Console.WriteLine("불가능");
//         }

//     }
// }
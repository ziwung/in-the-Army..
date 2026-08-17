// using System;
// using System.Linq;
// class ID84
// {
//     static void Main()
//     {
//         int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int a = input[0]; int b = input[1]; int c = input[2];
//         if (c - a - b > 0)
//         {
//             if (4 * a * b < Math.Pow(c - a - b, 2))
//             {
//                 Console.WriteLine("성립");
//             }
//             else Console.WriteLine("안성립");
//         }else Console.WriteLine("안성립");
//     }
// }
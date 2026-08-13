// using System;
// using System.Linq;
// using System.Collections.Generic;
// class ID96{
//     static void Main(){
//         int N = int.Parse(Console.ReadLine()!);
//         int[] cookingTime = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         cookingTime.Sort();
//         Array.Reverse(cookingTime);

//         int oven1 = 0; int oven2 = 0;
//         for(int i = 0; i<N; i++)
//         {
//             Console.WriteLine(cookingTime[i]);
//             if (oven2 >= oven1)
//             {
//                 oven1 += cookingTime[i];
//             }
//             else
//             {
//                 oven2 += cookingTime[i];
//             }
//             Console.WriteLine($"1 : {oven1}, 2 : {oven2}");
//         }
//         int ans = (oven1>oven2)?oven1:oven2;
//         Console.WriteLine(ans);
//     }
// }
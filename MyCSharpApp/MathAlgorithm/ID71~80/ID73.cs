// using System;
// using System.Linq;
// class ID73
// {
//     static void Main(){
//         int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int L = input.Length; double sum = input[0];
        
//         if(L>1){
//             for(int i = 1; i < L; i++)
//             {
//                 sum += Math.Pow(2,i)*input[i];
//                 Console.WriteLine(sum);
//             }
//         }
//         Console.WriteLine(sum);
//     }
// }
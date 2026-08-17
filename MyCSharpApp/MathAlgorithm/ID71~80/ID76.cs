// using System;
// using System.Linq;
// class ID76
// {
//     static void Main(){
//         int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int N = input.Length; int ans = 0;
//         int[] A = input.OrderByDescending(n => n).ToArray(); //절댓값땜시 정렬해도 나오는 값은 동일
//         for(int i = 0; i < N; i++)
//         {
//             ans += input[i]*(-N+2*i+1); 
//         }
//         Console.WriteLine(ans);
//     }
// }
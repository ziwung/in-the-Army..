// using System;
// using System.Linq;
// class ID74
// {
//     static void Main(){
//         int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int N = input.Length; int ans = 0;
//         for(int i = 0; i < N; i++)
//         {
//             ans += input[i]*(-N+2*i+1); // 덧셈의 갯수 파악... ㅅㅂ
//         }
//         Console.WriteLine(ans);
//     }
// }
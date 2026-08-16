// using System;
// using System.Linq;
// using System.Collections.Generic;
// class ID95{
//     static void Main(){
//         int N = int.Parse(Console.ReadLine()!);
//         int[] ID95_class = new int[N]; int[] score = new int[N];
//         for(int i = 0; i<N; i++){
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//             ID95_class[i] = input[0];
//             score[i] = input[1];
//         }
//         int Q = int.Parse(Console.ReadLine()!);
//         int[,] quest = new int[Q,2];
//         for(int i=0;i<Q;i++){
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//             quest[i,0] = input[0];
//             quest[i,1] = input[1];
//         }

//         // 누적합 정의
//         int[] Sum1 = new int[N+1]; Sum1[0] = 0;
//         int[] Sum2 = new int[N+1]; Sum2[0] = 0;
//         (Sum1[1],Sum2[1]) = (ID95_class[0] == 1)? (score[0],0):(0,score[0]);
//         for(int i = 2; i<=N; i++)
//         {
//             Console.WriteLine(ID95_class[i-1]);
//             if(ID95_class[i-1] == 1)
//             {
//                 Sum1[i] += Sum1[i-1]+score[i-1];
//                 Sum2[i] += Sum2[i-1];
//             }
//             else
//             {
//                 Sum2[i] += Sum2[i-1]+score[i-1];
//                 Sum1[i] += Sum1[i-1];
//             }
//             Console.WriteLine($"1 : {Sum1[i]}, 2 : {Sum2[i]}");
//         }

//         //Q 계산
//         for(int i = 0; i<Q; i++)
//         {
//             Console.WriteLine($"{quest[i,0]}~{quest[i,1]}번호 중 1반의 점수합은 {Sum1[quest[i,1]]-Sum1[quest[i,0]-1]}");
//             Console.WriteLine($"{quest[i,0]}~{quest[i,1]}번호 중 2반의 점수합은 {Sum2[quest[i,1]]-Sum2[quest[i,0]-1]}");
//         }
//     }
// }
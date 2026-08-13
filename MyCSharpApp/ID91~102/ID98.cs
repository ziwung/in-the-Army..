// using System;
// using System.Linq;
// using System.Collections.Generic;
// using System.Runtime.Intrinsics.X86;
// class ID98{
//     static void Main(){
//         int N = int.Parse(Console.ReadLine()!);
//         int[,] nods = new int[N,2];
//         for(int i = 0; i<N; i++){
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//             nods[i,0]= input[0];
//             nods[i,1]= input[1];
//         }
//         int[] inp = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int A = inp[0]; int B = inp[1]; int count = 0;

//         for(int i = 0; i<N; i++)
//         {
//             (int ay,int ax, int by, int bx) = (nods[i,1]>nods[(i+1)%N,1])? (nods[i,1]-B,nods[i,0]-A,nods[(i+1)%N,0]-B, nods[(i+1)%N,0]-A) 
//             : (nods[(i+1)%N,1]-B, nods[(i+1)%N,0]-A ,nods[i,1]-B,nods[i,0]-A); // 나머지 테크닉 보임? N번쨰랑 1번째도 비교하기 위해
//             if(ay>=0&&by<0&&(ax*by - ay * bx) > 0)
//             {
//                 count += 1;
//             }           
//         }
//         if (count % 2 == 1)
//         {
//             Console.WriteLine("INSIDE");
//         }
//         else
//         {
//             Console.WriteLine("Outside");
//         }
//     }
// }
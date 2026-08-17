// // //내가 원래 짠 코드
// // using System;
// // using System.Net;    
// // class ID62
// // {
// //     static void Main()
// //     {
// //         long K = long.Parse(Console.ReadLine()!);
// //         int[] N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
// //         int nl = N.Length;
// //         int[] temp = new int[nl]; temp[0] = 1; List<int> circulation = new List<int>();
// //         int rt = 0; int count = 0; int circle = 0;
// //         for(int i = 0; i < nl; i++)
// //         {
// //             rt = (N[rt]-1);
// //             temp[rt]++;
// //             if (temp[rt] == 2)
// //             {
// //                 count = i;
// //                 circle = rt;
// //                 circulation.Add(circle);
// //             }
// //         }
// //         if (K <= count)
// //         {
// //             //count 보다 작으면 그냥 계산
// //             rt = 1;
// //             for(int i = 0; i < ; i++)
// //             {
// //                 rt = (N[rt]-1);
// //             }
// //             Console.WriteLine(rt);
// //         }else{
// //             // 순환구간 리스트 생성
// //             rt = (N[circle]-1);
// //             while(rt != circle)
// //             {
// //                 circulation.Add(rt);
// //                 rt = N[rt]-1;
// //             }
// //             K=K-count;
// //             K = K%circulation.Count;
// //             Console.WriteLine(N[K]);
// //         }
// //     }
// // }
// using System;
// using System.Collections.Generic;
// using System.Linq;

// // 제미나이와 함께 고친 코드
// class ID62
// {
//     static void Main()
//     {
//         long K = long.Parse(Console.ReadLine()!);
//         int[] N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int nl = N.Length;
        
//         int[] temp = new int[nl]; 
//         temp[0] = 1; // 시작점 방문 표시
        
//         List<int> circulation = new List<int>();
//         int rt = 0; 
//         int count = 0; // 사이클 진입 전까지의 이동 횟수
//         int circle = -1; // 순환 시작점
        
//         for(int i = 0; i < nl; i++)
//         {
//             rt = (N[rt]-1);
//             temp[rt]++;
//             if (temp[rt] == 2)
//             {
//                 count = i;      // 사이클 진입 전까지 총 i번 이동함
//                 circle = rt;    // 여기가 순환의 시작점!
//                 break;          // ★ 찾았으니 루프를 즉시 탈출해야 중복 추가가 안 됩니다!
//             }
//         }
        
//         if (K <= count)
//         {
//             // 사이클에 진입하기 전에 끝나는 경우 (처음부터 다시 시뮬레이션)
//             rt = 0; // 0번 마을에서 출발
//             for(int i = 0; i < K; i++) // count가 아니라 K만큼 이동
//             {
//                 rt = (N[rt]-1);
//             }
//             Console.WriteLine(rt + 1); // 1-based index로 변환하여 출력
//         }
//         else
//         {
//             // 순환구간 리스트 생성
//             circulation.Add(circle); // 순환 시작점 먼저 추가
//             rt = (N[circle]-1); //순환 시작점 바로 다음점 을 rt로 
//             while(rt != circle) //순환 시작점으로 돌아올때까지
//             {
//                 circulation.Add(rt); //순환 지점 추가
//                 rt = N[rt]-1;
//             }
            
//             // 전체 이동 횟수 K에서 사이클 진입 전까지의 이동(count + 1)을 빼줍니다.
//             // (i가 0부터 시작했으므로 실제 이동 횟수는 count + 1입니다)
//             long remainingK = K - (count + 1);
//             long targetIdx = remainingK % circulation.Count;
            
//             // 순환 리스트에서 노드를 꺼낸 뒤 + 1 해서 실제 마을 번호로 출력
//             Console.WriteLine(circulation[(int)targetIdx] + 1);
//         }
//     }
// }
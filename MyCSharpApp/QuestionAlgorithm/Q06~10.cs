// using System;
// using System.Linq;
// class Q10
// {
//     static void Main()
//     {
//         // A10
//         int N = int.Parse(Console.ReadLine()!);
//         int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int D = int.Parse(Console.ReadLine()!); int[,] cant = new int[D,2];
//         for(int i = 0; i<D; i++)
//         {
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray(); int max = 0;
//             for(int j = 0; j<N; j++)
//             {
//                 if (max < A[j]&&(j<input[0]-1||j>input[1]-1))
//                 {
//                     max = A[j];
//                 }
//             }
//             Console.WriteLine(max);
//         }
//     }
// }
// class Q09
// {
//     static void Main()
//     {
//     //     // A09
//     //     int[] HWN = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//     //     int H = HWN[0]; int W = HWN[1]; int N = HWN[2]; int[,] nods = new int[W+2,H+2];
//     //     for(int i = 0; i<N; i++)
//     //     {
//     //         int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//     //         nods[input[0],input[1]] += 1;
//     //         nods[input[0],input[3]+1] -= 1;
//     //         nods[input[2]+1,input[1]] -= 1;
//     //         nods[input[2]+1,input[3]+1] += 1;
//     //     }
//     //     int current = 0;
//     //     for(int i = 1; i<H+1; i++)
//     //     {
//     //         for(int j = 1; j<W+1; j++)
//     //         {
//     //             if (nods[j, i] != 0)
//     //             {
//     //                 current += nods[j,i];
//     //                 nods[j,i] = current;                        //근데 이렇게 2번씩 for문 더럽게 중간에 if 안넣어도 됨...
//     //             }                                               //가로일떄 이전값+현재값을 다 계산
//     //             else                                            //세로일때 이전값+현재값 계산하면 그냥 됨...
//     //             {
//     //                 nods[j,i] = current;
//     //             }
//     //         }
//     //     }
//     //     current = 0;
//     //     for(int j = 1; j<W+1; j++)
//     //     {
//     //         for(int i = 1; i<H+1; i++)
//     //         {
//     //             if (nods[j, i] != 0)
//     //             {
//     //                 current += nods[j,i];
//     //                 nods[j,i] = current;
//     //             }
//     //             else
//     //             {
//     //                 nods[j,i] = current;
//     //             }
//     //         }
//     //     }
//     //     for(int i = 1; i < H +1; i++)
//     //     {
//     //         Console.WriteLine($"{nods[1,i]} {nods[2,i]} {nods[3,i]} {nods[4,i]} {nods[5,i]}  ");
//     //     }
//     // B09
//     // 위랑 동일 한데 뭔가 문제가 이상함 그래서 스킵(진짜임..)
//     }
// }
// class Q08{
//     static void Main(){
//         // // A08
//         // int[] HW = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int H = HW[0]; int W = HW[1]; int[,] nods = new int[H+1,W+1];
//         // for(int i = 1; i<H+1; i++)
//         // {
//         //         int[] input1 = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         //         for(int j = 1; j<W+1; j++){
//         //             nods[i,j] = nods[i-1,j]+nods[i,j-1]-nods[i-1,j-1]+input1[j-1];
//         //         }
//         // }
//         // int Q = int.Parse(Console.ReadLine()!);
//         // int[,] quest = new int[Q,4];
//         // for(int j = 0; j < Q; j++){
//         //     int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         //     quest[j,0] = input[0]; quest[j,1] = input[1];
//         //     quest[j,2] = input[2]; quest[j,3] = input[3];
//         // }
//         // for(int i = 0; i<Q; i++)
//         // {
//         //     int ans = nods[quest[i,2],quest[i,3]]-nods[quest[i,2],quest[i,1]-1]-nods[quest[i,0]-1,quest[i,3]]+nods[quest[i,0]-1,quest[i,1]-1];
//         //     Console.WriteLine(ans);
//         // }
//         // B08
//         int N = int.Parse(Console.ReadLine()!); int[,] nods = new int[1501,1501];
//         for(int i = 0; i<N; i++)
//         {
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//             nods[input[0],input[1]] += 1;
//         }
//         for(int i = 1; i<1501; i++)
//         {
//             for(int j = 1; j<1501; j++)
//             {
//                 nods[i,j] = nods[i-1,j]+nods[i,j-1]-nods[i-1,j-1]+nods[i,j];
//             }
//         }
//         int Q = int.Parse(Console.ReadLine()!);
//         int[,] quest = new int[Q,4];
//         for(int j = 0; j < Q; j++){
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//             quest[j,0] = input[0]; quest[j,1] = input[1];
//             quest[j,2] = input[2]; quest[j,3] = input[3];
//         }
//         for(int i = 0; i<Q; i++)
//         {
//             int ans = nods[quest[i,2],quest[i,3]]-nods[quest[i,2],quest[i,1]-1]-nods[quest[i,0]-1,quest[i,3]]+nods[quest[i,0]-1,quest[i,1]-1];
//             Console.WriteLine(ans);
//         }
//     }
// }
// class Q07
// {
//     static void Main()
//     {
//         // //A07
//         // int D = int.Parse(Console.ReadLine()!);
//         // int N = int.Parse(Console.ReadLine()!);
//         // int[] Date = new int[D+2];
//         // for(int i = 0; i<N; i++)
//         // {
//         //     int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         //     Date[input[0]] += 1;
//         //     Date[input[1]+1] -= 1;
//         // }
//         // int sum = 0;
//         // for(int i = 1; i<D+1; i++)
//         // {
//         //     sum += Date[i];
//         //     Console.WriteLine($"{i}일차 참가자 수 : {sum}");
//         // }
//         // // B07
//         // int T = int.Parse(Console.ReadLine()!);
//         // int N = int.Parse(Console.ReadLine()!);
//         // int[] Time = new int[T+1];
//         // for(int i = 0; i<N; i++)
//         // {
//         //     int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         //     Time[input[0]] += 1;
//         //     Time[input[1]] -= 1;
//         // }
//         // int sum = 0;
//         // for(int i = 0; i<T; i++)
//         // {
//         //     sum += Time[i];
//         //     Console.WriteLine($"{i}시30분 일하는 종업원 수 : {sum}");
//         // }
//         // // 아 이름 잘못 커밋했넹
//     }
// }
// class Q06
// {
//     static void Main()
//     {
//         // // A06
//         // int Q = int.Parse(Console.ReadLine()!);  
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[,] Question = new int[Q,2]; int Alen = A.Length;
//         // for(int i = 0; i<Q; i++)
//         // {
//         //     int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         //     Question[i,0] = input[0];
//         //     Question[i,1] = input[1];
//         // }

//         // //누적값 행렬 만들기
//         // int[] sumA = new int[Alen+1]; sumA[0] = 0;
//         // for(int i = 1; i<Alen+1; i++)
//         // {
//         //     sumA[i] = sumA[i-1]+A[i-1];
//         // }

//         // // 질문 답하기
//         // for(int i = 0; i<Q; i++)
//         // {
//         //     Console.WriteLine($"{i+1}번 질문 답 : {sumA[Question[i,1]]-sumA[Question[i,0]-1]}");
//         // }
//         // B06
//         int Q = int.Parse(Console.ReadLine()!);
//         int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int[,] Question = new int[Q+1,2]; int Alen = A.Length;
//         for(int i = 1; i<Q+1; i++)
//         {
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//             Question[i,0] = input[0];
//             Question[i,1] = input[1];
//         }
//         int[] sumA = new int[Alen+1]; sumA[0] = 0;
//         for(int i = 1; i < Alen+1; i++)
//         {
//             if(A[i-1] == 0)
//             {
//                 sumA[i] = sumA[i-1]-1;
//             }else sumA[i] = sumA[i-1]+1;
//         }
//         // 질문 답하기
//         for(int i = 1; i<Q+1; i++)
//         {
//             int asap = sumA[Question[i,1]]-sumA[Question[i,0]-1];
//             if(asap >0){
//                 Console.WriteLine("당첨");
//             }else if(asap == 0)
//             {
//                 Console.WriteLine("동일");
//             }else Console.WriteLine("꽝");
//         }
//     }
// }

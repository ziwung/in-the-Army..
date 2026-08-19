using System;
using System.Linq;
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
class Q07
{
    static void Main()
    {
        // //A07
        // int D = int.Parse(Console.ReadLine()!);
        // int N = int.Parse(Console.ReadLine()!);
        // int[] Date = new int[D+2];
        // for(int i = 0; i<N; i++)
        // {
        //     int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        //     Date[input[0]] += 1;
        //     Date[input[1]+1] -= 1;
        // }
        // int sum = 0;
        // for(int i = 1; i<D+1; i++)
        // {
        //     sum += Date[i];
        //     Console.WriteLine($"{i}일차 참가자 수 : {sum}");
        // }
        // B07
        int T = int.Parse(Console.ReadLine()!);
        int N = int.Parse(Console.ReadLine()!);
        int[] Time = new int[T+1];
        for(int i = 0; i<N; i++)
        {
            int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            Time[input[0]] += 1;
            Time[input[1]] -= 1;
        }
        int sum = 0;
        for(int i = 0; i<T; i++)
        {
            sum += Time[i];
            Console.WriteLine($"{i}시30분 일하는 종업원 수 : {sum}");
        }
    }
}
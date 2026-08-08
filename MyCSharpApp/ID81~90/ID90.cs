// using System;
// using System.Collections.Generic;
// using System.Linq;

// class ID90
// {
//     static long Product(long m)
//     {
//         if (m == 0) return 0;
//         long sum = 1;
//         while (m > 0)
//         {
//             sum *= m % 10;
//             m /= 10;
//         }
//         return sum;
//     }

// // 파이썬의 func와 정확히 대응되는 구조 (자릿수 depth 기준)
//     static void FindFmCand(int digit, long m, HashSet<long> fm_cand)
//     {
//         // N이 10^11 이하이므로 자릿수는 최대 11자리(또는 12자리)까지 탐색
//         if (digit == 11) 
//         {
//             fm_cand.Add(Product(m));
//             return;
//         }

//         // 11자리가 되기 전이라도 중간중간 완성되는 수들의 곱을 넣고 싶다면 여기서 추가 가능
//         if (digit > 0)
//         {
//             fm_cand.Add(Product(m));
//         }

//         int minValue = (m == 0) ? 1 : (int)(m % 10);

//         for (int i = minValue; i <= 9; i++)
//         {
//             FindFmCand(digit + 1, m * 10 + i, fm_cand);
//         }
//     }

//     static void Main()
//     {
//         long[] input = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
//         long N = input[0];
//         long B = input[1];

//         HashSet<long> fm_cand = new HashSet<long>();
        
//         // 탐색 시작 (digit=0, m=0)
//         FindFmCand(0, 0, fm_cand);

//         long answer = 0;
//         foreach (long fm in fm_cand)
//         {
//             long m = fm + B;
//             long prodM = Product(m);
//             if (m - prodM == B && m <= N)
//             {
//                 answer++;
//             }
//         }

//         Console.WriteLine(answer);
//     }
// }
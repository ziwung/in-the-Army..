// using System;
// using System.Linq;
// using System.Collections.Generic;
// class Id51
// {
//     static void Main()
//     {
//         int[] input = (Console.ReadLine() ?? "0 0")
//             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//             .Select(int.Parse)
//             .ToArray();
//         (int max, int min) = (input[0] > input[1]) ? (input[0], input[1]) : (input[1], input[0]);

//         long M = 1000000007;
//         long top = 1;
//         long bottom = 1;
//         long currentNumerator = (long)max + min; 
        
//         for (int i = 1; i <= min; i++)
//         {
//             top = (top * currentNumerator) % M;
//             bottom = (bottom * i) % M;
            
//             currentNumerator--; // 다음 루프를 위해 1을 빼줍니다.
//         }

//         long temp = bottom;
//         long @base = 1;         // 3. 초기값은 bottom이 아니라 1이어야 함
//         long exp = M - 2;       // 2. 페르마의 소정리에 의해 구해야 하는 지수는 M - 2

//         for (int j = 0; j <= 30; j++)
//         {
//             // 2 & 4. M 대신 exp를 검사하고, 1L로 long 타입 비트 이동
//             if ((exp & (1L << j)) != 0)
//             {
//                 @base = (@base * temp) % M;
//             }
//             temp = (temp * temp) % M;
//         }

//         long ans = (@base * top) % M;
//         Console.WriteLine(ans);
//     }
// }
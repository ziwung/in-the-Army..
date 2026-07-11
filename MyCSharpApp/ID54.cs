// using System;

// class ID54
// {
//     static void Main()
//     {
//         int N = int.Parse(Console.ReadLine()!);
//         if (N <= 2)
//         {
//             Console.WriteLine(1);
//             return;
//         }

//         // 단위 행렬
//         long[,] ror = {
//             { 1, 0 },
//             { 0, 1 }
//         };

//         // 피보나치 기본 변환 행렬
//         long[,] temp = {
//             { 1, 1 },
//             { 1, 0 }
//         };

//         int n = N - 1; // N번째 피보나치 수를 구하기 위해 행렬을 N-1번 거듭제곱합니다.

//         // 반복 제곱법
//         while (n > 0)
//         {
//             if (n % 2 != 0)
//             {
//                 ror = MultiplyMatrix(ror, temp);
//             }
//             temp = MultiplyMatrix(temp, temp);
//             n /= 2; // n 관리는 여기서만 깔끔하게 진행!
//         }

//         Console.WriteLine(ror[0, 0]);
//     }

//     // 행렬 곱셈
//     static long[,] MultiplyMatrix(long[,] A, long[,] B)
//     {
//         long[,] result = new long[2, 2];
//         for (int i = 0; i < 2; i++)
//         {
//             for (int j = 0; j < 2; j++)
//             {
//                 result[i, j] = A[i, 0] * B[0, j] + A[i, 1] * B[1, j];
//             }
//         }
//         return result;
//     }
// }
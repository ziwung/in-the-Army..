// using System;
// using System.Linq;
// using System.Collections.Generic;

// class ID100
// {
//     // //하수의 풀이
//     // static void Main()
//     // {
//     //     int Q = int.Parse(Console.ReadLine()!);
//     //     double[,] nods = new double[Q,3];
//     //     int[] Time = new int[Q];
//     //     for(int i = 0; i<Q; i++){
//     //         double[] input = Console.ReadLine()!.Split(' ').Select(double.Parse).ToArray();
//     //         nods[i,0]= input[0]; //X
//     //         nods[i,1]= input[1]; //Y
//     //         nods[i,2]= input[2]; //Z
//     //         Time[i]= (int)input[3]; //T
//     //     }
//     //     for(int i = 0; i<Q; i++)
//     //     {
//     //         (double a, double b, double c) = Chku(Time[i],nods[i,0],nods[i,1],nods[i,2],1.0d,1.0d,1.0d,1);
//     //         Console.WriteLine($"{a}\n{b}\n{c}\n");
//     //     }
//     // }
//     // static (double,double,double) Chku(int T, double one, double two,double three, double a, double b, double c,int count)
//     // {
//     //     if (count >= T)
//     //     {
//     //         return ((1-one)+two,(1-two)+three,(1-three)+one);
//     //     }
//     //     (double aa, double bb, double cc)=Chku(T, one, two,three,a,b,c,++count);
//     //     return (aa*(1-one)+bb*two,bb*(1-two)+cc*three,cc*(1-three)+aa*one);
//     // }
    
//     //고수의 풀이
//     static void Main()
//     {
//         int Q = int.Parse(Console.ReadLine()!);
//         double[,] nods = new double[Q,3];
//         int[] Time = new int[Q];
//         for(int i = 0; i<Q; i++){
//             double[] input = Console.ReadLine()!.Split(' ').Select(double.Parse).ToArray();
//             nods[i,0]= input[0]; //X
//             nods[i,1]= input[1]; //Y
//             nods[i,2]= input[2]; //Z
//             Time[i]= (int)input[3]; //T
//         }
//         for(int i = 0; i < Q; i++){
//             double[,] defaultsu = new double[,]{
//                 {1-nods[i,0], nods[i,1],0},
//                 {0,1-nods[i,1],nods[i,2]},
//                 {nods[i,0],0,1-nods[i,2]}
//             };
//             MatrixPowers(defaultsu, Time[i]);

//         }
//     }
//     // // 시행착오 : current2값을 곱하는 계산뒤에 그대로 다시 곱해서 2 4 8 16이 아닌 2 4 16 196 이런식으로 늘어나게됨
//     // static void MatrixPowers(double[,] matrix, int T)
//     // {
//     //     int C = 1; 
//     //     double[,] current = (double[,])matrix.Clone(); 
//     //     double[,] current2 = (double[,])matrix.Clone(); 
//     //     double[] sum = new double[3]{1,1,1}; 

//     //     while (T > C)
//     //     {
//     //         if ((T & (C << 1)) != 0)
//     //         {
//     //             for (int i = 0; i < 3; i++)
//     //             {
//     //                 current[i, 0] = current2[i,0]*current2[0,0]+current2[i,1]*current2[1,0]+current2[i,2]*current2[2,0];
//     //                 current[i, 1] = current2[i,0]*current2[0,1]+current2[i,1]*current2[1,1]+current2[i,2]*current2[2,1];
//     //                 current[i, 2] = current2[i,0]*current2[0,2]+current2[i,1]*current2[1,2]+current2[i,2]*current2[2,2];
//     //             }
//     //             current2 = (double[,])current.Clone();
//     //             sum[0] += current[0,0]+current[0,1]+current[0,2];
//     //             sum[1] += current[1,0]+current[1,1]+current[1,2];
//     //             sum[2] += current[2,0]+current[2,1]+current[2,2];
//     //         }
//     //         C <<= 1;
//     //     }
//     //     Console.WriteLine($"{sum[0]}  {sum[1]}  {sum[2]}");
//     // }
//     static double[,] MultiplyMatrix(double[,] a, double[,] b)
//     {
//         double[,] result = new double[3, 3];
//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 result[i, j] = 0;
//                 for (int k = 0; k < 3; k++)
//                 {
//                     result[i, j] += a[i, k] * b[k, j];
//                 }
//             }
//         }
//         return result;
//     }

//     static void MatrixPowers(double[,] matrix, int T)
//     {
//         // 1. 단위 행렬(Identity Matrix) 초기화
//         double[,] res = new double[,] {
//             { 1, 0, 0 },
//             { 0, 1, 0 },
//             { 0, 0, 1 }
//         };

//         double[,] baseMat = (double[,])matrix.Clone();

//         // 2. 이진 거듭제곱 (Binary Exponentiation)
//         int power = T;
//         while (power > 0)
//         {
//             if ((power & 1) == 1)
//             {
//                 res = MultiplyMatrix(res, baseMat);
//             }
//             baseMat = MultiplyMatrix(baseMat, baseMat);
//             power >>= 1;
//         }

//         // 3. 초기 벡터 [1, 1, 1]에 최종 거듭제곱된 행렬을 곱함 (원하시는 연산에 따라 조정 가능)
//         // 만약 행렬 자체의 합을 원하시는 거라면 이 부분을 목적에 맞게 수정하세요.
//         double[] initialVector = { 1, 1, 1 };
//         double[] finalSum = new double[3];

//         for (int i = 0; i < 3; i++)
//         {
//             finalSum[i] = 0;
//             for (int k = 0; k < 3; k++)
//             {
//                 finalSum[i] += res[i, k] * initialVector[k];
//             }
//         }

//         Console.WriteLine($"{finalSum[0]}  {finalSum[1]}  {finalSum[2]}");
//     }
// }
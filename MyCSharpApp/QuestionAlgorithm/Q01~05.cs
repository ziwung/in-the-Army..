// using System;
// class Q01{
//     static void Main(){
//         // // A01
//         // Console.WriteLine(Math.Pow(int.Parse(Console.ReadLine()!),2));
//         // // B01
//         // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // Console.WriteLine(input[0]+input[1]);
//         // // A02 (완전탐색)
//         // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int X = int.Parse(Console.ReadLine()!); string iscon = "No";
//         // for(int i = 0; i<input.Length; i++)
//         // {
//         //     if(input[i] == X)
//         //     {
//         //         iscon = "Yes";
//         //     }
//         // }
//         // Console.WriteLine(iscon);
//         // // B02
//         // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // string iscon = "No";
//         // for(int i = input[0]; i <= input[1]; i++) 
//         // {
//         //     if (i == 1 || i == 2 || i == 4 || i == 5 || i == 10 || i == 20 || i == 25 || i == 50 || i == 100)
//         //     {
//         //         iscon = "Yes";
//         //     }
//         // }
//         // Console.WriteLine(iscon);
//         // // A03
//         // int[] P = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[] Q = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int X = int.Parse(Console.ReadLine()!); string iscon = "No";
//         // for(int i = 0; i <P.Length; i++)
//         // {
//         //     for(int j = 0; j<Q.Length; j++)
//         //     {
//         //         if(P[i]+Q[j] == X) iscon = "yes";
//         //     }
//         // }
//         // Console.WriteLine(iscon);
//         // // B03
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int al = A.Length; string iscon = "No";
//         // for(int i = 0; i < al - 2; i++)
//         // {
//         //     for(int j = i+1; j < al - 1; j++)
//         //     {
//         //         for(int k = j+1; k < al; k++)
//         //         {
//         //             if(A[i]+A[j]+A[k] == 1000) iscon = "Yes";
//         //         }
//         //     }
//         // }
//         // Console.WriteLine(iscon);
//         // // A04
//         // int N = int.Parse(Console.ReadLine()!);
//         // Console.WriteLine($"{Convert.ToString(N,2).PadLeft(8,'0')}");
//         // // B04
//         // int N = int.Parse(Console.ReadLine()!);int ans = 0; int weight = 1; 
//         // while (N > 0)
//         // {
//         //     if (N % 10 == 1)
//         //     {
//         //         ans += weight;
//         //     }
//         //     N/=10;
//         //     weight *=2;
//         // }
//         // Console.WriteLine(ans);
//         // // A05
//         // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int N = input[0]; int K = input[1];
//         // int count = 0;
//         // for(int i = 1; i<=N; i++)
//         // {
//         //     for(int j = 1; j<=N; j++)
//         //     {
//         //         int k = K-i-j;
//         //         if (k > 0 && k <= N)
//         //         {
//         //             count++;
//         //         }
//         //     }
//         // }
//         // Console.WriteLine(count);
//         // }
//     }
// }
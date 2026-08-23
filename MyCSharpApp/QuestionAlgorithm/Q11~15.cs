using System;
using System.Linq;
// class Q12
// {
//     static void Main()
//     {
//         // // A12
//         // int K = int.Parse(Console.ReadLine()!);
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int bot = 1; int top = 1000000000;
//         // int ans = FindValue(bot, top, A, K);
//         // Console.WriteLine(ans);
//         // B12
//     long N = long.Parse(Console.ReadLine()!);
//         // N의 범위 10억이하로 설정
//         long bot = 0;  long top = 1000; // x^3이니 굳이 10억 다 살펴볼 필요 없음  
//         while(bot<=top){
//             long mid = (bot+top)/2;
//             long sum = mid*mid*mid+mid;
//             if(sum == N)
//             {
//                 Console.WriteLine(mid);
//                 break;
//             }
//             if (sum <= N)
//             {
//                 bot = mid+1;
//             }
//             else
//             {
//                 top = mid-1;
//             }
//         }

//     }
//     static int FindValue(int bot, int top,int[] arr,int X)
//     {
//         int time = 0;
//         while(bot<top){
//             time = (bot+top)/2;
//             int sum = 0;
//             for(int i = 0; i<arr.Length; i++)
//             {
//                 sum += time/arr[i];
//             }
//             if (sum <= X)
//             {
//                 bot = time+1;
//             }
//             else
//             {
//                 top = time;
//             }
//         }
//         return time+1;
//     }
// }
// class Q11
// {
//     static void Main()
//     {
//         // // A11
//         // int X = int.Parse(Console.ReadLine()!);
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int ans = FindValue(A, X);
//         // Console.WriteLine(ans);

//         // B11
//         int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         int Q = int.Parse(Console.ReadLine()!); int[] Qq = new int[Q];
//         for(int i = 0; i<Q; i++)
//         {
//             int ans = FindValue(A,int.Parse(Console.ReadLine()!));
//             Console.WriteLine(ans-1);
//         }        
//     }
//     static int FindValue(int[] arr,int X)
//     {
//         int bot = 0;
//         int top = arr.Length-1;
//         while(bot<=top){
//             int mid = (bot+top)/2;
//             if (arr[mid] < X)
//             {
//                 bot = mid+1;
//             }else if(arr[mid] == X) return mid + 1;
//             else
//             {
//                 top = mid-1;
//             }
//         }
//         return -1;
//     }
// }
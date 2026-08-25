using System;
using System.Linq;
using System.Collections.Generic;
class Q15{
    static void Main(){
        // A15 근데 이거 1초 초과하긴함..
        int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int[] arank = A.OrderBy(n=>n).ToArray();
        List<int> a = new List<int>(); a.Add(arank[0]);
        for(int i=1; i<A.Length; i++)
        {
            if(arank[i] != arank[i - 1])
            {
                a.Add(arank[i]);
            }
        }
        int[] ans = new int[A.Length];int count = 1;
        for(int i = 0; i<a.Count; i++)
        {
            for(int j = 0; j<A.Length; j++)
            {
                if(a[i] == A[j]) ans[j] = count;
            }
            count++;
        }
        for(int j = 0; j<A.Length; j++)
        {
            Console.WriteLine(ans[j]);
        }
    }
}
// class Q14
// {
//     static void Main()
//     {
//         // // A14
//         // int K = int.Parse(Console.ReadLine()!);
//         // // 정렬된 배열로만 입력된다 가정
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[] B = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[] C = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int[] D = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int n = A.Length;
//         // int[] p = new int[n*n]; int[] q = new int[n*n]; int now = 0;
//         // for(int i = 0; i< n; i++)
//         // {
//         //     for(int j = 0; j< n; j++)
//         //     {
//         //         p[now] = A[i]+B[j];
//         //         q[now] = C[i]+D[j];
//         //         now++;
//         //     }
//         // }
//         // for(int i = 0; i<n*n; i++)
//         // {
//         //     if (FindValue(q, K - p[i]))
//         //     {
//         //         Console.WriteLine("Yes");
//         //     }else Console.WriteLine("NO");
//         // }

//         // B14
//         // 진짜 억지로 이진탐색범위를 맞추는거임..? 
//         // 앞부분 N/2 거기서 나올수있는 범위 구하고, 뒷부분 N/2에서 나올수있는 숫자범위 구하고...
//     }
//     static bool FindValue(int[] arr,int X)
//     {
//         int bot = 0; int top = arr.Length-1;
//         int mid = (bot+top)/2;
//         while(bot<top){
//             mid = (bot+top)/2;
//             if (arr[mid] < X)
//             {
//                 bot = mid+1;
//             }else if(arr[mid] == X) return true;
//             else
//             {
//                 top = mid-1;
//             }
//         }
//         return false;
//     }
// }
// class Q13
// {
//     static void Main()
//     {
//         // // A13
//         // // 자벌래 알고리즘 O(N)
//         // int K = int.Parse(Console.ReadLine()!);
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int n = A.Length;
//         // long sum = 0; 

//         // int right = 0;
//         // for (int left = 0; left < n; left++)
//         // {
//         //     while (right < n && A[right] - A[left] <= K)
//         //     {
//         //         right++;
//         //     }
//         //     sum += (right - 1) - left;
//         // }

//         // Console.WriteLine(sum);

//         // // 바이너리 탐색 풀이 O(NlogN)
//         // int K = int.Parse(Console.ReadLine()!);
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int sum = 0; int al = A.Length;
//         // for(int i = 0; i<al-1; i++)
//         // {
//         //     sum += FindValue(i+1, al-1,A,K+A[i]);
//         // }
//         // Console.WriteLine(sum);

//         // // B13
//         // int K = int.Parse(Console.ReadLine()!);
//         // int[] A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray(); int al = A.Length;
//         // int[] B = new int[al+1];
//         // for(int i = 1; i<al+1; i++)
//         // {
//         //     B[i] = B[i-1] + A[i-1];
//         // }
//         // int right = 1; int sum = 0;
//         // for(int left = 0; left<al+1; left++)
//         // {
//         //     while (right < al+1 && B[right] - B[left] <= K)
//         //     {
//         //         right++;
//         //     }
//         //     sum += (right-1) - left;
//         // }
//         // Console.WriteLine(sum);
//     }
//     static int FindValue(int bot,int top, int[] arr,int X)
//     {
//         int mid = (bot+top+1)/2;
//         int dbot = bot-1;
//         while(bot<top){
//             mid = (bot+top)/2;
//             if (arr[mid] <= X)
//             {
//                 bot = mid;
//             }
//             else
//             {
//                 top = mid-1;
//             }
//         }
//         if (arr[bot] > X) return 0;
//         return bot-dbot;
//     }
// }
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
//             if (sum < X)
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
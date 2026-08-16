// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Threading;

// class ID99
// {
//     static void Main()
//     {
//         // 깊은 재귀 호출을 위해 스택 크기를 64MB로 늘린 새로운 스레드에서 실행
//         Thread t = new Thread(Solve, 1024 * 1024 * 64);
//         t.Start();
//         t.Join();
//     }

//     static void Solve()
//     {
//         using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
//         using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
//         {
//             string line = sr.ReadLine();
//             if (string.IsNullOrEmpty(line)) return;
//             int N = int.Parse(line);

//             // 인접 리스트 생성
//             List<int>[] G = new List<int>[N + 1];
//             for (int i = 0; i <= N; i++)
//             {
//                 G[i] = new List<int>();
//             }

//             for (int i = 0; i < N - 1; i++)
//             {
//                 string[] parts = sr.ReadLine().Split();
//                 int u = int.Parse(parts[0]);
//                 int v = int.Parse(parts[1]);
//                 G[u].Add(v);
//                 G[v].Add(u);
//             }

//             bool[] visited = new bool[N + 1];
//             int[] dp = new int[N + 1];

//             // DFS 실행
//             Dfs(1, G, visited, dp);

//             // 답을 계산 (오버플로우 방지를 위해 long 타입 사용)
//             long answer = 0;
//             for (int i = 2; i <= N; i++)
//             {
//                 answer += (long)dp[i] * (N - dp[i]);
//             }

//             sw.WriteLine(answer);
//         }
//     }

//     // 깊이 우선 탐색 함수
//     static void Dfs(int pos, List<int>[] G, bool[] visited, int[] dp)
//     {
//         visited[pos] = true;
//         dp[pos] = 1;
//         foreach (int i in G[pos])
//         {
//             if (!visited[i])
//             {
//                 Dfs(i, G, visited, dp);
//                 dp[pos] += dp[i];
//             }
//         }
//     }
// }
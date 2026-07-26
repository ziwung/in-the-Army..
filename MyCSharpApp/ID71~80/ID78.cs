// using System;
// using System.Linq;

// class ID78
// {
//     static void Main()
//     {
//         int N = int.Parse(Console.ReadLine()!);
//         int M = int.Parse(Console.ReadLine()!);
//         int[] A = new int[N+1];
//         for(int i=0; i<N+1; i++)
//         {
//             A[i] = -1;
//         }
//         List<int>[] nums = new List<int>[N+1]; 
//         for(int i = 0; i<N+1; i++)
//         {
//             nums[i] = new List<int>();
//         }
//         for(int i=0;i<M;i++){
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//             nums[input[0]].Add(input[1]);
//             nums[input[1]].Add(input[0]);
//         }

//         Queue<int> queue = new Queue<int>();
//         queue.Enqueue(1);
//         A[1] = 0;
//         while (queue.Count() > 0)
//         {
//             int temp = queue.Dequeue();
//             for(int i=0; i < nums[temp].Count; i++)
//             {
//                 if (A[nums[temp][i]] < 0)
//                 {
//                     A[nums[temp][i]] = A[temp]+1;
//                     queue.Enqueue(nums[temp][i]);
//                 }
//             }
//         }
//         foreach(int a in A)
//         Console.WriteLine(a);
//     }
// }
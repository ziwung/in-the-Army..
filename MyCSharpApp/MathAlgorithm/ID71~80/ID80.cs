// using System;
// using System.Linq;
// class Nod
// {
//     public int Index {get;set;}
//     public int Value {get;set;}
//     public Nod(int index,int value)
//     {
//         Index = index;
//         Value = value;   
//     }
// }
// class ID80
// {
//     static void Main()
//     {
//         int N = int.Parse(Console.ReadLine()!);
//         int M = int.Parse(Console.ReadLine()!);
//         int[] x = new int[N+1]; List<Nod>[] nods = new List<Nod>[N+1];
//         for(int i = 0; i<N+1; i++)
//         {
//             x[i] = int.MaxValue;
//             nods[i] = new List<Nod>();
//         }
//         for(int i = 0; i<M; i++)
//         {
//             int[] input = Console.ReadLine()!.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
//             nods[input[0]].Add(new Nod(input[1],input[2]));
//             nods[input[1]].Add(new Nod(input[0],input[2]));
//         }
//         PriorityQueue<int,int> q = new PriorityQueue<int,int>();
//         x[0] = -1;
//         x[1] = 0;
//         q.Enqueue(1,0);
//         while (q.Count > 0)
//         {
//             int temp= q.Dequeue();
//             for(int i =0; i < nods[temp].Count; i++)
//             {
//                 int cValue = nods[temp][i].Value; //현재 살펴보는 노드의 가중치
//                 int cIndex = nods[temp][i].Index; // 현재 살펴보는 노드의 인덱스(번호)
//                 if(cValue+x[temp] < x[cIndex])
//                 {
//                     q.Enqueue(cIndex,cValue+x[temp]);
//                     x[cIndex] = cValue+x[temp];
//                 }
//             }
//         }
//         Console.WriteLine(x.Max()); // 컷! 
//     }
// }
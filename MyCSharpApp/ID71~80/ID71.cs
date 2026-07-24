// using System;
// using System.Linq;
// class ID71
// {
//     static void Main(){
//         int N = int.Parse(Console.ReadLine()!);
//         double max = 0;

//         int[,] nod = new int[N,3];
//         for(int i = 0; i < N; i++)
//         {
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//             nod[i,0] = input[0];
//             nod[i,1] = input[1];
//             nod[i,2] = input[2];
//         }
//         max = XplusYMax(nod,N);
//         Console.WriteLine(max);
//     }
//     static double XplusYMax(int[,] nod, int N)
//     {
//         double max = 0;
//         double y = 0; double x = 0;
//         for(int i =0; i<N; i++)
//         {
//             for(int j = i+1;j<N;j++){
//                 x = (nod[i,2]*nod[j,1]-nod[j,2]*nod[i,1])/(double)(nod[i,0]*nod[j,1]-nod[j,0]*nod[i,1]);

//                 y = (nod[i,2]-nod[i,0]*x)/(double)nod[i,1];
//                 if (x >= 0&&y >= 0){
//                     max=Math.Max(max,x+y);
//                     Console.WriteLine(max);
//                 }
//             }
//         }
//         return max;
//     }
// }
// using System;
// using System.Dynamic;
// using System.Linq;
// class Dot
// {
//     public int x {get;set;}
//     public int y {get;set;}
// }
// class ID77
// {
//     static void Main(){
//         int N = int.Parse(Console.ReadLine()!);
//         Dot[] dots = new Dot[N];
//         for(int i=0;i<N;i++){
//             dots[i] = new Dot();
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//             dots[i].x = input[0];
//             dots[i].y = input[1];
//         }
//         int ans = 0;
//         Dot[] xdots = dots.OrderBy(n => n.x).ToArray();
//         Dot[] ydots = dots.OrderBy(n => n.y).ToArray();
//         for(int i =0; i < N; i++)
//         {
//             ans += xdots[i].x*(-N+2*i+1); 
//             ans += ydots[i].y*(-N+2*i+1);
//         }
//         Console.WriteLine(ans);
//     }
// }
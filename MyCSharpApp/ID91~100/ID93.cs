// using System;
// using System.Linq;
// using System.Collections.Generic;
// class ID93{
//     static void Main(){
//         long[] input = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
//         long A = input[0]; long B = input[1];
//         long ans = LCM(A, B);
//         if(ans>Math.Pow(10,18)){
//             Console.WriteLine("Large");
//         }else{
//             Console.WriteLine(ans);
//         }
//     }
//     static long LCM(long a, long b)=> a*b/GDC(a,b);
//     static long GDC(long a, long b) => (a==0)? b:GDC(b%a,a);
// }
// using System;
// using System.Linq;
// public class MovieTime : IComparable<MovieTime>
// {
//     public int startTime{get;set;}
//     public int endTime{get;set;}
//     public MovieTime(int startTime,int endTime)
//     {
//         this.startTime = startTime;
//         this.endTime = endTime;
//     }
//     public int CompareTo(MovieTime? other) // 물음표는 null 허용연산자이다. 인터페이스 CompareTo는 매개변수 null 허용이라
//     {                                      // 구현부도 맞춰주기위해 MovieTime?를 넣는것이다.
//         if(other == null) return 1;
//         return this.endTime.CompareTo(other.endTime);
//     }
// }
// class ID82
// {
//     static void Main()
//     {
//         int N = int.Parse(Console.ReadLine()!);
//         MovieTime[] mt = new MovieTime[N];
//         for(int i=0; i<N; i++)
//         {
//             int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//             mt[i] = new MovieTime(input[0],input[1]);
//         }
//         mt.Sort();
//         int ccusor=0;int ncusor =1;int count = 1;
//         while (ncusor < N)
//         {
//             if (mt[ccusor].endTime < mt[ncusor].endTime)
//             {
//                 ccusor = ncusor;
//                 count++;
//                 ncusor += 1;
//             }
//             ncusor += 1;
//         }
//         Console.WriteLine(count);
//     }
// }
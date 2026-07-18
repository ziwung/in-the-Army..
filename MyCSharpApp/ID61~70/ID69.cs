// using System;
// class ID69
// {
//     static void Main()
//     {
//         // // 더 간단한 답...
//         // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // int temp = Math.Max(input[1]*input[3],input[0]*input[3]);
//         // temp = Math.Max(temp,input[0]*input[2]);
//         // temp = Math.Max(temp,input[1]*input[2]);

//         // // 장지웅의 레전드 비효율 코드
//         // int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//         // if (input[1] > 0 && input[3] > 0)
//         // {
//         //     //큰 수 두개 다 양수
//         //     if(input[0]<0&&input[2]<0){
//         //         //작은 수 두개 다 음수
//         //         int ans = (input[1]*input[3]>input[0]*input[2]) ? input[1]*input[3]:input[0]*input[2];
//         //         Console.WriteLine(ans);
//         //     }
//         //     else
//         //     {
//         //         //작은수는 짝짝이
//         //         Console.WriteLine(input[1]*input[3]);
//         //     }
//         // }
//         // else
//         // {
//         //     //큰 수 짝짝이
//         //     if (input[0] < 0 && input[2] < 0)
//         //     {
//         //         //큰수 짝짞 작은수 음수

//         //         Console.WriteLine(input[0]*input[2]);
       
//         //     }
//         //     else
//         //     {
//         //         //큰수 짝짝 작은수 짝짝
//         //         if(input[1]<0){
//         //             Console.WriteLine(input[1]*input[2]);
//         //         }
//         //         else
//         //         {
//         //             Console.WriteLine(input[0]*input[3]);
//         //         }
//         //     }
//         // }
//     }
// }
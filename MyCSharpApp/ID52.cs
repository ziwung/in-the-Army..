// using System;
// using System.Linq;
// using System.Collections.Generic;

// class ID52
// {
//     static void Main()
//     {
//         int[] input = (Console.ReadLine()??"0 0").Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
//         int x= input[0]; int y = input[1];
//         long xnum = 0; long ynum = 0;
//         if (x % 2 == 0)
//         {
//             xnum = x/2;
//             ynum = (y - xnum)/3*2;
//             xnum -= ynum/2;
//         }
//         else
//         {
//             xnum = (x-1)/2;
//             ynum = 1+2*((y-xnum+1)/3-1);
//             xnum -= (ynum-1)/2;
//         }
//         Console.WriteLine($"현재 xnum = {xnum}, ynum = {ynum}");

//         //분자 분모 구하고 펙토리얼 약분으로 계산하는중 
//         long MOD = 1000000007;
//         (long max, long min) = (xnum>ynum)?(xnum, ynum): (ynum,xnum); long bunja=1; long bunmo=1; 
//         for(int i=1; i <= min; i++)
//         {
//             bunja = (bunja*((max+min)-i+1)) % MOD;
//             bunmo = (bunmo * i) % MOD;
//         }
        
//         //거듭 제곱법으로 페르마 소정리 이용 모듈러 역수 계산중
//         long @base = 1;
//         long temp = bunmo;
//         for(int i = 0; i<=30; i++)
//         {
//             if(((MOD-2)& 1L << i)!=0)
//             {
//                 @base = (@base*temp)%MOD;
//             }
//             temp = (temp*temp)%MOD;
//         }
//         Console.WriteLine($"현재 @base = {@base}, bunja = {bunja}");
//         // 답 계산
//         long ans = (bunja*@base)%MOD;
//         Console.WriteLine(ans);
//     }
// }
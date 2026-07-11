using System;
using System.Runtime.InteropServices.Marshalling;

class ID56
{
    static long Mod = 1000000007;
    static void Main()
    {
        long N = long.Parse(Console.ReadLine()!);

        int a = (N<3)? 1:2;
        if (N <4)
        {
            Console.WriteLine(a);
        }
        // 트리보나치 수열
        long[,] ror = new long[3, 3]
        {
            {4,0,0},
            {2,0,0},
            {1,0,0}
        };
        long[,] temp = new long[3, 3]
        {
            {1,1,1},
            {1,0,0},
            {0,1,0}
        };

        long n = N-4; //4까지는 이미 구해진값임
        while (n > 0)
        {
            if (n % 2 != 0)
            {
                ror = Power(temp, ror);
            }
            n /= 2;
            temp = Power(temp,temp);
        }
        Console.WriteLine(ror[0,0]);
    }
    static long[,] Power(long[,] temp, long[,] temp2)
    {
        long[,] res = new long[3,3];
        for(int i = 0; i < 3; i++)
        {
            for(int j=0; j<3; j++)
            {
                res[i,j] = ((temp[i,0]*temp2[0,j])%Mod + (temp[i,1]*temp2[1,j])%Mod + (temp[i,2]*temp2[2,j])%Mod)%Mod;
            }
        }
        return res;
    }
}
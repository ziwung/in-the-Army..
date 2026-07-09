using System;
using System.Linq;
using System.Collections.Generic;

class ID53
{
    static long MOD = 1000000007;
    static void Main()
    {
        // 간단하고 무식한 방식
        int N = int.Parse(Console.ReadLine()!);
        long sum = 1;
        long temp = 4;
        
        for (int i=1; i <= N; i++)
        {
            sum += temp;
            sum = sum%MOD;
            temp = (temp*4)%MOD;
        }
        Console.WriteLine(sum);

        // N이 매우 클 수 있으므로 long으로 받습니다.
        long N2 = long.Parse(Console.ReadLine()!);

        // 1. 4^(N+1) % MOD 구하기
        long powerOfFour = Power(4, N + 1);

        // 2. 분자 계산 (4^(N+1) - 1)
        // 만약 0이 되면 음수가 될 수 있으므로 MOD를 더해줍니다.
        long numerator = (powerOfFour - 1 + MOD) % MOD;

        // 3. 분모 3의 나머지 연산 곱셈 역원 구하기 (3^(MOD-2) % MOD)
        long inverseOfThree = Power(3, MOD - 2);

        // 4. 최종 결과 계산
        long ans = (numerator * inverseOfThree) % MOD;

        Console.WriteLine(ans);
    }

    // 반복 제곱법
    static long Power(long @base, long exponent)
    {
        long res = 1;
        @base = @base % MOD;

        for(int i =0; i <= 30; i++)
        {
            if((exponent& 1 << i)!=0)
            {
                res = (res*@base)%MOD;
            }
            @base = (@base*@base)%MOD;
        }
        return res;
    }
}
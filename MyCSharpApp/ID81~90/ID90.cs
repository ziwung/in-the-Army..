using System;
using System.Linq;
class ID90
{
    static int Product(int m)
    {
        if (m == 0)
        {
            return 0;
        }
        int sum = 1;
        while (m > 0)
        {
            sum *= m%10;
            m /= 10;
        }
        return sum;
    }
    static void func(List<int> nums, long m) // N이 10^11이므로 m은 long형이 안전합니다.
    {   
        if (m > 100000000000L) // 조건 범위에 맞춰 조정
        {
            return;
        }
        nums.Add((int)m); // 생성된 후보를 리스트에 추가
        int current = (int)(m % 10);
        for(int i = current; i<10; i++)
        {
            func(nums, m*10+i);
        }
    }   
    static void Main()
    {
        int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int N = input[0];
        int B = input[1];
        int count= 0;
        List<int> nums = new List<int>();
        func(nums, B);
        foreach(int m in nums)
        {
            if (m == Product(m) + B && m<N)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
using System;
using System.Net;
class ID62
{
    static void Main()
    {
        long K = long.Parse(Console.ReadLine()!);
        int[] N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int nl = N.Length;
        int[] temp = new int[nl]; temp[0] = 1; List<int> circulation = new List<int>();
        int rt = 0; int count = 0; int circle = 0;
        for(int i = 0; i < nl; i++)
        {
            rt = (N[rt]-1);
            temp[rt]++;
            if (temp[rt] == 2)
            {
                count = i;
                circle = rt;
                circulation.Add(circle);
            }
        }
        if (K <= count)
        {
            //count 보다 작으면 그냥 계산
            rt = 1;
            for(int i = 0; i < count; i++)
            {
                rt = (N[rt]-1);
            }
            Console.WriteLine(rt);
        }else{
            // 순환구간 리스트 생성
            rt = (N[circle]-1);
            while(rt != circle)
            {
                circulation.Add(rt);
                rt = N[rt]-1;
            }
            K=K-count;
            K = K%circulation.Count;
            Console.WriteLine(N[K]);
        }
    }
}
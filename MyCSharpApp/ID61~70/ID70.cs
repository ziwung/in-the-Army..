using System;
using System.Linq;
class ID70
{
    static void Main()
    {
        int[] inp = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int N = inp[0];
        int K = inp[1];
        int[,] nod = new int[N,2];
        for(int i = 0; i < N; i++)
        {
            int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            nod[i,0] = input[0];
            nod[i,1] = input[1];
        }
        int ans = 100000000;
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                for(int k = 0; k < N; k++)
                {
                    for(int l = 0; l < N; l++)
                    {
                        int cr = nod[i,0]; int cl = nod[j,0]; int dr = nod[k,1];int dl = nod[l,1];
                        if (cr > cl && dr > dl)
                        {
                            if (CheckCount(N, nod, cr, cl, dr, dl) >= K)
                            {
                                ans = Math.Min(ans,(cr-cl)*(dr-dl));
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(ans);
    }
    static int CheckCount(int N, int[,] nod, int xr, int xl, int yr,int yl)
    {
        int Count = 0;
        for(int i=0; i<N; i++)
        {
            if (xl <= nod[i, 0] && nod[i, 0] <= xr && yl <= nod[i, 1] && nod[i, 1] <= yr)
            {
                Count++;
            }
        }
        return Count;
    }
}
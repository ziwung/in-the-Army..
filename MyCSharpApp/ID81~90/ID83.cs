using System;
using System.Linq;
class ID83
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine()!);
        List<int> A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList(); A.Sort();
        List<int> B = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList(); B.Sort();
        int sum = 0; int aCusor = 0; int bCusor = 0;

        //동일 부분 제거
        while (aCusor != A.Count && bCusor != B.Count)
        {
            Console.WriteLine($"a : {aCusor}, b : {bCusor}");
            if (A[aCusor] == B[bCusor])
            {
                Console.WriteLine($"{A[aCusor]}, {B[bCusor]} 삭제");
                A.RemoveAt(aCusor);
                B.RemoveAt(bCusor);
            }
            else{
                if (A[aCusor] > B[bCusor])
                {
                    bCusor++;
                }
                else
                {
                    aCusor++;
                }
            }
        }
        // 합 계산
        for(int i=0; i<A.Count; i++)
        {
            sum += Math.Abs(A[i] - B[i]);
        }
        Console.WriteLine(sum);
    }
}
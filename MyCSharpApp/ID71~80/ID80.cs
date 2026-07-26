using System;
using System.Linq;
class Nod
{
    public int Index {get;set;}
    public int Value {get;set;}
    public Nod(int index,int value)
    {
        Index = index;
        Value = value;   
    }
}
class ID80
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine()!);
        int M = int.Parse(Console.ReadLine()!);
        int[] x = new int[N+1]; List<Nod>[] nods = new List<Nod>[N+1];
        for(int i = 0; i<N+1; i++)
        {
            x[i] = int.MaxValue;
            nods[i] = new List<Nod>();
        }
        for(int i = 0; i<M; i++)
        {
            int[] input = Console.ReadLine()!.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            nods[input[0]].Add(new Nod(input[1],input[2]));
            nods[input[1]].Add(new Nod(input[0],input[2]));
        }
        PriorityQueue<int> q
    }
}
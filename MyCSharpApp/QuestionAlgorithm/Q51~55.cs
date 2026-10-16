using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
class Q51_55{
    private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    private static  string[] line = new string[0];
    private static int lineIdx = 0;
    private static string NextToken(){
        while(lineIdx >= line.Length){
            string s = sr.ReadLine()!;
            if(s == null) return null!;
            line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            lineIdx = 0;
        }
        return line[lineIdx++];
    }
    private static int NextInt() => int.Parse(NextToken())!;
    static void Main()
    {
        // A51
        // int k = NextInt();
        // Stack<string>  stang= new Stack<string>();
        // for(int i = 0; i<k; i++){
        //     string ans = NextToken();
        //     if(ans == "1")
        //     {
        //         stang.Push(NextToken());   
        //     }
        //     else if(ans == "2") Console.WriteLine(stang.Peek());
        //     else Console.WriteLine(stang.Pop());
        
        // // B51(스택)
        // string galho = NextToken();
        // int len = galho.Length;
        // Stack<int>  stang= new Stack<int>();
        // for(int i = 0; i<len; i++)
        // {
        //     if(galho[i] == '(')
        //     {
        //         stang.Push(i);
        //     }else{
        //         Console.Write(stang.Pop());
        //         Console.WriteLine(i);
        //     }
        // }

        // A52(큐)
        // int k = NextInt();
        // Queue<string>  q= new Queue<string>();
        // for(int i = 0; i<k; i++){
        //     string ans = NextToken();
        //     if(ans == "1")
        //     {
        //         q.Enqueue(NextToken());
        //     }
        //     else if(ans == "2") Console.WriteLine(q.Peek());
        //     else q.Dequeue();
        // }

        // // A53(우선순위큐)
        // int k = NextInt();
        // PriorityQueue<int,int>  q= new PriorityQueue<int,int>();
        // for(int i = 0; i<k; i++){
        //     string ans = NextToken();
        //     if(ans == "1")
        //     {
        //         int a = NextInt();
        //         q.Enqueue(a,a);
        //     }
        //     else if(ans == "2") Console.WriteLine(q.Peek());
        //     else q.Dequeue();
        // }

        // // A54(연상배열)
        // int k = NextInt();
        // Dictionary<string,int>  d= new Dictionary<string, int>();
        // for(int i = 0; i<k; i++){
        //     string ans = NextToken();
        //     if(ans == "1")
        //     {
        //         string value = NextToken();
        //         int a = NextInt();
        //         d.Add(value, a);
        //     }
        //     else if(ans == "2") Console.WriteLine(d[NextToken()]);
        // }

        // // B54
        // int n = NextInt();
        // Dictionary<int,int>  d= new Dictionary<int, int>();
        // HashSet<int> store = new HashSet<int>();
        // for(int i = 0; i<n; i++)
        // {
        //     int a = NextInt();
        //     store.Add(a);
        //     if(!d.TryGetValue(a, out int b))  b = 0;
        //     d[a] = b+1;
        // }
        // int ans = 0;
        // foreach(int a in store)
        // {
        //     ans += nC2(d[a]);
        // }
        // Console.WriteLine(ans);
    }
    public static int nC2(int n)
    {
        if(n <= 1) return 0;
        int ans = 1;
        for(int i = 0; i<2; i++)
        {
            ans *= n-i;
        }
        return ans/2;
    }
}
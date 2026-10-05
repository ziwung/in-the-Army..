// using System;
// using System.IO;
// using System.Linq;
// using System.Collections.Generic;
// class Q45{
//     private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
//     private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
//     private static  string[] line = new string[0];
//     private static int lineIdx = 0;
//     private static string NextToken(){
//         while(lineIdx >= line.Length){
//             string s = sr.ReadLine()!;
//             if(s == null) return null!;
//             line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//             lineIdx = 0;
//         }
//         return line[lineIdx++];
//     }
//     private static int NextInt() => int.Parse(NextToken())!;
//     private static char NextChar() => char.Parse(NextToken())!;
//     static void Main(){
//         // // A45 (별5개문제 풀이 안보고 품~!)
//         // // 아니 전부 흰으로 직결되잖슴; 11, 22, 33, 44, 55, 66, 03, 14, 25, 36, 47. 17, 06 
//         // // 규칙 두 숫자 동일x 두수 차이가 3의배수이면 안됨 (그렇다면 흰색으로 귀결)
//         // // 그렇다면 다른예시들을 살펴보자 12 무조건 2인수만 나옴 23 04 31 전부 12로 귀결 
//         // // 자 가정을 세워봅시다 1,4,7,10 이렇게 차이값을 3으로 나눴을때 나머지가 1이 나오는 수들은 더 큰수의 수가 뜬다 12,23,04,15
//         // // 2,5,8,11 이렇게 차이값을 3으로 나눴을때 나머지가 2가 나오는 수들은 더 작은수가 뜬다 31 20아 깨닳았다 이 세계의 진리..
//         // // 그렇다는건 0,3,6,9이렇게 3나눴을때 나눠떨어지는수는 시발 흰색이 뜬다?! 키아아아아악
//         // int n = NextInt();
//         // string c = NextToken();
//         // string input = NextToken();
//         // int wCount = 0; int rCount = 0; int bCount = 0; 
//         // for(int i = 0; i<n; i++){
//         //     switch (input[i])
//         //     {
//         //         case'W':
//         //             wCount++;
//         //             break;
//         //         case'B':
//         //             bCount++;
//         //             break;
//         //         case'R':
//         //             rCount++;
//         //             break;
//         //     }
//         // } 
//         // string ans;
//         // if(rCount>0||bCount>0){
//         //     int temp = Math.Abs(rCount-bCount);
//         //     if(temp%3 == 0) ans = "W";
//         //     else if(temp%3 == 1) ans = (rCount>bCount)? "R":"B";
//         //     else ans =  (rCount>bCount)? "B":"R";
//         // }
//         // else
//         // {
//         //     ans = "W";
//         // }
//         // if (ans == c)
//         // {
//         //     Console.WriteLine("yes");
//         // }else Console.WriteLine("No");

//         // B45
//         int a = NextInt();
//         int b = NextInt();
//         int c = NextInt();
//         if(a+b+c == 0) Console.WriteLine("yes");
//         else Console.WriteLine("No");
//     }
// }
// class Q44{
//     private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
//     private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
//     private static  string[] line = new string[0];
//     private static int lineIdx = 0;
//     private static string NextToken(){
//         while(lineIdx >= line.Length){
//             string s = sr.ReadLine()!;
//             if(s == null) return null!;
//             line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//             lineIdx = 0;
//         }
//         return line[lineIdx++];
//     }
//     private static int NextInt() => int.Parse(NextToken())!;
//     private static char NextChar() => char.Parse(NextToken())!;
//     static void Main()
//     {
//         // // A44
//         // int n = NextInt();
//         // int q = NextInt();
//         // int[] A = new int[n];
//         // for(int i = 0; i<n; i++) A[i] = i+1; 
//         // int status = 1; 
//         // for(int i =0; i < q; i++)
//         // {
//         //     int a = NextInt();
//         //     if (a == 1)
//         //     {
//         //         if(status == 1) A[NextInt()-1] = NextInt();
//         //         else A[n-NextInt()] = NextInt();
//         //     }
//         //     else if (a == 2)
//         //     {
//         //         status *= -1;
//         //     }
//         //     else
//         //     {
//         //         if(status == 1) Console.WriteLine(A[NextInt()-1]);
//         //         else Console.WriteLine(A[n-NextInt()]);
//         //     }
//         // }

//         // B44
//         int n = NextInt();
//         int q = NextInt();
//         int[,] A = new int[n,n]; int count = 1;
//         for(int i = 0; i<n; i++){ 
//             for(int j = 0; j<n; j++)
//             {
//                 A[i,j] = count++;    
//             }
//         }
//         int[] status = new int[n]; 
//         for(int i = 0; i<n; i++) status[i+1] = i+1;
//         for(int i =0; i < q; i++)
//         {
//             int a = NextInt();
//             if (a == 1)
//             {
//                 int ab = NextInt();
//                 int bc = NextInt();
//                 int temp = status[ab];
//                 status[ab] = status[bc];
//                 status[bc] = temp;
//             }
//             else
//             {
//                 int x = NextInt();
//                 Console.WriteLine(A[status[x],NextInt()]);
//             }
//         }
//     }
// }
// class Q43
// {
//     private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
//     private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
//     private static  string[] line = new string[0];
//     private static int lineIdx = 0;
//     private static string NextToken(){
//         while(lineIdx >= line.Length){
//             string s = sr.ReadLine()!;
//             if(s == null) return null!;
//             line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//             lineIdx = 0;
//         }
//         return line[lineIdx++];
//     }
//     private static int NextInt() => int.Parse(NextToken())!;
//     private static char NextChar() => char.Parse(NextToken())!;
//     static void Main()
//     {
//         // // A43
//         // int n = NextInt();
//         // int l = NextInt();
//         // List<int> e = new List<int>(); List<int> w = new List<int>();
//         // for(int i =0; i<n; i++){
//         //     int a = NextInt();
//         //     char b = NextChar();
//         //     if(b=='E') e.Add(a);
//         //     else w.Add(a);
//         // }
//         // int eMin = e.Min();
//         // int wMax = w.Max();
//         // int ans = (l-eMin>wMax)? l-eMin:wMax;
//         // Console.WriteLine(ans);

//         // B43
//         int n = NextInt(); // 학생수
//         int m = NextInt(); // 문제수
//         int[] student = new int[n]; //학생별 점수 기록
//         Array.Fill(student,m); //각 학생 문제다맞췄다는 가정
//         for(int i = 0; i<m; i++)
//         {
//             student[NextInt()]--; // 문제별 못맞친 학생 번호 깎기
//         }
//         int j = 0;
//         foreach(int a in student)
//         {
//             Console.WriteLine($"{j} 번째 학생의 점수 {a}");
//             j++;
//         }
//     }
// }
// class Q42
// {
//     private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
//     private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
//     private static  string[] line = new string[0];
//     private static int lineIdx = 0;
//     private static string NextToken(){
//         while(lineIdx >= line.Length){
//             string s = sr.ReadLine()!;
//             if(s == null) return null!;
//             line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//             lineIdx = 0;
//         }
//         return line[lineIdx++];
//     }
//     private static int NextInt() => int.Parse(NextToken())!;
//     static void Main()
//     {
//         // // A42
//         // int n = NextInt();
//         // int k = NextInt();
//         // int[,] total = new int[101,101];
//         // int[,] total1 = new int[101,101];
//         // for(int i = 0; i<n; i++)
//         // {
//         //     int x = NextInt();
//         //     int y = NextInt();
//         //     total[x,y]+=1;
//         // }
//         // for(int i = 1; i <= 100; i++)
//         // {
//         //     for(int j = 1; j<=100; j++)
//         //     {
//         //         total1[i,j] = total[i,j]+total1[i-1,j]+total1[i,j-1]-total1[i-1,j-1];
//         //     }
//         // }
//         // int ans = 0;
//         // for(int a = 1; a<=100-k; a++)
//         // {
//         //     for(int b = 1; b<=100-k; b++)
//         //     {
//         //         int score = total1[a-1,b-1] - total1[a+k,b-1] - total1[a-1,b+k] + total1[a+k,b+k];
//         //         ans = Math.Max(ans,score);
//         //     }
//         // }
//         // Console.WriteLine(ans);

//         // B42
//         // 앞뒤 ++ -- +- -+ 4가지정도
//         //그럼 높은거 기준으로 잡냐 아님 낮은거 아님 오른쪽 왼쪽 이렇게 4가지 경우를 보면 될듯? - 그건 아니지 반례가 있음
//         //잠깐 어차피 +-든 다 더하는거니까 ++기준일땐 둘이 더해서 최대 +-기준일땐 a엔 + b엔 -곱해서 더하면 가중치가 올바르게 원하는데로 작동하지 않을까?
//         int n = NextInt();
//         int[] a = new int[n];
//         int[] b = new int[n];
//         for(int i=0; i<n; i++)
//         {
//             a[i] = NextInt();
//             b[i] = NextInt();
//         }
//         int[] sumCount = new int[n]; int ans = 0; int cum = 0;
//         for(int i=0; i<n; i++) //++일 경우
//         {
//             sumCount[i] = a[i]+b[i];
//         }
//         Array.Sort(sumCount);
//         for(int i=n-1; i>=0; i--)
//         {
//             cum += sumCount[i];
//             ans = Math.Max(ans,cum);
//         }
//         cum = 0;
//         for(int i=0; i<n; i++) //+-일 경우
//         {
//             sumCount[i] = a[i]+(-b[i]);
//         }
//         Array.Sort(sumCount);
//         for(int i=n-1; i>=0; i--)
//         {
//             cum += sumCount[i];
//             ans = Math.Max(ans,cum);
//         }
//         cum = 0;
//         for(int i=0; i<n; i++) //-+일 경우
//         {
//             sumCount[i] = (-a[i])+b[i];
//         }
//         Array.Sort(sumCount);
//         for(int i=n-1; i>=0; i--)
//         {
//             cum += sumCount[i];
//             ans = Math.Max(ans,cum);
//         }
//         cum = 0;
//         for(int i=0; i<n; i++) //--일 경우
//         {
//             sumCount[i] = -a[i]-b[i];
//         }
//         Array.Sort(sumCount);
//         for(int i=n-1; i>=0; i--)
//         {
//             cum += sumCount[i];
//             ans = Math.Max(ans,cum);
//         }
//         Console.WriteLine(ans);
//     }
// }
// class Q41
// {
//     private static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
//     private static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
//     private static  string[] line = new string[0];
//     private static int lineIdx = 0;
//     private static string NextToken(){
//         while(lineIdx >= line.Length){
//             string s = sr.ReadLine()!;
//             if(s == null) return null!;
//             line = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//             lineIdx = 0;
//         }
//         return line[lineIdx++];
//     }
//     private static int NextInt() => int.Parse(NextToken())!;
//     static void Main()
//     {
//         // // A41
//         // int n = NextInt();
//         // int[] a = new int[n];
//         // for(int i =0; i<n; i++)
//         // {
//         //     a[i] = NextInt();
//         // }
//         // bool ans = false;
//         // for(int i = 0; i < n - 2; i++)
//         // {
//         //     if(a[i]==0&&a[i+1]==0&&a[i+2]==0) ans = true;
//         //     if(a[i]==1&&a[i+1]==1&&a[i+2]==1) ans = true;
//         // }
//         // Console.WriteLine(ans);

//         // // B41
//         // int X = NextInt(); int Y = NextInt();
//         // char start = (X>Y)? 'X':'Y';
//         // string ans = "{start}";
//         // while (X == 1 && Y == 1)
//         // {
//         //     if (X > Y)
//         //     {
//         //         X = X-Y;
//         //         ans += 'X';
//         //     }
//         //     else if(X==Y)
//         //     {
//         //         ans = "판정불가";
//         //     }
//         //     else
//         //     {
//         //         Y = Y-X;
//         //         ans +='Y';
//         //     }
//         //     Console.WriteLine(ans);
//         // }
//     }
// }


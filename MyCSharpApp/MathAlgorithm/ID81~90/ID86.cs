// using System;
// using System.Linq;
// class ID86
// {
//     static void Main()
//     {
//         string input = Console.ReadLine()!;

//         Stack<int> box = new Stack<int>(); bool isCan = true;
//         for(int i =0; i < input.Length; i++)
//         {
//             if (input[i] == '(')
//             {
//                 box.Push(1);
//             }
//             else
//             {
//                 if(box.Count == 0){
//                     isCan = false;
//                     break;
//                 }
//                 box.Pop();
//             }
//         }
//         if(box.Count > 0)
//         {
//             isCan = false;
//         }
//         Console.WriteLine(isCan);
//     }
// }
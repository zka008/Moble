//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            int ans = rnd.Next(1, 51), input, cnt=1;
//            while (true)
//            {
//                Console.Write($"{cnt++}.숫자를 입력하세요 : ");
//                input = int.Parse(Console.ReadLine());
//                if (input > ans)
//                    Console.WriteLine($"{input}보다 작은 숫자입니다\n");
//                else if (input< ans)
//                    Console.WriteLine($"{input}보다 큰 숫자입니다\n");
//                else if(input == ans)
//                {
//                    Console.WriteLine("정답입니다");
//                    break;
//                }
//            }
//        }
//    }
//} 
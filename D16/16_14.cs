//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        static void Add(int a, int b)
//        {
//            Console.WriteLine($"input : {a}, {b}, result : {a+b}");
//        }
//        static void Main(string[] args)
//        {
//            int a, b;
//            string[] input;
//            string tmp;
//            for (int i=0;i<5;i++)
//            {
//                Console.Write("정수 2개를 입력하세요 : ");
//                tmp = Console.ReadLine();
//                input = tmp.Split(" ");
//                a = int.Parse(input[0]);
//                b = int.Parse(input[1]);
//                Add(a, b);
//            }
//        }
//    }
//}
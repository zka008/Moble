//using System;

//namespace CodeWork
//{
    
//    internal class Program
//    {
//        public static void Swap(ref int a, ref int b)
//        {
//            int tmp = a;
//            a = b;
//            b = tmp;
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("정수 2개 입력");
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine($"Swap 전 a = {a}, b = {b}");
//            Swap(ref a, ref b);
//            Console.WriteLine($"Swap 후 a = {a}, b = {b}");
//        }
//    }
//}
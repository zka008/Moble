//using System;
//using System.Collections.Generic;
//namespace CodeWork
//{
//    public static class IntergerExtension
//    {
//        public static int Square(this int num)
//        {
//            return num * num;
//        }
//        public static int Power(this int x, int n)
//        {
//            int result = x;
//            for (int i = 0; i < n; i++)
//                result *= x;
//            return result;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine($"3^2 : {3.Square()}");
//            Console.WriteLine($"3^4 : {3.Power(4)}");
//            Console.WriteLine($"2^10 : {2.Power(10)}");
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//namespace CodeWork
//{
//    class Fibonacci
//    {
//        private static Dictionary<int, decimal> memo = new Dictionary<int, decimal>();
//        public static decimal Get(int n)
//        {
//            if (n < 0) return 0;
//            if (n == 1) return 1;
            
//            //계산 했던 값인지?
//            if(memo.ContainsKey(n)) 
//                return memo[n];
//            //아니면 계산
//            else
//            {
//                decimal value = Get(n - 2) + Get(n - 1);
//                memo[n] = value;
//                return value;
//            }
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//           for(int i = 1; i < 200; i++) { 
//                Console.WriteLine(i + " "+Fibonacci.Get(i)); 
//           }
//        }
//    }
//}

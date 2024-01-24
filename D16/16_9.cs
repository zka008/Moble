//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            for (int i = 0; i < 5; i++)
//            {   //NextDouble() 0.0~,...,0.9999...
//                Console.WriteLine($"{rnd.NextDouble() * 10}"); 
//            }
//            for (int i = 0; i < 5; i++)
//            {   //Round(a,b) a를 b번째 자리에서반올림
//                Console.WriteLine($"{Math.Round(rnd.NextDouble(), 2)}"); 
//            }
//            for(int i = 0;i < 5; i++)
//            {   //Next(a,b) a,...,b-1 랜덤
//                Console.WriteLine(rnd.Next(1, 101).ToString()); 
//            }
//        }
//    }
//}
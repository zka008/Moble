//using System;
//namespace CodeWork
//{
//    class SquareCalculator
//    {
//        public int this[int i]
//        {
//            get { return i * i; }
//            set { Console.WriteLine(i + "의 제곱"); }
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            SquareCalculator square = new SquareCalculator();
//            for (int i = 0; i < 101; i = i + 10)
//            {
//                Console.WriteLine("클래스 호출 반환값 " + square[i]);
//                Console.WriteLine(square[i] = square[i]);
//            }
//        }
//    }
//}
//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        delegate void TypeF(int i, int b);
//        static void Plus(int x, int y) { Console.WriteLine(x + y); }
//        static void Minus(int x, int y) { Console.WriteLine(x - y); }
//        static void Multiple(int x, int y) { Console.WriteLine(x * y); }
//        static void Main(string[] args)
//        {
//            TypeF del = Plus;
//            del += Minus;
//            del += Multiple;

//            del(20, 10);
//        }
//    }
//}
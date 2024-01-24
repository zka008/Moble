//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        class Global
//        {
//            public static int count = 0;
//        }
//        class A
//        {
//            public A() { Global.count++; }
//        }
//        class B
//        {
//            public B() { Global.count++; }
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Global.Count = "+Global.count);
//            new A();
//            new A();
//            new B();
//            new B();
//            Console.WriteLine("Global.Count = " + Global.count);
//        }
//    }
//}
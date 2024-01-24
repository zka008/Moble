//using System;
//namespace CodeWork
//{
//    class Parent
//    {
//        public Parent()
//        {
//            Console.WriteLine("부모 생성자");
//        }
//    }
//    class Child : Parent
//    {
//        public Child() : base() //부모(base) 생성자를 먼저 호출하고 자식 생성자
//        {
//            Console.WriteLine("자식 생성자");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Child child = new Child();
//        }
//    }
//}
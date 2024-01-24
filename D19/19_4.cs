//using System;
//namespace CodeWork
//{
//    interface I
//    {
//        void method();
//    }
//    class User
//    {
//        public void method(I i)
//        {
//            i.method();
//        }
//    }
//    class A : I 
//    { 
//        public void method()
//        {
//            Console.WriteLine("A클래스의 메소드");
//        }
//    }
//    class B : I
//    {
//        public void method()
//        {
//            Console.WriteLine("B클래스의 메소드");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            User user = new User();
//            user.method(new A());
//            user.method(new B());
//        }
//    }
//}
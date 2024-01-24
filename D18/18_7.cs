//using System;
//namespace CodeWork
//{
//    class Parent
//    {
//        public Parent() {Console.WriteLine("Parent()");}
//        public Parent(int param) { Console.WriteLine("Parent(int param)");}
//        public Parent(string param) { Console.WriteLine("Parent(string param)"); }
//    }
//    class Child : Parent
//    {
//        public Child() : base(10) //Parent(int param) 호출
//        {
//            Console.WriteLine("Child() : base(1)");
//        }
//        public Child(string input) : base(input) //Parent(string param) 호출
//        {
//            Console.WriteLine("Child(string input) : base(input)");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Child child1 = new Child();
//            Console.WriteLine();
//            Child child2 = new Child("string");
//        }
//    }
//}
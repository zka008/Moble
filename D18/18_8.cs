//using System;
//namespace CodeWork
//{
//    class Parent
//    {
//        public Parent() { Console.WriteLine("1_Parent()"); }
//        public Parent(int a) { Console.WriteLine("2_Parent : {0}", a); }
//        public Parent(string param) { Console.WriteLine("3_Parent : {0}", param); }
//    }
//    class Child : Parent
//    {

//        public Child() : base() //Parent(int param) 호출
//        {
//            Console.WriteLine("1_Child() : base()");
//        }
//        public Child(int a) : base(a) //Parent(string param) 호출
//        {
//            Console.WriteLine("2_Child(string a)->base:{0}", a);
//        }
//        public Child(string input) : base(input) //Parent(string param) 호출
//        {
//            Console.WriteLine("3_Child(string input)->base:{0}", input);
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Child childA = new Child();
//            Child childB = new Child(10);
//            Child childC = new Child("string");
//        }
//    }
//}

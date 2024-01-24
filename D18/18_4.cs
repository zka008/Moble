//using System;
//namespace CodeWork
//{
//    class Parent
//    {
//        protected string name;
//        public Parent() { this.name = "부모"; }
//    }
//    class Child : Parent
//    {
//        public string name = "자식";
//        public Child() {
//            //base를 통해 기반 클래스의 생성자 호출
//            Console.WriteLine("base.name = {0}", base.name); 
//            Console.WriteLine("this.name = {0}", this.name);
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
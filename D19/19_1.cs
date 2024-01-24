//using System;
//namespace CodeWork
//{
//    class Parent
//    {
//        public int var = 273;
//        public virtual void method()
//        {
//            Console.WriteLine("부모의 메소드");
//        }
//    }

//    class Chile : Parent
//    {
//        public string var = "hiding";
//        //public override void method() 
//        //{ override를 했을 때는 child -> parent로 형변환을 해도 무조건 자식의 메소드가 출력됨
//        //    Console.WriteLine("자식의 메소드");
//        //}
//        public new void method()
//        { // new 키워드, child -> parent로 형변환을 하면 부모의 method가 출력됨
//            Console.WriteLine("자식의 메소드");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Chile child = new Chile();
//            Console.WriteLine(child.var);
//            Console.WriteLine(((Parent)child).var);
//            child.method();
//            ((Parent)child).method();
//        }
//    }
//}
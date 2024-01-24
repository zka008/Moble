//using System;
//namespace CodeWork
//{
//    class MyClass
//    {
//        private string name;
//        public string MyName
//        {
//            get { return name; }
//            set { if (value.Length > 3)
//                    Console.WriteLine("이름은 3자 이상 넘을 수 없음");
//                else
//                    name = value; }
//        }
//        public int Age
//        {
//            get; set;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass();
//            myClass.MyName = "홍길동";
//            myClass.Age = 5;
//            Console.WriteLine($"저의 이름은 {myClass.MyName}이고 나이는 {myClass.Age}살 입니다.");
//        }
//    }
//}
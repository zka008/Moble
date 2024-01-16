//using System;
//namespace Class2
//{
//    public struct MyStruct
//    {
//        public int age;
//        public string testA = null; //null로 초기화 해줘야 오류가 안뜸
//        public string testB = null;
//        public MyStruct(int age) //매개변수 있는 생성자
//        {
//            //static이 없는 변수 age 초기화는 생성자의 매개변수 이용
//            this.age = age;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            MyStruct s1;
//            Console.WriteLine("age 입력");
//            s1.age = int.Parse(Console.ReadLine());
//            Console.WriteLine($"구조체 멤버 age = {s1.age}");

//            MyStruct s2 = new MyStruct();
//            Console.WriteLine("문자열 멤버 입력");
//            s2.testA = Console.ReadLine();
//            s2.testB = Console.ReadLine();
//            Console.WriteLine($"구조체 문자열 멤버1 {s2.testA}, 구조체 문자열 멤버2 {s2.testB}");
//        }
//    }
//}

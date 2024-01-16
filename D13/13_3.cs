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
//            s1.age = 12;
//            Console.WriteLine(s1.age);

//            //매개변수가 없는 생성자를 사용해서 초기화를 해줘야함
//            MyStruct s2 = new MyStruct();
//            Console.WriteLine(s2.age);
//            Console.WriteLine(s2.testA);

//            MyStruct s3 = new MyStruct(18);
//            Console.WriteLine(s3.age);
//            Console.WriteLine(s3.testA);
//        }
//    }
//}

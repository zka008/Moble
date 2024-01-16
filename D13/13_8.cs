//using System;
//namespace Class2
//{
//    public struct MyStruct
//    {
//        public int age;
//    }
//    class MyClass
//    {
//        public int age;
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //구조체는 stack에 값이 저장되지만
//            MyStruct test1 = new MyStruct();
//            test1.age = 1;
//            MyStruct test2 = test1;
//            test2.age = 2;
//            Console.WriteLine($"{test1.age}, {test2.age}");
//            //클래스는 stack에 heap영역의 주소값이 저장됨
//            MyClass test3 = new MyClass();
//            test3.age = 3;
//            MyClass test4 = test3;
//            //따라서 test4는 test3의 주소값을 가지고 있기 때문에 3, 4 둘 모두 값이 변함
//            test4.age = 4;
//            Console.WriteLine($"{test3.age}, {test4.age}");
//        }
//    }
//}
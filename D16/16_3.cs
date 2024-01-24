//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        class MyClass
//        {
//            public int i_a; //instance 멤버
//            public int i_b;
//            public static int s_a; //static 멤버
//            public static int s_b;

//            public static void MyMethod1() //static 메서드
//            {
//                i_a = 3; //오류 발생, static 메서드에서 instance 변수 사용 불가
//                s_a = 3;
//            }
//            public void MyMethod2() //instance 메서드
//            {
//                i_a = 3; //instance 메서드는 static 멤버, instance 멤버
//                s_a = 3; //모두 사용 가능
//            }
//        }
//        static void Main(string[] args)
//        {
//            MyClass obj = new MyClass();
            
//            obj.i_a = 1; //인스턴스를 생성하고
//            obj.i_b = 2; //인스턴스 변수 사용

//            MyClass.s_a = 3; //인스턴스를 생성하지 않고 클래스의 이름을
//            MyClass.s_b = 4; //클래스 변수에 직접 접근

//            Console.WriteLine(obj.i_a +" "+obj.i_b);
//            Console.WriteLine(MyClass.s_a +" "+MyClass.s_b);
//        }
//    }
//}
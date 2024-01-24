//using System;

//namespace CodeWork
//{
//    internal class Program
//    {
//        //델리게이트 선언
//        delegate int TypeF(int a, int b);
//        //델리게이트 참조할 수 있도록 같은 형태의 메소드 구현
//        static int plus(int x, int y) { return x + y; }
//        static int minus(int x, int y) { return x - y; }
//        static void Main(string[] args)
//        {
//            //new 연산자를 통한 인스턴스 초기화
//            TypeF del1 = new TypeF(plus);
//            int res1 = del1(20, 20);
//            Console.WriteLine(res1);

//            //메소드명을 이용한 인스턴스 초기화
//            TypeF del2 = minus;
//            int res2 = del2(20, 10);
//            Console.WriteLine(res2);
//        }
//    }
//}
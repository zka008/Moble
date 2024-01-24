//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        class A
//        {
//            private char a = 'A';
//            protected char b = 'B';
//            public char c = 'C';

//            private void printA()
//            {
//                Console.WriteLine("private");
//            }
//            protected void printB()
//            {
//                Console.WriteLine("protected");
//            }
//            public void printC()
//            {
//                Console.WriteLine("public");
//            }
//        }

//        class B : A //B는 A를 상속받음
//        {
//            public void print()
//            {
//                Console.WriteLine($"a : private는 호출 안됨, b : {b}, c : {c}");
//                //printA(); private로 선언되어 접근 할 수 없음
//                printB();
//                printC();
//                b = 'b';
//            }
//        }
//        static void Main(string[] args)
//        {
//            B test = new B();
//            //test.b = 'b'; //protected 제한자는 딱 상속받은 클래스에서만 사용 가능
//            test.c = 'c';
//            //test.printB(); //B에서는 사용할 수 있지만 Main()에서는 못씀
//            test.printC();
//            test.print();
//        }
//    }
//}
//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        public static void DivideOut(int a, int b, out int c, out int d)
//        {
//            c = a / b;
//            d = a % b;
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("두 개의 정수 입력");
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            int c, d; // 초기화하지 않은 매개변수를 전달해도 에러가 발생하지 않음
//            //컴파일러가 호출당하는 메서드에서 초기화하지 않은
//            //지역변수에 대해 할당할 것을 보장함
//            DivideOut(a, b, out c, out d);
//            //DivideOut(a,b, out int c, out int d)
//            //-> 미리 변수선언 안하고 호출하면서 직접선언할 수 있음
//            Console.WriteLine($"몫 : {c}, 나머지 :  {d}");
//        }
//    }
//}

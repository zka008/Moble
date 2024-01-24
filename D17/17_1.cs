//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        public int instance_val = 10;
//        public static int class_val = 10;
//        static void Main(string[] args)
//        {
//            Program p = new Program();
//            //인스턴스 변수를 초기화 없이 사용하려고 하면 오류 발생
//            Console.WriteLine(instance_val);
//            //클래스 변수는 바로 사용 가능
//            Console.WriteLine(class_val);
//            Console.WriteLine(Program.class_val);
//            //인스턴스 변수는 인스턴스(객체)를 만들고 사용
//            Console.WriteLine(p.instance_val);
//        }
//    }
//}
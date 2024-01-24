//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        static void DoSomething()
//        {
//            Random rnd = new Random();
//            int num = rnd.Next(0, 100);

//            if (num < 80)
//                Console.WriteLine($"현재 온도는 {num}입니다");
//            else
//                throw new Exception($"위험! 온도가 높습니다. : {num}");
//        }
//        static void Main(string[] args)
//        {
//            try
//            {
//                while (true)
//                {
//                    DoSomething();
//                    System.Threading.Thread.Sleep(1000);
//                }
//            }
//            catch (Exception e) { 
//                Console.WriteLine(e.Message);
//            }
//            Console.WriteLine("시스템을 종료합니다.");
//        }
//    }
//}
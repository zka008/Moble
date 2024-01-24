//using System;

//namespace CodeWork
//{
//    class Four
//    {
//        public static int Quadrant4(int x, int y)
//        {
//            if (x > 0 && y > 0)
//                return 1;
//            else if (x < 0 && y > 0)
//                return 2;
//            else if (x < 0 && y < 0)
//                return 3;
//            else if (x > 0 && y < 0)
//                return 4;
//            else
//                return 0;
//        }
//    }
//    internal class Program
//    {
       
//        static void Main(string[] args)
//        {
//            Console.WriteLine("x좌표를 입력하세요");
//            int x = int.Parse(Console.ReadLine());
//            Console.WriteLine("y좌표를 입력하세요");
//            int y = int.Parse(Console.ReadLine());
//            Console.WriteLine($"{Four.Quadrant4(x, y)}사분면입니다.");
//        }
//    }
//}

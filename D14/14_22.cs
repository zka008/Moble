//using System;
//namespace Class2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i < 9; i++) 
//            {
//                for (int j = 1; j < 16; j++)
//                {
//                    if (j <= 8 - i) //좌측 공백, 7,6,...0 감소
//                        Console.Write(" ");
//                    else if (j > 8 - i && j < 8 + i) //*, 7-9, 6-10 ... 0-0사이
//                        Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
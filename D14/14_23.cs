//using System;
//namespace Class2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i < 11; i++)
//            {
//                for (int j = 1; j < 11; j++)
//                {
//                    if (i < 6) //별 증가
//                    {
//                        if (j < i + 1)
//                            Console.Write("*");
//                        else if (j >= 11 - i)
//                            Console.Write("*");
//                        else
//                            Console.Write(" ");
//                    }
//                    else //별 감소
//                    {
//                        if (j < 11 - i)
//                            Console.Write("*");
//                        else if (j > i)
//                            Console.Write("*");
//                        else
//                            Console.Write(" ");
//                    }
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
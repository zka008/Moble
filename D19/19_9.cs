//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        static int Divide(int divisor, int dividend)
//        {
//            try
//            {
//                Console.WriteLine("Divide() 시작");
//                return divisor / dividend;
//            }
//            catch(DivideByZeroException e)
//            {
//                Console.WriteLine("Divide() 예외 발생");
//                throw e;
//            }
//            finally
//            {
//                Console.WriteLine("Divide() 끝");
//            }
//        }
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.Write("제수를 입력하세요 : ");
//                int divisor = int.Parse(Console.ReadLine());
//                Console.Write("피제수를 입력하세요 : ");
//                int dividend = int.Parse(Console.ReadLine());

//                Console.WriteLine($"{divisor} / {dividend} = {Divide(divisor, dividend)}");
//            }
//            catch(FormatException e)
//            {
//                Console.WriteLine("에러 : " + e.Message);
//            }
//            catch (DivideByZeroException e)
//            {
//                Console.WriteLine("에러 : " + e.Message);
//            }
//            finally
//            {
//                Console.WriteLine("프로그램을 종료합니다.");
//            }
//        }
//    }
//}
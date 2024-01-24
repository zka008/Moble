//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        static int Sum(params int[] arr)
//        {
//            Console.Write("Summing...");
//            int sum = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (i > 0)
//                    Console.Write(", ");
//                Console.Write(arr[i]);
//                sum += arr[i];
//            }
//            Console.WriteLine();
//            return sum;
//        }
//        static void Main(string[] args)
//        {
//            int[] sum = { -3, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            Console.WriteLine($"Sum : {Sum(sum)}");

//            //아래처럼 매개변수 자리에 바로 넣으려면 params 키워드가 필요함
//            Console.WriteLine($"Sum : {Sum(11, 23, 345, 74, 23, 4)}");
//        }
//    }
//}
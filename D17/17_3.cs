//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        static void TransArray(string[] array) //배열의 주소를 받음
//        {
//            string[] handDays = { "월", "화", "수", "목", "금", "토" };
//            for(int i = 0; i < array.Length; i++)
//            {
//                array[i] = handDays[i];
//            }
//        }
        
//        static void Main(string[] args)
//        {
//            string[] engDays = { "Mon", "Tue", "Wed", "The", "Fri", "Sat" };
//            TransArray(engDays); //배열은 참조형으로 값이 아닌 주소를 전달
//            foreach(var v in engDays)
//            {
//                Console.WriteLine(v); //리턴 값이 없어도 값이 변경됨
//            }
//        }
//    }
//}
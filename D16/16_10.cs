//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> list = new List<int>();
//            list.Add(51); //리스트의 뒤에 데이터 추가
//            list.Add(2);
//            list.Add(39);
//            list.Add(14);
//            list.Add(5);
//            foreach (int i in list)
//            {
//                Console.WriteLine($"Count {list.Count}\titem : {i}");
//            }
//            list.Sort();
//            Console.WriteLine($"정렬 및 5 삭제 후");
//            list.Remove(5); //일치하는 값 앞에서부터 탐색 후 1개 삭제
//            foreach (int i in list)
//            {
//                Console.WriteLine($"Count {list.Count}\titem : {i}");
//            }
//        }
//    }
//}
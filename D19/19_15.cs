//using System;
//using System.Collections;
//namespace CodeWork
//{
//    internal class Program
//    {
//        static void ShowArrayList(ArrayList list)
//        {
//            foreach(var item in list)
//            {
//                Console.Write("{0} ", item);
//            }
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            ArrayList list = new ArrayList();
//            for (int i = 0; i < 5; i++)
//            {
//                list.Add(i);
//            }
//            Console.WriteLine("list : ");
//            ShowArrayList(list);
//            list.Remove(2);
//            ShowArrayList(list);
//            list.Insert(2, 7);
//            ShowArrayList(list);
//            list.Add("abc");
//            list.Add('A');
//            ShowArrayList(list);
//        }
//    }
//}
//using System;

//namespace CodeWork
//{
//    class A
//    {
//        private int[] arr = new int[10];
//        public int this[int index]
//        {
//            get { return arr[index]; }
//            set { arr[index] = value; }
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            A myTest = new A();
//            for (int i = 0; i < 5; i++)
//            {
//                myTest[i] = i;
//                Console.WriteLine(myTest[i]);
//            }
//        }
//    }
//}
//using System;
//namespace Class2
//{
//    enum DialogResult1 { YES, NO, CANCLE} //0, 1, 2
//    enum DialogResult2 { YES=10, NO, CANCLE} //10, 11, 12
//    enum DialogResult3 { YES=10, NO, CANCLE, CONFIRM=20, OK} //10, 11, 12, 20, 21
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine((int)DialogResult1.YES);
//            DialogResult1 result = DialogResult1.YES;
//            Console.WriteLine(result == DialogResult1.YES);

//            Console.WriteLine((int)DialogResult3.YES);
//            Console.WriteLine((int)DialogResult3.NO);
//            Console.WriteLine((int)DialogResult3.CANCLE);
//            Console.WriteLine((int)DialogResult3.CONFIRM);
//            Console.WriteLine((int)DialogResult3.OK);
//        }
//    }
//}
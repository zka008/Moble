//using System;
//namespace CodeWork
//{
//    class Box
//    {
//        private int width;
//        private int height;

//        public int Width
//        {
//            get => width;
//            set
//            {
//                if (value > 0)
//                    width = value;
//                else
//                    Console.WriteLine("너비는 자연수 입력");
//            }
//        }
//        public int Height
//        {
//            get => height;
//            set
//            {
//                if (value > 0)
//                    height = value;
//                else
//                    Console.WriteLine("높이는 자연수 입력");
//            }
//        }
//        public int Area
//        {
//            get => width * height;
//        }
//        public Box(int width, int height)
//        {
//            //this.width = width;
//            //this.height = height;
//            Width = width;
//            Height = height;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Box box = new Box(-10, -20);
//            box.Width = -10;
//            box.Height = -20;
//            Console.WriteLine("사각형의 넓이 : " + box.Area);
//        }
//    }
//}
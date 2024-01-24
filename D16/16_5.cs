//using System;
//namespace CodeWork
//{
//    class Card
//    {
//        public string kind;
//        public int number;

//        public static int width=100;
//        public static int height=250;

//        Random random = new Random();

//        public void call(string name)
//        {
//            number = random.Next(1, 11); //1,2,.....,10까지 나옴
//            Console.WriteLine(name + "의 카드의 번호는 " + number + "입니다");
//        }
//        public static void totalNumber()
//        {
//            Console.WriteLine("카드의 총 수는 52장 입니다.");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine($"카드의 크기는 가로 {Card.width}, 세로 {Card.height}입니다");
//            Card.totalNumber();
//            Console.WriteLine();

//            Card game1 = new Card();
//            game1.call("game1");
//            Card game2 = new Card();
//            game2.call("game2");
//            Console.WriteLine();

//            Console.WriteLine("새로운 게임을 합니다.");
//            Card.width = 150;
//            Card.height = 350;
//            Console.WriteLine($"카드의 크기는 가로 {Card.width}, 세로 {Card.height}입니다");
//        }
//    }
//}
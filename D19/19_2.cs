//using System;
//namespace CodeWork
//{
//    abstract class SmartPhone
//    {
//        public abstract void Network();
//        public void CallPhone()
//        {
//            Console.WriteLine("전화를 겁니다.");
//        }
//    }
//    class ACompany : SmartPhone
//    {
//        public override void Network()
//        {
//            Console.WriteLine("5G 네트워크를 사용합니다.");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //추상 클래스는 인스턴스 생성 불가, 오류
//            //SmartPhone phone1 = new SmartPhone();

//            //부모 클래스로 위장한 자식 클래스로 구현, 다형성
//            SmartPhone phone2 = new ACompany();

//            phone2.Network();
//            phone2.CallPhone();
//        }
//    }
//}
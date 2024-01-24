//using System;
//namespace CodeWork
//{
//    interface IFightable
//    {
//        void attack();
//    }
//    abstract class Unit
//    {
//        public abstract void move(int x, int y);
//        void stop() { }
//    }
//    class Marine : Unit, IFightable
//    {
//        public override void move(int x, int y)
//        {
//            Console.WriteLine("Marine Move [X : {0}, Y : {1}]", x, y);
//        }
//        public void attack()
//        {
//            Console.WriteLine("Marine이 공격합니다.");
//        }
//        public void stimPack() {
//            Console.WriteLine("스팀팩을 분사합니다.");
//        }
//    }
//    class Dropship : Unit
//    {
//        public override void move(int x, int y)
//        {
//            Console.WriteLine("Dropship Move[X : {0}, Y : {1}]", x, y);
//        }
//        public void load()
//        {
//            Console.WriteLine("수송기가 착륙했습니다.");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Marine marine1 = new Marine();
//            marine1.move(300, 300);
//            marine1.attack();
//            marine1.stimPack();
//            Dropship dropship1 = new Dropship();
//            dropship1.move(200, 200);
//            dropship1.load();
//        }
//    }
//}
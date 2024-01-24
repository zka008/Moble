//using System;
//namespace CodeWork
//{
//    class StarCraft
//    {
//        string name;
//        int mineral;
//        int supply;
//        int hp;
//        int atk;
//        public StarCraft() { }
//        public StarCraft(string name, int mineral, int supply, int hp, int atk)
//        {
//            this.Name = name;
//            this.Mineral = mineral;
//            this.Supply = supply;
//            this.Hp = hp;
//            this.Atk = atk;
//        }

//        public void print()
//        {
//            Console.WriteLine("Name : " + Name);
//            Console.WriteLine("Mineral : " + Mineral);
//            Console.WriteLine("Supply : " + Supply);
//            Console.WriteLine("HP : " + Hp);
//            Console.WriteLine("Attack : " + Atk);
//        }

//        public string Name { get => name; set => name = value; }
//        public int Mineral { get => mineral; set => mineral = value; }
//        public int Supply { get => supply; set => supply = value; }
//        public int Hp { get => hp; set => hp = value; }
//        public int Atk { get => atk; set => atk = value; }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            StarCraft scv = new StarCraft("건설로봇", 50, 1, 45, 5);
//            scv.print();
//            Console.WriteLine();

//            Console.Write("Name : ");
//            scv.Name = Console.ReadLine();
//            Console.Write("Mineral : ");
//            scv.Mineral = int.Parse(Console.ReadLine());
//            Console.Write("Supply : ");
//            scv.Supply = int.Parse(Console.ReadLine());
//            Console.Write("HP : ");
//            scv.Hp = int.Parse(Console.ReadLine());
//            Console.Write("Attack : ");
//            scv.Atk = int.Parse(Console.ReadLine());
//            scv.print();
//        }
//    }
//}
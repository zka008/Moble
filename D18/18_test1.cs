//using System;
//namespace CodeWork
//{
//    class Animal
//    {
//        protected string name;
//        protected int height;
//        protected int weight;
//        protected int age;
//        protected int speed;
//        public Animal() { }
//        public Animal(string name, int height, int weight, int age, int speed)
//        {
//            this.name = name;
//            this.height = height;
//            this.weight = weight;
//            this.age = age;
//            this.speed = speed;
//        }
//        public void Speak()
//        {
//            Console.WriteLine($"이름 : {name}");
//            Console.WriteLine($"키 : {height}");
//            Console.WriteLine($"몸무게 : {weight}kg");
//            Console.WriteLine($"나이 : {age}살");
//        }
//        public void Run()
//        {
//            Console.WriteLine($"{name}은(는) {speed}km/h 속도로 달립니다.");
//        }
//        public virtual void Fly() { }
//    }
//    class Pig : Animal
//    {
//        public Pig(string name, int height, int weight, int age, int speed)
//        {
//            this.name = name;
//            this.height = height;
//            this.weight = weight;
//            this.age = age;
//            this.speed = speed;
//        }
//    }
//    class Chicken : Animal
//    {
//        int fly_speed;
//        public Chicken(string name, int height, int weight, int age, int speed, int fly_speed)
//        {
//            this.name = name;
//            this.height = height;
//            this.weight = weight;
//            this.age = age;
//            this.speed = speed;
//            this.fly_speed = fly_speed;
//        }
//        public override void Fly()
//        {
//            Console.WriteLine($"{name}은(는) {fly_speed}km/h 속도로 날라다닙니다.");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("돼지의 이름, 키, 몸무게, 나이, 속도를 입력하세요");
//            string tmp = Console.ReadLine();
//            string[] input = tmp.Split(" ");
//            Animal pig = new Pig(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4]));
//            Console.WriteLine("치킨의 이름, 키, 몸무게, 나이, 속도, 날라다니는 속도를 입력하세요");
//            tmp = Console.ReadLine();
//            input.Initialize();
//            input = tmp.Split(" ");
//            Animal chicken = new Chicken(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5]));
//            pig.Speak();
//            pig.Run();
//            Console.WriteLine();
//            chicken.Speak();
//            chicken.Run();
//            chicken.Fly();
//        }
//    }
//}
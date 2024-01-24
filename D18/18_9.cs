//using System;
//namespace CodeWork
//{
//    class Animal
//    {
//        public int Age { get; set; }
//        public string Color { get; set; }
//        public Animal() { this.Age = 0; }
//        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
//        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
//        public virtual void Bark() { } //가상 메소드 정의
//        public virtual void Meow() { }
//    }
//    class Dog : Animal
//    {
//        public override void Bark() //자식 메소드에서 오버라이드 되어 재정의
//        {
//            Console.WriteLine("왈왈 짓습니다.");
//        }
//    }
//    class Cat : Animal
//    {
//        public override void Meow()
//        {
//            Console.WriteLine("냥냥 웁니다.");
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Animal> Animal = new List<Animal>() {
//                new Dog(), new Dog(), new Dog(),new Dog(),
//             new Cat(), new Cat(), new Cat(),new Cat()};

//            foreach (var item in Animal)
//            {
//                item.Eat();
//                item.Sleep();
//                item.Meow();
//                item.Bark();
//            }
//        }
//    }
//}
//using System;
//namespace CodeWork
//{
//    class Animal
//    {
//        public int Age { get; set; } //상속은 접근 제한자 public과 protected만 가능
//        public string Color { get; set; }
//        public Animal() { this.Age = 0; }
//        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
//        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
//    }
//    class Dog : Animal
//    {
//        public void Bark() {
//            base.Color = "노란색";
//            Console.WriteLine("왈왈 짓습니다."); 
//        }
//        public void Test()
//        {
//            Eat();
//            Sleep();
//        }
//    }
//    class Cat : Animal
//    {
//        public void Meow() {
//            base.Color = "하얀색";
//            Console.WriteLine("냥냥 웁니다."); 
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Dog dog = new Dog();
//            dog.Eat();
//            dog.Sleep();
//            dog.Bark();
//            dog.Age++;
//            Console.WriteLine("강아지의 나이는 : " + dog.Age);
//            Console.WriteLine("강아지의 색깔은 : " + dog.Color);

//            Cat cat = new Cat();
//            cat.Eat();
//            cat.Sleep();
//            cat.Meow();
//            cat.Age++;
//            Console.WriteLine("고양이의 나이는 : " + cat.Age);
//            Console.WriteLine("고양이의 색깔은 : " + cat.Color);
//        }
//    }
//}
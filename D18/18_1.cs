//using System;
//using System.Collections.Generic;
//namespace CodeWork
//{
//    class Dog
//    {
//        public int Age { get; set; }
//        public int Color { get; set; }
//        public Dog() { this.Age = 0; }
//        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
//        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
//        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
//    }
//    class Cat
//    {
//        public int Age { get; set; }
//        public Cat() { this.Age = 0; }
//        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
//        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
//        public void Meow() { Console.WriteLine("왈왈 짓습니다."); }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
//            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
//            int cnt = 0;
//            foreach (var item in Dogs)
//            {
//                cnt++;
//                item.Eat();
//                item.Sleep();
//                item.Bark();
//            }
//            Console.WriteLine("Dogs 호출 반복 횟수 : " + cnt);
//            cnt = 0;
//            foreach (var item in Cats)
//            {
//                cnt++;
//                item.Eat();
//                item.Sleep();
//                item.Meow();
//            }
//            Console.WriteLine("Cats 호출 반복 횟수 : " + cnt);
//        }
//    }
//}
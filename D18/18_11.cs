//using System;
//using System.Collections.Generic;
//namespace CodeWork
//{
//    class Mammal
//    {
//        public void Nurse()
//        {
//            Console.WriteLine("Nurse()");
//        }
//    }
//    class Dog : Mammal
//    {
//        public void Bark()
//        {
//            Console.WriteLine("Bark()");
//        }
//    }
//    class Cat : Mammal
//    {
//        public void Meow()
//        {
//            Console.WriteLine("Meow()");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Mammal mammal1 = new Dog();
//            Mammal mammal2 = new Cat();
//            Dog dog;
//            if (mammal1 is Dog)
//            {
//                dog = (Dog)mammal1;
//                dog.Bark();
//            }
//            Cat cat = mammal2 as Cat;
//            if (cat != null)
//                cat.Meow();
//            Cat cat2 = mammal1 as Cat;
//            if (cat2 != null)
//                cat2.Meow();
//            else
//                Console.WriteLine("cat2 is null");
//        }
//    }
//}
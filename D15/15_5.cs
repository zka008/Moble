//using System;
//namespace CodeWork
//{
//    internal class Program
//    {
//        class Cat
//        {
//            public string Name;
//            public string Color;
//            //생성자를 명시적으로 작성하지 않는다면 컴파일러가 매개변수가 없는
//            //생성자를 자동으로 생성하지만
//            public Cat() { Name = null; Color = ""; }
//            ////하나라도 생성자를 만들게 되면 매개변수가 없는 생성자를 명시적으로
//            ////작성해주어야 함. 아니면 에러 뜸
//            public Cat(string name, string color)
//            {
//                Name = name;
//                Color = color;
//            }
//        }
//        static void Main(string[] args)
//        {
//            Cat kitty = new Cat();
//            kitty.Name = "키티";
//            kitty.Color = "하얀색";
//            Console.WriteLine($"{kitty.Name} : {kitty.Color}");
//            Cat nabi = new Cat("나비", "갈색");
//            Console.WriteLine($"{nabi.Name} : {nabi.Color}");
//        }
//    }
//}
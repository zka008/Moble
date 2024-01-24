//using System;
//namespace CodeWork
//{
//    class Product
//    {
//        public static int cnt = 0; //static 키워드가 없으면 Product.cnt에 접근할 수 없음
//        private int id;     //인스턴스의 cnt+1을 해도 전부 1로만 변경되고 그 이상 증가하지 않음
//        private string name;
//        private int price;

//        public Product(string name, int price)
//        {
//            Product.cnt += 1;
//            this.Id = cnt;
//            this.Name = name;
//            this.Price = price;
//        }

//        public int Id { get => id; set => id = value; }
//        public string Name { get => name; set => name = value; }
//        public int Price { get => price; set => price = value; }

//        ~Product() {
//            Console.WriteLine(this.Name+"의 소멸자 호출");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Product product1 = new Product("감자", 2000);
//            Console.WriteLine(product1.Id + " : " + product1.Name + " " + product1.Price);
//        }
//    }
//}
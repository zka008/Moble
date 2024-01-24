//using System;
//namespace CodeWork
//{
//    class Product
//    {
//        private static int cnt = 0; //static 키워드가 없으면 Product.cnt에 접근할 수 없음
//        private int id;     //인스턴스의 cnt+1을 해도 전부 1로만 변경되고 그 이상 증가하지 않음
//        private string name;
//        private int price;

//        public Product(string name, int price)
//        {
//            Product.Cnt += 1;
//            this.Id = Cnt;
//            this.Name = name;
//            this.Price = price;
//        }

//        public static int Cnt { get => cnt; set => cnt = value; }
//        public int Id { get => id; set => id = value; }
//        public string Name { get => name; set => name = value; }
//        public int Price { get => price; set => price = value; }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Product product1 = new Product("감자", 2000);
//            Product product2 = new Product("고구마", 3000);
//            Product product3 = new Product("양파", 2500);
//            Product product4 = new Product("대파", 2500);

//            Console.WriteLine(product1.Id + " : " + product1.Name + " " + product1.Price);
//            Console.WriteLine(product2.Id + " : " + product2.Name + " " + product2.Price);
//            Console.WriteLine(product3.Id + " : " + product3.Name + " " + product3.Price);
//            Console.WriteLine(product4.Id + " : " + product4.Name + " " + product4.Price);
//            //인스턴스를 생성하지 않은 상태에서 클래스의 이름으로 접근 할 수 있는 변수 cnt
//            Console.WriteLine(Product.Cnt + "개 생성되었습니다.");
//        }
//    }
//}
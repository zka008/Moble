//using System;
//using System.Collections.Generic;
//namespace CodeWork
//{
//    class Product : IComparable
//    {
//        public string Name { get; set; }
//        public int Price { get; set; }

//        public int CompareTo(object? obj)
//        {
//            return this.Price.CompareTo((obj as Product).Price);
//        }

//        public override string ToString()
//        {
//            return Name + " : " + Price + " 원";
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Product> products = new List<Product>()
//            {
//                new Product(){Name = "마우스", Price = 14000},
//                new Product(){Name = "키보드", Price = 40000},
//                new Product(){Name = "웹캠", Price = 35000},
//                new Product(){Name = "마우스패드", Price = 1500}
//            };
//            products.Sort();
//            foreach(var item in products)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
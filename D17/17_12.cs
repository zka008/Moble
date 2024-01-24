//using System;
//namespace CodeWork
//{
//    class Product
//    {
//        private int price = 100;
//        public ref int GetPrice()
//        {
//            return ref price;
//        }
//        public void Print()
//        {
//            Console.WriteLine($"Price : {price}");
//        }
//    }
//    internal class Program
//    {
       
//        static void Main(string[] args)
//        {
//            Product product = new Product();
//            ref int ref_price = ref product.GetPrice();
//            int normal_price = product.GetPrice();
            
//            product.Print();
//            Console.WriteLine($"ref_price : {ref_price}");
//            Console.WriteLine($"normal_price : {normal_price}");
//            Console.WriteLine();

//            Console.WriteLine("ref_price 값 변경 후");
//            ref_price = 200;
//            product.Print();
//            Console.WriteLine($"ref_price : {ref_price}");
//            Console.WriteLine($"normal_price : {normal_price}");
//        }
//    }
//}

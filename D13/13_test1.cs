//using System;
//namespace Class2
//{   
//    struct Record
//    {
//        public int kor, math, eng, sum;
//        public double avg;
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Record record = new Record();
//            Console.Write("국어점수를 입력하세요 : ");
//            record.kor = int.Parse(Console.ReadLine());
//            Console.Write("수학점수를 입력하세요 : ");
//            record.math = int.Parse(Console.ReadLine());
//            Console.Write("영어점수를 입력하세요 : ");
//            record.eng = int.Parse(Console.ReadLine());

//            record.sum = record.kor+record.math+record.eng;
//            record.avg = (double)record.sum / 3;

//            Console.WriteLine("국어 : {0}, 수학 {1}, 영어 {2}\n합계 : {3}, 평균 : {4:f2}",
//                record.kor, record.math, record.eng, record.sum, record.avg);
//        }
//    }
//}
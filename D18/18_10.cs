//using System;
//namespace CodeWork
//{
//    class A
//    {
//        public virtual void Print() { Console.WriteLine("흑백 인쇄를 합니다."); }
//    }
//    class B :A { 
//        public override void Print() { Console.WriteLine("컬러 인쇄를 합니다."); }
//        public void fileOut() { Console.WriteLine("파일로 저장합니다."); }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            A out1 = new A();
//            A out2 = new B();

//            out1.Print();
//            out2.Print(); //override 된 print() 호출
//            //out2.fileout(); 컴파일 에러, 부모 클래스에는 fileout 없음

//            ((B)out2).fileOut(); //형변환 후 fileOut() 호출
//            ((B)out1).fileOut(); 
//        }
//    }
//}
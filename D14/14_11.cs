//using System;
//namespace Class2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            object obj = new object();
//            Console.Write("숫자 형태로 입력하시오 : ");
//            string str = Console.ReadLine();
//            if(int.TryParse(str, out int out_i)) { obj = out_i; }
//            else if(float.TryParse(str, out float out_f)) { obj = out_f; }
//            else { obj = str; }

//            switch (obj)
//            {
//                //case의 뒤에 자료형이 위치할 수 있음. 일치하는 자료형인지 확인
//                case int i when i > 0:
//                    Console.WriteLine("{0}은 int 형식의 양수입니다", i);
//                    break;
//                case int i:
//                    Console.WriteLine("{0}은 int 형식의 음수입니다", i);
//                    break;
//                //when 키워드를 사용하면 추가 조건을 설정할 수 있음
//                case float f when f>=0:
//                    Console.WriteLine("{0}은 float 형식 양수입니다", f);
//                    break;
//                case float f:
//                    Console.WriteLine("{0}은 float 형식의 음수입니다", f);
//                    break;
//                default:
//                    Console.WriteLine("{0}은 모르는 형식입니다.", obj);
//                    break;
//            }
//        }
//    }
//}
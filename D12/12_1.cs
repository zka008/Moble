//using System;
//namespace Class2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            byte a = 255;
//            sbyte b = (sbyte)a;
//            // $ : 문자열 표현식으로 보관된 값을 출력함
//            // ($"{식}") 형식으로 사용
//            Console.WriteLine($"a={a}");
//            Console.WriteLine($"b={b}");

//            short c = -30000;
//            ushort d = 60000;
//            Console.WriteLine($"c={c}, d={d}");

//            // _ 언더바는 자릿수 구분자로 10진수, 2진수, 16진수에
//            // 사용 가능
//            int e = -1000_0000;
//            uint f = 3_0000_0000;
//            Console.WriteLine($"e={e}, f={f}");

//            long g = -5000_0000_0000;
//            ulong h = 200_0000_0000_0000_0000;
//            Console.WriteLine($"g={g}, h={h}");
//        }
//    }
//}
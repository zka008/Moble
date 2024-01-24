using System;
namespace CodeWork
{
    internal class Program
    {
        delegate void TypeF(int i, int b);
        static void Plus(int x, int y) { Console.WriteLine(x + y); }
        static void Minus(int x, int y) { Console.WriteLine(x - y); }
        static void Multiple(int x, int y) { Console.WriteLine(x * y); }
        static void Main(string[] args)
        {
            TypeF del1 = Plus;
            TypeF del2 = Minus;
            TypeF del3 = Multiple;

            del1 += del2;
            del1 += del3;

            del1(20, 10);
        }
    }
}
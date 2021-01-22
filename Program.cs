using System;

namespace workshops_cs_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sum = Add(10, 12);
            int square = Square(16);
            Console.WriteLine(sum);
            Console.WriteLine(square);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Square(int a)
        {
            return a * a;
        }
    }
}

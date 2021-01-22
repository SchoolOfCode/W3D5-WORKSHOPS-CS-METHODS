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
            decimal getvat = GetVat(50.5M);
            bool a = StartsWithChar("hat");
            bool word = StartsWithCharOther ("Zoo");
            Console.WriteLine(a);
            Console.WriteLine(word);
            Console.WriteLine(sum);
            Console.WriteLine(square);
            Console.WriteLine(getvat);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Square(int a)
        {
            return a * a;
        }

        static decimal GetVat (decimal c)
        {
            return c*20/100;
        }

        static bool StartsWithChar (string a)
        {
            if (a[0] == 'W') {
                return true;
            } else {
                return false;
            }
        }
        static bool StartsWithCharOther (string word)
        {
            return word.StartsWith('Z');
        }
    }
}

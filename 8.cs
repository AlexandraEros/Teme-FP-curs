using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

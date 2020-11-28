using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, aux;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

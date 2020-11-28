using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Min(Math.Min(a, b), Math.Min(c, Math.Min(d, e))));
            if (a == Math.Min(Math.Min(a, b), Math.Min(c, Math.Min(d, e))))
                a = e;
            else
                if (b == Math.Min(Math.Min(a, b), Math.Min(c, Math.Min(d, e))))
                b = e;
            else
                if (c == Math.Min(Math.Min(a, b), Math.Min(c, Math.Min(d, e))))
                c = e;
            else
                if (d == Math.Min(Math.Min(a, b), Math.Min(c, Math.Min(d, e))))
                d = e;
            Console.WriteLine(Math.Min(Math.Min(a, b), Math.Min(c, d)));
            if (a == Math.Min(Math.Min(a, b), Math.Min(c, d)))
                a = d;
            else
                if (b == Math.Min(Math.Min(a, b), Math.Min(c, d)))
                b = d;
            else
                if (c == Math.Min(Math.Min(a, b), Math.Min(c, d)))
                c = d;
            Console.WriteLine(Math.Min(Math.Min(a, b), c));
            if (a == Math.Min(Math.Min(a, b), c))
                a = c;
            else
                if (b == Math.Min(Math.Min(a, b), c))
                b = c;
            Console.WriteLine(Math.Min(a, b));
            Console.WriteLine(Math.Max(a, b));
        }
    }
}

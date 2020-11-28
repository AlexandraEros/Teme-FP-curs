using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ok, d;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            if (n <= 1)
                ok = 0;
            else
                if (n == 2)
                ok = 1;
            else
                if (n % 2 == 0)
                ok = 0;
            else
                ok = 1;
            for (d = 3; d * d <= n; d = d + 2)
                if (n % d == 0)
                    ok = 0;
            if (ok == 1)
                Console.WriteLine("Numarul dat este prim");
            else
                Console.WriteLine("Numarul dat nu este prim");
        }
    }
}

using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d;
            Console.WriteLine("Introduceti de la tastatura un numar:");
            n = int.Parse(Console.ReadLine());
            for (d = 1; d <= n; d++)
                if (n % d == 0)
                    Console.WriteLine(d);
        }
    }
}

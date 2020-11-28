using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, nr = 0, i;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            for(i=a;i<=b;i++)
            {
                if (i % n == 0)
                    nr++;
            }
            Console.WriteLine(nr);
        }
    }
}

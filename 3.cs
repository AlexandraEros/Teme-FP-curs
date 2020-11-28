using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("Numarul n se divide cu k");
            else
                Console.WriteLine("Numarul n nu se divide cu k");
        }
    }
}

using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, o = 0, cp;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            cp = n;
            while(n!=0)
            {
                o = o * 10 + n % 10;
                n = n / 10;
            }
            if (cp == o)
                Console.WriteLine("Numarul este palindrom");
            else
                Console.WriteLine("Numarul nu este palindrom");

        }
    }
}

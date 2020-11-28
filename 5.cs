using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, nr = 1;
            Console.Write("Introduceti numarul dorit: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("A cata cifra doriti sa fie extrasa? ");
            k = int.Parse(Console.ReadLine());
            while(nr!=k)
            {
                n = n / 10;
                nr++;
            }
            Console.WriteLine(n % 10);
        }
    }
}

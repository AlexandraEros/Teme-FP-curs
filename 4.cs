using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti de la tastatura anul: ");
            n = int.Parse(Console.ReadLine());
            if (n % 4 == 0 && n % 100 != 0 || n % 400 == 0)
                Console.WriteLine("Anul este bisect");
            else
                Console.WriteLine("Anul nu este bisect");
        }
    }
}

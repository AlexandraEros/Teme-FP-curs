using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, p = 1, cmmdc, cmmmc, r;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            p = a * b;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            cmmdc = a;
            cmmmc = p / a;
            Console.Write("Cel mai mare divizor comun al celor doua numere este {0},iar cel mai mic multiplu comun este {1}", cmmdc, cmmmc);
        }
    }
}

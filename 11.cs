using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                Console.Write(n % 10 + " ");
                n = n / 10;
            }
        }
    }
}

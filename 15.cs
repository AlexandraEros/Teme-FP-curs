using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            if (a < b && a < c && b < c)
                Console.Write("{0},{1},{2}", a, b, c);
            else
                if (a < b && a < c && c < b)
                Console.Write("{0},{1},{2}", a, c, b);
            else
                if(b<a && b<c && a<c)
                Console.Write("{0},{1},{2}", b, a, c);
            else
                if(b<a && b<c && c<a)
                Console.Write("{0},{1},{2}", b, c, a);
            else
                if(c<a && c<b && a<b)
                Console.Write("{0},{1},{2}", c, a, b);
            else
                if(c<a && c<b && b<a)
                Console.Write("{0},{1},{2}", c, b, a);

        }
    }
}

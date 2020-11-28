using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1, y2, nr = 0, i;
            Console.WriteLine("Introduceti cei doi ani:");
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            for(i=y1;i<=y2;i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                    nr++;
            }
            Console.WriteLine(nr);
        }
    }
}

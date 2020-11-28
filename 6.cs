using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Introduceti cele trei laturi");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            if ((a < b + c) && (b < a + c) && (c < a + b) && (a > 0) && (b > 0) && (c > 0))
            {
                Console.WriteLine("Numerele pot forma un triunghi");
            if ((a == b) && (a == c))
                    Console.WriteLine("Triunghi echilateral");
                else if ((a == b) || (a == c))
                    Console.WriteLine("Triunghi isoscel");
                else
                    Console.WriteLine("Triunghi oarecare");
            }
            else
                Console.WriteLine("Numerele nu pot forma un triunghi");
          }
        }
    }

using System;
namespace ghicire_nr
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, nr;
            Random rnd = new Random(); 
            x = rnd.Next(1, 1025); 
            do
            {
                Console.WriteLine("Introduceti un numar cuprins intre 1 si 1024");
                nr = int.Parse(Console.ReadLine());
                if (nr > x) Console.WriteLine("Nr prea mare");
                if (nr < x) Console.WriteLine("Nr prea mic");
            }
            while (nr != x);
            Console.WriteLine("Numarul selectat de calculator este {0}", x);
        }
    }
}
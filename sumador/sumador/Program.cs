using System;
using Suma;

namespace sumade
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(5);
            Sumador s2 = new Sumador(2);

            Console.WriteLine(s1.GetCantidadSumas());
            Console.WriteLine(s2.GetCantidadSumas());
            
            int cantSumas = (int)s1;

            Console.Write(s1 + s2);
            Console.Write("\n");
            Console.Write((s1 | s2) + "\n");
            Console.Write((cantSumas) + "\n");

            Console.Write(s1.Sumar(7, 8));
            long sumatoria = s1 + s2;
            Console.Write("\n" + (cantSumas = (int)s1));
            Console.Write("\n" + sumatoria);
        }
    }
}

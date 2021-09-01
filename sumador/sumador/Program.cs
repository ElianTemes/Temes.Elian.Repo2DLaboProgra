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
            Console.Write(s1 | s2);
        }
    }
}

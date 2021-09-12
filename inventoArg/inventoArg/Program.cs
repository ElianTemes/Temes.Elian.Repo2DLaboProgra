using Lapicera;
using System;

namespace inventoArg
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo LapizAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo LapizRojo = new Boligrafo(0, ConsoleColor.Red);
            string pintura;
            if (LapizRojo.Pintar(50, out pintura))
            {
                Console.WriteLine(pintura);
                Console.ResetColor();
            }
            else 
            {
                Console.WriteLine($"{pintura}, gil");
            }
        }
    }
}

using System;

namespace numPerfectos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIngresado = 33550337;
            int sumador = 0;
            for (int i = 2; i <= numIngresado; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sumador += j;
                    }
                }
                if (sumador == i)
                {
                    Console.WriteLine("El numero {0} es un numero perfecto", i);
                }
                sumador = 0;
            }
        }
    }
}     

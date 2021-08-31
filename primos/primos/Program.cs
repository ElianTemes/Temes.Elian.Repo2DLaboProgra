using System;

namespace primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIngresado;
            int divisores = 0;
            bool esPrimo;
            Console.WriteLine("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out numIngresado);
            Console.Clear();
            Console.WriteLine("Los numeros primos son: ");

            for (int i = 2; i <= numIngresado; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisores++;
                    }
                }
                if (divisores != 2)
                {
                    esPrimo = false;
                }
                else
                {
                    esPrimo = true;
                }

                divisores = 0;
                if (esPrimo)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}

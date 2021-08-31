using System;

namespace cuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIngresado;
            int cubo;
            int cuadrado;
            Console.Write("Ingrese un numero mayor a 0: ");
            numIngresado = int.Parse(Console.ReadLine());
            while (numIngresado > 0 == false)
            {
                Console.WriteLine("Numero incorrecto! ingrese un numero mayor a 0");
                numIngresado = int.Parse(Console.ReadLine());
            }
            cubo = (int) Math.Pow(numIngresado, 3);
            cuadrado = (int)Math.Pow(numIngresado, 2);
            Console.WriteLine("El cuadrado del numero ingresado es: {0} y el cubo {1}", cuadrado, cubo);
        }
    }
}

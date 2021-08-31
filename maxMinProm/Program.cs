using System;

namespace maxMinProm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMax = 0;
            int numMin = 0;
            int numIngresado;
            int acum = 0;
            float promedio;
            Console.Write("Ingrese 5 numeros aleatorios: ");
            for (int i = 0; i < 5; i++)
            {
                numIngresado = int.Parse(Console.ReadLine());
                if(numIngresado > numMax)
                {
                    numMax = numIngresado;
                }
                if(numIngresado < numMin)
                {
                    numMin = numIngresado;
                }
                acum += numIngresado;
            }
            promedio = (float) acum / 5;
            Console.WriteLine("El numero mas grande fue {0} el numero mas chico {1} y el promedio es {2}", numMax, numMin, promedio);
        }
    }
}

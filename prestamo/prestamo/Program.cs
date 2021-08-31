using Cuentita;
using System;


namespace prestamo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creo que necesito un prestamo!";
            Cuenta c1 = new Cuenta("Elian");

            c1.Ingresar(200.5M);
            c1.Retirar(150.2M);
            Console.WriteLine(c1.Mostrar());
        }
    }
}

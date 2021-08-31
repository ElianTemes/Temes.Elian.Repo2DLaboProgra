using Estudiantes;
using System;

namespace elEjemploUniversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante Pepe = new Estudiante("Grillo", "122", "Pepe");
            Estudiante Mario = new Estudiante("Bros", "133", "Mario");
            Estudiante Luigi = new Estudiante("Bros", "144", "Luigi");
            Pepe.SetNotaPrimerParcial(3);
            Pepe.SetNotaSegundoParcial(2);
            Mario.SetNotaPrimerParcial(7);
            Mario.SetNotaSegundoParcial(8);
            Luigi.SetNotaPrimerParcial(8);
            Luigi.SetNotaSegundoParcial(10);

            Console.WriteLine(Pepe.Mostrar());
            Console.WriteLine();
            Console.WriteLine(Mario.Mostrar());
            Console.WriteLine();
            Console.WriteLine(Luigi.Mostrar());
        }
    }
}

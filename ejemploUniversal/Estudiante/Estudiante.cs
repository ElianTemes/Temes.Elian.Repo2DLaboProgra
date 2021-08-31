using System;
using System.Text;

namespace Estudiantes
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + (float)this.notaSegundoParcial) / 2;
        }
        
        public float CalcularNotaFinal()
        {
            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }
            return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("", 300);
            sb.AppendFormat("Nombre: {0}", nombre);
            sb.AppendLine();
            sb.AppendFormat("Apellido: {0}", apellido);
            sb.AppendLine();
            sb.AppendFormat("Legajo: {0}", legajo);
            sb.AppendLine();
            sb.AppendFormat("Nota primer parcial: {0}", notaPrimerParcial);
            sb.AppendLine();
            sb.AppendFormat("Nota segundo parcial: {0}", notaSegundoParcial);
            sb.AppendLine();
            sb.AppendFormat("Promedio: {0}", CalcularPromedio());
            sb.AppendLine();
            float auxNotaF = CalcularNotaFinal();
            if(!(auxNotaF == -1))
            {
                sb.AppendFormat("Nota final: {0}", auxNotaF);
            }
            else
            {
                sb.Append("Alumno desaprobado!");
            }
            string cadenaAlumno = sb.ToString();

            return cadenaAlumno;
        }
    }
}

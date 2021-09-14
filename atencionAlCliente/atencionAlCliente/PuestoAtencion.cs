using System;
using System.Threading;

namespace BibliotecaAtencion
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        public static int Numero
        {
            get
            {
                return ++numeroActual;
            }
        }
        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente Cli)
        {
            if (Cli is not null)
            {
                Thread.Sleep(2000);
                return true;
            }
            return false;
        }

    }
}

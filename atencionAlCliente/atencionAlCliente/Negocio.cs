using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atencionAlCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio() //constructor privado solo utilizable desde dentro de la clase
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1); //creo un nuevo puesto de atencion con el constructor de la clase que me deja elegir un puesto
            this.clientes = new Queue<Cliente>(); //instancio e inicializo una cola de Cliente
        }
        public Negocio(string nombre)
            : this() //instancio al constructor privado
        {
            this.nombre = nombre;
        }
        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue(); //Quito de la cola al primer cliente que ingreso y lo retorno
            }
            set
            {
                _ = this + value; //Operador descarte para variables que solo queremos el valor pero no guardarlo
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach  (Cliente item in n.clientes)
            {
                if(c == item)
                {
                    return true;
                }               
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
        public static bool operator ~(Negocio n)
        {
            if(n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

    }
}

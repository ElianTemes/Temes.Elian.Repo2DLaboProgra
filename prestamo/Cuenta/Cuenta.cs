using System;

namespace Cuentita
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular)
        {
            this.titular = titular;
            this.cantidad = 0.0M;
        }

        public string GetTitular()
        {
            return titular;
        }
        
        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            return $"Titular: {GetTitular()}, Cantidad: {GetCantidad()}";
        }

        public void Ingresar(decimal monto)
        {
            if(monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(decimal monto)
        {
            if(monto > 0)
            {
                this.cantidad -= monto;
            }
        }
    }
}

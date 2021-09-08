using System;

namespace ProductoNs
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }



        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }
    }
}

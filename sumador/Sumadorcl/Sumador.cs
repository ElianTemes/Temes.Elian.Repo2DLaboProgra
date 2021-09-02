using System;

namespace Suma
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) { }

        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a + b;
        }
        public int GetCantidadSumas()
        {
            return cantidadSumas;
        }
       public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

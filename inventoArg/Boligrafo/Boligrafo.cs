using System;
using System.Text;

namespace Lapicera
{
    public class Boligrafo
    {
        private const short cantidadTintaMaximo = 100;
        private ConsoleColor Color = new ConsoleColor();
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor Color)
        {
            if(tinta <= cantidadTintaMaximo)
            {
                this.tinta = tinta;
            }
            else
            {
                this.tinta = cantidadTintaMaximo;
            }
            this.Color = Color;
        }

        public ConsoleColor GetColor()
        {
            return this.Color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            if((this.tinta += tinta) >= 0 && (this.tinta += tinta) <= cantidadTintaMaximo)
            {
                this.tinta += tinta;
            }
        }
        public void Recargar()
        {
            short tinta = GetTinta();
            tinta = (short)(cantidadTintaMaximo - tinta);
            SetTinta(tinta);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            StringBuilder sb = new StringBuilder();
            short tinta = GetTinta();
            if (gasto == 0 || gasto < 0 || tinta == 0 || tinta < 0)
            {
                sb.Append("No se pinto nada");
                dibujo = sb.ToString();
                return false;
            }
            while(tinta > 0 && gasto > 0)
            {                
                gasto--;
                tinta--;
                sb.Append("*");
            }
            ConsoleColor Color = GetColor();
            Console.ForegroundColor = Color;
            SetTinta(tinta);
            dibujo = sb.ToString();
            return true;
        }
    }
}

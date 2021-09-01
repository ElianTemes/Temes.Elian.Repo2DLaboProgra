using System;

namespace Lapicera
{
    public class Boligrafo
    {
        private const short cantidadTintaMaximo = 100;
        private ConsoleColor Color = new ConsoleColor();
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor Color)
        {
            this.tinta = tinta;
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
    }
}

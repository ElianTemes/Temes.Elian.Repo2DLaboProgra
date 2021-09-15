using Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyagerEstUnPlaisir
{
    class Moto:VehiculoTerrestre
    {
        private short cantidadDeRuedas;
        private short cantidadDePuertas;
        private Colores color;
        private short cilindrada;

        public Moto(short cDeRuedas, short cDePuertas, Colores color, short cilindrada)
        {
            this.cantidadDeRuedas = cDeRuedas;
            this.cantidadDePuertas = cDePuertas;
            this.color = color;
            this.cilindrada = cilindrada;
        }
    }
}

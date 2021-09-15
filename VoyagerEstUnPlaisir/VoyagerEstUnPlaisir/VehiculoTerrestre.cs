using Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyagerEstUnPlaisir
{
    public class VehiculoTerrestre
    {
        protected short cantidadDeRuedas;
        protected short cantidadDePuertas;
        protected Colores color;

        public VehiculoTerrestre(short cDeRuedas, short cDePuertas, Colores color)
        {
            this.cantidadDeRuedas = cDeRuedas;
            this.cantidadDePuertas = cDePuertas;
            this.color = color;
        }
    }
}

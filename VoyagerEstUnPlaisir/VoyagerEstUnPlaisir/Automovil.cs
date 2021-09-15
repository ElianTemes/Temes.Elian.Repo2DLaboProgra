using Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyagerEstUnPlaisir
{
    class Automovil:VehiculoTerrestre
    {
        private short cantidadDeMarchas;
        private int cantidadDePasajeros;

        public Automovil(int cDePasajeros, short cDeMarchas, short cDeRuedas, short cDePuertas, Colores color)
        : base(cDeRuedas, cDePuertas, color)
        {
            this.cantidadDePasajeros = cDePasajeros;
            this.cantidadDeMarchas = cDeMarchas;
        }
    }
}

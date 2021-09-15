using System;
using Color;

namespace VoyagerEstUnPlaisir
{
    public class Camion:VehiculoTerrestre
    {
        private int pesoDeCarga;
        private short cantidadDeMarchas;
        
        public Camion(int pDeCarga, short cDeMarchas, short cDeRuedas, short cDePuertas, Colores color)
        : base(cDeRuedas, cDePuertas, color)
        {
            this.pesoDeCarga = pDeCarga;
            this.cantidadDeMarchas = cDeMarchas;
        }
    }
}

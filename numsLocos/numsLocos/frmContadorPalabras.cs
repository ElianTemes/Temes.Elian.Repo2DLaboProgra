using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numsLocos
{
    public partial class frmContadorPalabras : Form
    {
        public frmContadorPalabras()
        {
            InitializeComponent();
        }

        private void frmContadorPalabras_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();

            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();
            podio.Sort(CompararCantidadRepeticiones);
            MostrarPodio(podio);
        }

        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder sb = new StringBuilder();
            
            if(podio.Count == 0)
            {
                sb.AppendLine("No se ingresaron palabras");
            }
            else
            {
                foreach(KeyValuePair<string, int> in podio)
                {

                }
            }
        }

        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, 
            KeyValuePair<string, int> segundoElemento)
        {
            return primerElemento.Value - segundoElemento.Value;
        }
        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            string texto = rtbEntrada.Text;
            string[] palabras = texto.Split(' ');
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras[palabra]++;
                }
                else
                {
                    contadorPalabras.Add(palabra, 1);
                }
            }
            return contadorPalabras;
        }

        private void rtbEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

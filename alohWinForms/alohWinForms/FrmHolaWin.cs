using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alohWinForms
{
    public partial class FrmHolaWin : Form
    {
        public FrmHolaWin()
        {
            InitializeComponent();
        }
        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaludar_OnClick(sender, e);
            }
        }
        private void btnSaludar_OnClick(object sender, EventArgs e)
        {
            string titulo = "! Hola Windows Form !";
            string mensaje = $"Soy {txtNombre.Text} {txtApellido.Text}.";
            FrmSaludo Saludar = new FrmSaludo(titulo, mensaje);
            Saludar.ShowDialog();
        }

    }
}

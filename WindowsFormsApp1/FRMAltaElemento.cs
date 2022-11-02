using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace WindowsFormsApp1
{
    public partial class FRMAltaElemento : Form
    {
        public FRMAltaElemento()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FRMElemento frmElemento = new FRMElemento();
            frmElemento.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento();
            elemento.nombre = txtBNombre.Text;
            elemento.cantidad = int.Parse(txtBCantidad.Text);
            Principal principal = new Principal();
            principal.RellenarLista();
            principal.AltaElemento(elemento);
            FRMElemento frmElemento = new FRMElemento();
            frmElemento.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FRMElemento frmElemento = new FRMElemento();
            frmElemento.Show();
            this.Hide();

        }
    }
}

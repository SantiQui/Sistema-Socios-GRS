using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FRMModElemento : Form
    {
        public FRMModElemento()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que quieres modificar estos datos?", "Modificar elemento", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Elemento elemento = new Elemento();
                elemento.idElemento = int.Parse(txtBId.Text);
                elemento.cantidad = int.Parse(txtBCantidad.Text);
                elemento.nombre = txtBNombre.Text;
                Principal principal = new Principal();
                principal.RellenarLista();
                principal.ModificarElemento(elemento, int.Parse(txtBId.Text));
                FRMElemento frmElemento = new FRMElemento();
                frmElemento.Show();
                this.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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

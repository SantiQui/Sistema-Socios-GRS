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
    public partial class FRMElemento : Form
    {
        public FRMElemento()
        {
            InitializeComponent();
        }

        private void btnAltaElemento_Click(object sender, EventArgs e)
        {
            FRMAltaElemento frmAltaElemento = new FRMAltaElemento();
            frmAltaElemento.Show();
            this.Hide();
        }

        private void FRMElemento_Load(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            dtgElemento.DataSource = principal.ValidarElemento();

        }

        private void btnModElemento_Click(object sender, EventArgs e)
        {
            FRMModElemento elementoModificado = new FRMModElemento();
            foreach(DataGridViewRow indice in dtgElemento.SelectedRows)
            {
                int idElementoModificado = Convert.ToInt32(indice.Cells[0].Value);
                elementoModificado.txtBId.Text = idElementoModificado.ToString();
                elementoModificado.txtBNombre.Text = indice.Cells[1].Value.ToString();
                elementoModificado.txtBCantidad.Text = indice.Cells[2].Value.ToString();

            }
            elementoModificado.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FRMInicio frmInicio = new FRMInicio();
            frmInicio.Show();
            this.Hide();
        }

        private void btnBajaElemento_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea dar de baja este Elemento?", "Baja elemento", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                foreach (DataGridViewRow indice in dtgElemento.SelectedRows)
                {
                    int idElemento = Convert.ToInt32(indice.Cells[0].Value);
                    Principal principal = new Principal();
                    principal.BajaElemento(idElemento);
                    break;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            dtgElemento.DataSource = principal.ValidarElemento();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FRMInicio frmInicio = new FRMInicio();
            frmInicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMInicio frmInicio = new FRMInicio();
            frmInicio.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            string nombreElemento = txtBusqueda.Text.ToString();
            dtgElemento.DataSource = principal.BuscarElementoPorNombre(nombreElemento);

        }
    }
}

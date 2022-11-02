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
    public partial class FRMActividad : Form
    {
        public FRMActividad()
        {
            InitializeComponent();
        }

        private void btnAltaActividad_Click(object sender, EventArgs e)
        {
            FRMAltaActividad frmAltaActividad = new FRMAltaActividad();
            frmAltaActividad.Show();
            this.Hide();
        }

        private void FRMActividad_Load(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            dtgActividad.DataSource = principal.ValidarActividad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMInicio frmInicio = new FRMInicio();
            frmInicio.Show();
            this.Hide();
        }

        private void btnModActividad_Click(object sender, EventArgs e)
        {
            FRMModActividades actividadModificada = new FRMModActividades();
            foreach (DataGridViewRow indice in dtgActividad.SelectedRows)
            {
                int idActividadModificada = Convert.ToInt32(indice.Cells[0].Value);
                actividadModificada.txtBID.Text = idActividadModificada.ToString();
                actividadModificada.txtBNombre.Text = indice.Cells[1].Value.ToString();
                actividadModificada.txtBProfesor.Text = indice.Cells[2].Value.ToString();
                actividadModificada.txtBInicio.Text = indice.Cells[3].Value.ToString();
                actividadModificada.txtBFin.Text = indice.Cells[4].Value.ToString();
            }
            actividadModificada.Show();
            this.Hide();
        }

        private void btnBajaActividad_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea dar de baja este Elemento?", "Baja elemento", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                foreach (DataGridViewRow indice in dtgActividad.SelectedRows)
                {
                    int idActividad = Convert.ToInt32(indice.Cells[0].Value);
                    Principal principal = new Principal();
                    principal.BajaActividad(idActividad);
                    break;


                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            dtgActividad.DataSource = principal.ValidarActividad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FRMInicio frmInicio = new FRMInicio();
            frmInicio.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace WindowsFormsApp1
{
    public partial class FRMSocio : Form
    {
        public FRMSocio()
        {
            InitializeComponent();
        }

        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }else
            {
                panel1.Visible = false;
            }
        }

        private void FRMSocio_Load(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.RellenarLista();
            dtgSocio.DataSource = principal.ValidarSocio();
            
        }

        private void btnModSocio_Click(object sender, EventArgs e)
        {

            FRMModSocio socioModificado = new FRMModSocio();
            foreach (DataGridViewRow indice in dtgSocio.SelectedRows)
            {
                int idSocioModificado = Convert.ToInt32(indice.Cells[0].Value);

                socioModificado.txtBID.Text = idSocioModificado.ToString();
                socioModificado.txtBNombre.Text = indice.Cells[1].Value.ToString();
                socioModificado.txtBApellido.Text = indice.Cells[2].Value.ToString();
                socioModificado.txtBTipoDoc.Text = indice.Cells[3].Value.ToString();
                socioModificado.txtBNroDoc.Text = indice.Cells[4].Value.ToString();
                socioModificado.chckBActivo.Text = indice.Cells[5].Value.ToString();
                socioModificado.txtBCelular.Text = indice.Cells[6].Value.ToString();
                socioModificado.dtfechaNac.Text = indice.Cells[7].Value.ToString();
                socioModificado.txtBDireccion.Text = indice.Cells[8].Value.ToString();
            }
            socioModificado.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FRMInicio frmInicio = new FRMInicio();
            frmInicio.Show();
            this.Hide();
        }
        
        private void btnBajaSocio_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea dar de baja este socio?", "Baja socio", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                foreach (DataGridViewRow indice in dtgSocio.SelectedRows)
                {
                    int idSocioEliminado = Convert.ToInt32(indice.Cells[0].Value);
                    Principal principal = new Principal();
                    principal.BajaSocio(idSocioEliminado);
                    break;
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            dtgSocio.DataSource = principal.ValidarSocio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoSocio_Click(object sender, EventArgs e)
        {
            FRMAltaSocio frmAltaSocio = new FRMAltaSocio();
            frmAltaSocio.Show();
            this.Hide();
        }

        private void btnAntiguoSocio_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro que lo quieres dar de alta denuevo", "Alta Socio", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                foreach (DataGridViewRow indice in dtgSocio.SelectedRows)
                {
                    int idSocio = Convert.ToInt32(indice.Cells[0].Value);
                    Principal principal = new Principal();
                    principal.NuevoAltaSocio(idSocio);
                    break;
                }
            }
        }
    }
}

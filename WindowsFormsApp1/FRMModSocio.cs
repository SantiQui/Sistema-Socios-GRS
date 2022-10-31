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
    public partial class FRMModSocio : Form
    {
        public FRMModSocio()
        {
            InitializeComponent();
        }

        private void FRMModSocio_Load(object sender, EventArgs e)
        {
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que quieres modificar estos datos?", "Modificar socio", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Socio socioMoficado = new Socio();
                socioMoficado.activo = bool.Parse(chckBActivo.Text);
                socioMoficado.fechaNac = dtfechaNac.Text;
                socioMoficado.direccion = txtBDireccion.Text;
                socioMoficado.idSocio = int.Parse(txtBID.Text);
                socioMoficado.nombre = txtBNombre.Text;
                socioMoficado.dni = int.Parse(txtBNroDoc.Text);
                socioMoficado.apellido = txtBApellido.Text;
                socioMoficado.tipoDoc = txtBTipoDoc.Text;
                socioMoficado.telefono = txtBCelular.Text;
                Principal principal = new Principal();
                principal.RellenarLista();
                principal.ModificarSocio(socioMoficado, int.Parse(txtBID.Text));
                FRMSocio frmSocio = new FRMSocio();

                frmSocio.Show();
                this.Hide();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FRMSocio frmSocio = new FRMSocio();
            frmSocio.Show();
            this.Hide();
        }
    }
}

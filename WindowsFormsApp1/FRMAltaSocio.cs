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
    public partial class FRMAltaSocio : Form
    {
        public FRMAltaSocio()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Socio socioNuevo = new Socio();
            socioNuevo.activo = chckBActivo.Checked;
            socioNuevo.direccion = txtBDireccion.Text.ToString();
            socioNuevo.fechaNac = dtfechaNac.Text.ToString();
            socioNuevo.telefono = txtBCelular.Text;
            socioNuevo.dni = int.Parse(txtBNroDoc.Text);
            socioNuevo.tipoDoc = txtBTipoDoc.Text.ToString();
            socioNuevo.apellido = txtBApellido.Text.ToString();
            socioNuevo.nombre = txtBNombre.Text.ToString();
            Principal principal = new Principal();
            principal.RellenarLista();
            principal.AltaSocio(socioNuevo);

            FRMSocio frmSocio = new FRMSocio();
            frmSocio.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FRMSocio frmSocio = new FRMSocio();
            frmSocio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FRMSocio frmSocio = new FRMSocio();
            frmSocio.Show();
            this.Hide();
        }
    }
}

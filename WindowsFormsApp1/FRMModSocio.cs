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
                socioMoficado.telefono = long.Parse(txtBCelular.Text);
                Principal principal = new Principal();
                principal.RellenarLista();
                principal.ModificarSocio(socioMoficado, int.Parse(txtBID.Text));
                FRMSocio frmSocio = new FRMSocio();

                frmSocio.Show();
                this.Hide();
            }

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

        private void txtBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se puede escribir letras", "Validacion", MessageBoxButtons.OK);
            }
        }

        private void txtBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se puede escribir letras", "Validacion", MessageBoxButtons.OK);
            }
        }

        private void txtBNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se puede escribir numero", "Validacion", MessageBoxButtons.OK);
            }
        }
    }
}

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
    public partial class FRMAltaProfesor : Form
    {
        public FRMAltaProfesor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor();
            profesor.activo = true;
            profesor.dni = int.Parse(txtBNroDoc.Text);
            profesor.apellido = txtBApellido.Text;
            profesor.telefono = long.Parse(txtBCelular.Text);
            profesor.fechaNac = dtfechaNac.Text;
            profesor.nombre = txtBNombre.Text;
            profesor.correoElec = txtBCorreo.Text;
            profesor.tipoDoc = txtBTipoDoc.Text;
            Principal principal = new Principal();
            principal.RellenarLista();
            principal.AltaProfesor(profesor);
            FRMProfesores frmProfesor = new FRMProfesores();
            frmProfesor.Show();
            this.Hide();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FRMProfesores frmProfesor = new FRMProfesores();
            frmProfesor.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FRMProfesores frmProfesor = new FRMProfesores();
            frmProfesor.Show();
            this.Hide();
        }

        private void txtBNombre_TextChanged(object sender, EventArgs e)
        {

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

        private void txtBApellido_TextChanged(object sender, EventArgs e)
        {

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

        private void txtBNroDoc_TextChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show("Solo se puede escribir numeros", "Validacion", MessageBoxButtons.OK);
            }
        }
    }
}

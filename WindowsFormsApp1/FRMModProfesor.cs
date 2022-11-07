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
    public partial class FRMModProfesor : Form
    {
        public FRMModProfesor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que quieres modificar estos datos?","Modificar profesor",  MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Profesor profesor = new Profesor();
                profesor.idProfesor = int.Parse(txtBID.Text);
                profesor.nombre = txtBNombre.Text;
                profesor.apellido = txtBApellido.Text;
                profesor.activo = bool.Parse(chckBActivo.Text);
                profesor.dni = int.Parse(txtBNroDoc.Text);
                profesor.tipoDoc = txtBTipoDoc.Text;
                profesor.correoElec = txtBCorreo.Text;
                profesor.telefono = long.Parse(txtBCelular.Text);
                profesor.fechaNac = dtfechaNac.Text;
                Principal principal = new Principal();
                principal.RellenarLista();
                principal.ModificarProfesor(profesor, int.Parse(txtBID.Text));
                FRMProfesores frmProfesor = new FRMProfesores();
                frmProfesor.Show();
                this.Hide();
            }
            
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
                MessageBox.Show("Solo se puede escribir numeros", "Validacion", MessageBoxButtons.OK);
            }
        }
    }
}

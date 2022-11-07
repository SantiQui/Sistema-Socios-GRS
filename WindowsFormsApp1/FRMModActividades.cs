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
    public partial class FRMModActividades : Form
    {
        public FRMModActividades()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FRMActividad frmActividad = new FRMActividad();
            frmActividad.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que quieres modificar estos datos?", "Modificar actividad", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Actividad actividad = new Actividad();
                
                actividad.profesor = txtBProfesor.Text;
                actividad.nombre = txtBNombre.Text;
                actividad.horarioInicio = txtBInicio.Text;
                actividad.horarioFin = txtBFin.Text;
                Principal principal = new Principal();
                principal.RellenarLista();
                principal.ModificarActividad(actividad, int.Parse(txtBID.Text));
                FRMActividad frmActividad = new FRMActividad();
                frmActividad.Show();
                this.Hide();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FRMActividad frmActividad = new FRMActividad();
            frmActividad.Show();
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

        private void txtBProfesor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBProfesor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Solo se puede escribir una hora", "Validacion", MessageBoxButtons.OK);
            //}
        }
    }
}

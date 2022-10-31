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
            profesor.telefono = txtBCelular.Text;
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
    }
}

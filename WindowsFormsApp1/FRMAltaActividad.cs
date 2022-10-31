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
    public partial class FRMAltaActividad : Form
    {
        public FRMAltaActividad()
        {
            InitializeComponent();
        }
 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FRMActividad frmActividad = new FRMActividad();
            frmActividad = new FRMActividad();
            frmActividad.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Actividad actividadNuevo = new Actividad();
            FRMActividad frmActividad=new FRMActividad();
            actividadNuevo.nombre = txtBNombre.Text;
            actividadNuevo.profesor = txtBProfesor.Text;
            actividadNuevo.horarioInicio = txtBInicio.Text;
            actividadNuevo.horarioFin = txtBFin.Text;
            Principal principal = new Principal();
            principal.RellenarLista();
            principal.AltaActividad(actividadNuevo);
            frmActividad.Show();
            this.Hide();
        }
    }
}

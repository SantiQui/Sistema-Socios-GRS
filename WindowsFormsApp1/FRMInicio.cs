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
    public partial class FRMInicio : Form
    {
        public FRMInicio()
        {
            InitializeComponent();
        }

        

        private void FRMInicio_Load(object sender, EventArgs e)
        {
            PersistenciaDeDatos instanciaPersistencia = new PersistenciaDeDatos();
            instanciaPersistencia.InicializarArchivos();
            Principal instanciaPrincipal = new Principal();
            instanciaPrincipal.RellenarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMSocio frmSocio = new FRMSocio();
            frmSocio.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRMProfesores frmProfesores = new FRMProfesores();
            frmProfesores.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRMElemento frmElemento = new FRMElemento();
            frmElemento.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMActividad frmActividad = new FRMActividad();
            frmActividad.Show();
            this.Hide();
        }
    }
}

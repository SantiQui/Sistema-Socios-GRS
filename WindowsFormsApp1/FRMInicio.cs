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
    public partial class FRMInicio : Form
    {
        public FRMInicio()
        {
            InitializeComponent();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            FRMSocio frmSocio = new FRMSocio();
            frmSocio.Show();
            this.Hide();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            FRMProfesores frmProfesor = new FRMProfesores();
            frmProfesor.Show();
            this.Hide();
        }

        private void btnElementos_Click(object sender, EventArgs e)
        {
            FRMElemento frmElemento = new FRMElemento();
            frmElemento.Show();
            this.Hide();

        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            FRMActividad frmActividad = new FRMActividad();
            frmActividad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FRMLogin frmLogin = new FRMLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}

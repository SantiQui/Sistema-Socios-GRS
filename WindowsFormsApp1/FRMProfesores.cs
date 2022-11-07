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
using System.Xml.XPath;

namespace WindowsFormsApp1
{
    public partial class FRMProfesores : Form
    {
        public FRMProfesores()
        {
            InitializeComponent();
        }

        private void btnAltaProfesor_Click(object sender, EventArgs e)
        {
            if(panel1.Visible == false)
            {
                panel1.Visible = true;
            }else
            {
                panel1.Visible = false;
            }
        }
        private void FRMProfesores_Load(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            dtgProfesor.DataSource = principal.ValidarProfesor();
        }
        private void btnBajaProfesor_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea dar de baja este profesor?", "Baja profesor", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                foreach(DataGridViewRow indice in dtgProfesor.SelectedRows)
                {
                    int idProfesor = Convert.ToInt32(indice.Cells[0].Value);
                    Principal principal = new Principal();
                    principal.BajaProfesor(idProfesor);
                }
            }

        }
        private void btnModProfeosr_Click(object sender, EventArgs e)
        {
            FRMModProfesor profesorModificado = new FRMModProfesor();
            foreach (DataGridViewRow indice in dtgProfesor.SelectedRows)
            {
                int idProfesorModificado = Convert.ToInt32(indice.Cells[0].Value);


                profesorModificado.txtBID.Text = idProfesorModificado.ToString();
                profesorModificado.txtBNombre.Text = indice.Cells[1].Value.ToString();
                profesorModificado.txtBApellido.Text = indice.Cells[2].Value.ToString();
                profesorModificado.txtBTipoDoc.Text = indice.Cells[3].Value.ToString();
                profesorModificado.txtBNroDoc.Text = indice.Cells[4].Value.ToString();
                profesorModificado.chckBActivo.Text = indice.Cells[5].Value.ToString();
                profesorModificado.txtBCelular.Text = indice.Cells[6].Value.ToString();
                profesorModificado.dtfechaNac.Text = indice.Cells[7].Value.ToString();
                profesorModificado.txtBCorreo.Text = indice.Cells[8].Value.ToString();
            }
            profesorModificado.Show();
            this.Hide();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            dtgProfesor.DataSource = principal.ValidarProfesor();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FRMInicio frmInicio = new FRMInicio();
            frmInicio.Show();
            this.Hide();
        }
        private void btnNuevoProfesor_Click(object sender, EventArgs e)
        {
            FRMAltaProfesor frmAltaProfesor = new FRMAltaProfesor();
            frmAltaProfesor.Show();
            this.Hide();
        }
        private void btnAntiguoProfesor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea dar de alta este profesor denuevo?", "Alta profesor", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow indice in dtgProfesor.SelectedRows)
                {
                    int idProfesor = Convert.ToInt32(indice.Cells[0].Value);
                    Principal principal = new Principal();
                    principal.NuevoAltaProfesor(idProfesor);
                    break;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            int dniProfesor = int.Parse(txtBusqueda.Text);
            dtgProfesor.DataSource = principal.BuscarProfesorPorDni(dniProfesor);
        }
    }
}

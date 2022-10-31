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
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }
        
        private bool validarUsuario(string nombre, string clave)
        {
            return (nombre == "admin") && (clave == "admin");
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 0)
            {

                if (validarUsuario(txtBUsuario.Text.Trim(), txtBContraseña.Text.Trim()))
                {
                    FRMInicio frmInicio= new FRMInicio();
                    frmInicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o clave Incorrecta");
                }
            }
        }

    }
}


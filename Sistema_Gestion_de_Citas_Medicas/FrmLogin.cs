using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_de_Citas_Medicas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void picLogoLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            errorProviderLogin.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProviderLogin.SetError(txtUsuario, "Ingrese su usuario.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                errorProviderLogin.SetError(txtContraseña, "Ingrese su contraseña.");
                esValido = false;
            }

            if (!esValido) return;

            // FASE 2: Aquí llamarás a la capa de datos de Ana para validar la clave en SQL
            // Ejemplo de asignación de sesión según el rol devuelto:
            SesionUsuario.Username = txtUsuario.Text.Trim();

            // FrmMenuPrincipal cargará la vista según este rol
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkRegistratrse_Click(object sender, EventArgs e)
        {
            FrmRegistrocs frmRegistro = new FrmRegistrocs();
            frmRegistro.Show();
            this.Hide();
        }
    }
}

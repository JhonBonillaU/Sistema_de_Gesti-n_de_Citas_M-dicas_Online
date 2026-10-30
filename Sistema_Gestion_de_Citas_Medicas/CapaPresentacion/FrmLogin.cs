using Sistema_Gestion_de_Citas_Medicas.CapaDatos;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;
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
			if (!esValido)
			{
				return; // Detiene la ejecución si hay errores en los campos
			}

			string usuarioIngresado = txtUsuario.Text.Trim();
            string passwordIngresada = txtContraseña.Text.Trim();

            try
            {
                UsuarioDAL usuarioDal = new UsuarioDAL();


                Usuario usuarioEncontrado = usuarioDal.ValidarLogin(usuarioIngresado, passwordIngresada);

                // Si el objeto NO es nulo, significa que el usuario y la contraseña son correctos
                if (usuarioEncontrado != null)
                {
                    // Guardamos los datos en la sesión global para usarlos en el menú principal
                    SesionUsuario.Username = usuarioEncontrado.Username; 
                    SesionUsuario.Rol = usuarioEncontrado.Rol;               // ¡Guardamos el rol real desde la BD!

					// Verificamos si el usuario es un Paciente o un Médico para extraer su ID específico
					if (usuarioEncontrado is Paciente paciente)
					{
						SesionUsuario.IdPaciente = paciente.ID_Paciente;
					}
					else if (usuarioEncontrado is Medico medico)
					{
						SesionUsuario.IdMedico = medico.ID_Medico;
					}

					MessageBox.Show("¡Inicio de sesión exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    // Si devuelve null, las credenciales son incorrectas
                    MessageBox.Show("Usuario o contraseña incorrectos. Verifique sus datos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* if (!esValido) return;

             // FASE 2: Aquí llamarás a la capa de datos de Ana para validar la clave en SQL
             // Ejemplo de asignación de sesión según el rol devuelto:
             SesionUsuario.Username = txtUsuario.Text.Trim();

             // FrmMenuPrincipal cargará la vista según este rol
             FrmMenuPrincipal menu = new FrmMenuPrincipal();
             menu.Show();
             this.Hide();*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void lnkRegistratrse_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro(this);
            frmRegistro.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

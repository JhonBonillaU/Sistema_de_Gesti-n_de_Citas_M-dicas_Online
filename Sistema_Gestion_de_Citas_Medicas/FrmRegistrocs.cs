using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_de_Citas_Medicas
{
    public partial class FrmRegistrocs : Form
    {
        public FrmRegistrocs()
        {
            InitializeComponent();
        }

        // Restringir ingreso en el teléfono a solo números y guion
        private void txtTelefonoRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        // Validar formato estándar de correo
        private bool EsCorreoValido(string correo)
        {
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void FrmRegistrocs_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProviderRegistro.Clear();
            bool esValido = true;

            // 1. Validar Nombre y Apellido
            if (string.IsNullOrWhiteSpace(txtNombreRegistro.Text))
            {
                errorProviderRegistro.SetError(txtNombreRegistro, "El nombre es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidoRegistro.Text))
            {
                errorProviderRegistro.SetError(txtApellidoRegistro, "El apellido es obligatorio.");
                esValido = false;
            }

            // 2. Validar Correo
            if (string.IsNullOrWhiteSpace(txtCorreoRegistro.Text) || !EsCorreoValido(txtCorreoRegistro.Text.Trim()))
            {
                errorProviderRegistro.SetError(txtCorreoRegistro, "Ingrese un correo electrónico válido.");
                esValido = false;
            }

            // 3. Validar Usuario y Contraseña
            if (string.IsNullOrWhiteSpace(txtNombreUsuarioRegistro.Text))
            {
                errorProviderRegistro.SetError(txtNombreUsuarioRegistro, "Defina un nombre de usuario.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseñaRegistro.Text))
            {
                errorProviderRegistro.SetError(txtContraseñaRegistro, "Ingrese una contraseña.");
                esValido = false;
            }

            if (txtContraseñaRegistro.Text != txtConfirmarContraseñaRegistro.Text)
            {
                errorProviderRegistro.SetError(txtConfirmarContraseñaRegistro, "Las contraseñas no coinciden.");
                esValido = false;
            }

            if (!esValido) return;

            // --- ASIGNACIÓN AUTOMÁTICA DE ROL ---
            // Como este formulario es exclusivo de pacientes, asignamos el rol directamente sin darle opción al usuario
            string rolAsignado = "Paciente";

            // FASE 2: Aquí llamarás a la capa de datos de Ana para insertar en la tabla Paciente/Usuario en SQL
            MessageBox.Show($"¡Registro completado exitosamente!\n\nBienvenido/a {txtNombreRegistro.Text}. Ya puedes iniciar sesión con tu usuario.",
                            "Registro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Regresa al Login
        }

        private void btnCancelarRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

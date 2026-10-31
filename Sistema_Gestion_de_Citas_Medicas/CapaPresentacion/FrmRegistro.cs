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
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;
using Sistema_Gestion_de_Citas_Medicas.CapaDatos;

namespace Sistema_Gestion_de_Citas_Medicas
{
    public partial class FrmRegistro : Form
    {
        private Form frmLoginOriginal;

        public FrmRegistro(Form login)
        {
            InitializeComponent();
            this.frmLoginOriginal = login;
        }

        private void VolverLogin()
        {
            if (frmLoginOriginal != null)
            {
                frmLoginOriginal.Show();    
            }

            this.Close();
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

            try
            {
                // 1. Crear la entidad Paciente con los datos del formulario
                Paciente nuevoPaciente = new Paciente
                {
                    Nombre = txtNombreRegistro.Text.Trim(),
                    Apellido = txtApellidoRegistro.Text.Trim(),
                    FechaNacimiento = dtpFechaNacimientoRegistro.Value, 
                    Telefono = mtxtTelefonoRegistro.Text.Trim(),
                    Correo = txtCorreoRegistro.Text.Trim()
                };

                // 2. Instanciar la Capa de Datos 
                PacienteDAL pacienteDAL = new PacienteDAL();

                // 3. Ejecutar el método de registro (Inserta en Paciente y Usuario usando Transacción SQL)
                bool resultado = pacienteDAL.RegistrarPaciente(
                    nuevoPaciente,
                    txtNombreUsuarioRegistro.Text.Trim(),
                    txtContraseñaRegistro.Text.Trim()
                );

                if (resultado)
                {
                    MessageBox.Show($"¡Registro completado exitosamente y guardado en la Base de Datos!\n\nBienvenido/a {txtNombreRegistro.Text}.",
                                    "Registro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    VolverLogin(); // Regresa al Login
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al registrar el usuario en la base de datos: " + ex.Message,
                                "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarRegistrar_Click(object sender, EventArgs e)
        {
            VolverLogin();
        }
    }
}

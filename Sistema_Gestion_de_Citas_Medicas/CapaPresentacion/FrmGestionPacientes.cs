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
    public partial class FrmGestionPacientes : Form
    {
        public FrmGestionPacientes()
        {
            InitializeComponent();
        }

        // Restringir ingreso de letras en campo de teléfono (solo números y guion)
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Ignora la tecla presionada
            }
        }

        private bool EsCorreoValido(string correo)
        {
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Limpia errores previos
            errorProviderPacientes.Clear();
            bool esValido = true;

            // Validar Nombre Obligatorio
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProviderPacientes.SetError(txtNombre, "El nombre del paciente es obligatorio.");
                esValido = false;
            }

            // Validar Apellido Obligatorio
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                errorProviderPacientes.SetError(txtApellido, "El apellido es obligatorio.");
                esValido = false;
            }

            // Validar Correo Electrónico
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !EsCorreoValido(txtCorreo.Text.Trim()))
            {
                errorProviderPacientes.SetError(txtCorreo, "El formato de correo no es válido (ej. usuario@dominio.com).");
                esValido = false;
            }

            if (!esValido)
            {
                return; // Detiene la ejecución si hay errores visuales
            }

            // FASE 2: Aquí llamas al método de Ana/Backend para guardar en la BD
            MessageBox.Show("Datos del paciente validados y listos para registrar en SQL Server.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
 }


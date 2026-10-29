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
using Sistema_Gestion_de_Citas_Medicas.CapaDatos;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas
{
    public partial class FrmGestionPacientes : Form
    {
        public FrmGestionPacientes()
        {
            InitializeComponent();
        }
		private void CargarGridPacientes()
		{
			try
			{
				PacienteDAL dal = new PacienteDAL();
				dgvPacientes.DataSource = dal.ListarPacientes();

				// 1. Ocultar las columnas heredadas de Usuario que no deseas mostrar
				if (dgvPacientes.Columns["IdUsuario"] != null) dgvPacientes.Columns["IdUsuario"].Visible = false;
				if (dgvPacientes.Columns["Username"] != null) dgvPacientes.Columns["Username"].Visible = false;
				if (dgvPacientes.Columns["Password"] != null) dgvPacientes.Columns["Password"].Visible = false;
				if (dgvPacientes.Columns["Rol"] != null) dgvPacientes.Columns["Rol"].Visible = false;
				if (dgvPacientes.Columns["ID_Paciente"] != null) dgvPacientes.Columns["ID_Paciente"].Visible = false;
				if (dgvPacientes.Columns["ID_Medico"] != null) dgvPacientes.Columns["ID_Medico"].Visible = false;

				// 2. Opcional: Personalizar el nombre de las columnas que sí se muestran
				if (dgvPacientes.Columns["IdPaciente"] != null)
					dgvPacientes.Columns["IdPaciente"].HeaderText = "ID";

				if (dgvPacientes.Columns["FechaNacimiento"] != null)
					dgvPacientes.Columns["FechaNacimiento"].HeaderText = "Fecha de Nacimiento";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Restringir ingreso de letras en campo de teléfono (solo números y guion)
		private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Ignora la tecla presionada
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
			try
			{
				Paciente nuevoPaciente = new Paciente
				{
					Nombre = txtNombre.Text.Trim(),
					Apellido = txtApellido.Text.Trim(),
					FechaNacimiento = dtpFechaNacimiento.Value,
					Telefono = txtTelefono.Text.Trim(),
					Correo = txtCorreo.Text.Trim()
				};

				// Username por defecto basado en el correo o nombre, o puedes agregar campos para el login
				string username = txtCorreo.Text.Trim();
				string password = "123"; // Contraseña por defecto temporal o un campo dedicado

				PacienteDAL dal = new PacienteDAL();
				if (dal.RegistrarPaciente(nuevoPaciente, username, password))
				{
					MessageBox.Show("Paciente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridPacientes();
					LimpiarCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void FrmGestionPacientes_Load(object sender, EventArgs e)
        {
			CargarGridPacientes();
			txtIdPaciente.Enabled = false;
			dgvPacientes.CellClick += dgvPacientes_CellContentClick; // Vincular el evento CellClick al método
		}



		private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Verificamos que se haya seleccionado una fila válida (y no el encabezado)
			if (e.RowIndex >= 0)
			{
				// Obtenemos el objeto Paciente directamente de los datos enlazados a la fila
				Paciente p = dgvPacientes.Rows[e.RowIndex].DataBoundItem as Paciente;

				if (p != null)
				{
					txtIdPaciente.Text = p.IdPaciente.ToString();
					txtNombre.Text = p.Nombre;
					txtApellido.Text = p.Apellido;
					dtpFechaNacimiento.Value = p.FechaNacimiento;
					txtTelefono.Text = p.Telefono;
					txtCorreo.Text = p.Correo;
				}
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtIdPaciente.Text))
				{
					MessageBox.Show("Seleccione un paciente de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Paciente pacienteMod = new Paciente
				{
					IdPaciente = Convert.ToInt32(txtIdPaciente.Text),
					Nombre = txtNombre.Text.Trim(),
					Apellido = txtApellido.Text.Trim(),
					FechaNacimiento = dtpFechaNacimiento.Value,
					Telefono = txtTelefono.Text.Trim(),
					Correo = txtCorreo.Text.Trim()
				};

				PacienteDAL dal = new PacienteDAL();
				if (dal.ActualizarPaciente(pacienteMod))
				{
					MessageBox.Show("Paciente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridPacientes();
					LimpiarCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtIdPaciente.Text))
				{
					MessageBox.Show("Seleccione un paciente de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este paciente y sus credenciales de acceso?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (resultado == DialogResult.Yes)
				{
					int idPaciente = Convert.ToInt32(txtIdPaciente.Text);
					PacienteDAL dal = new PacienteDAL();

					if (dal.EliminarPaciente(idPaciente))
					{
						MessageBox.Show("Paciente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						CargarGridPacientes();
						LimpiarCampos();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
		}

		private void LimpiarCampos()
		{
			txtIdPaciente.Clear();
			txtNombre.Clear();
			txtApellido.Clear();
			txtTelefono.Clear();
			txtCorreo.Clear();
			dtpFechaNacimiento.Value = DateTime.Today;
		}
	}
 }


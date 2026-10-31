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
		// Constructor del formulario
		public FrmGestionPacientes()
        {
            InitializeComponent();
        }

		// Método para cargar los pacientes en el DataGridView
		private void CargarGridPacientes()
		{
			// Intentamos cargar los pacientes y manejar cualquier excepción que pueda ocurrir
			try
			{
				// Creamos una instancia de PacienteDAL para acceder a los datos de los pacientes
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

		// Validar formato de correo electrónico
		private void btnGuardar_Click(object sender, EventArgs e)
        {
			// Validación de campos obligatorios
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
										 // Validación de correo electrónico
				PacienteDAL dal = new PacienteDAL();
				if (dal.RegistrarPaciente(nuevoPaciente, username, password))
				{
					MessageBox.Show("Paciente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridPacientes();
					LimpiarCampos();
				}
			}
			// Manejo de excepciones para capturar errores al registrar el paciente
			catch (Exception ex)
			{
				MessageBox.Show("Error al registrar paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al cargar el formulario
		private void FrmGestionPacientes_Load(object sender, EventArgs e)
        {
			CargarGridPacientes();
			// Deshabilitamos el campo de ID del paciente para que no sea editable por el usuario
			txtIdPaciente.Enabled = false;
			dgvPacientes.CellClick += dgvPacientes_CellContentClick; // Vincular el evento CellClick al método
		}

		// Evento que se dispara al hacer clic en una celda del DataGridView
		private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Verificamos que se haya seleccionado una fila válida (y no el encabezado)
			if (e.RowIndex >= 0)
			{
				// Obtenemos el objeto Paciente directamente de los datos enlazados a la fila
				Paciente p = dgvPacientes.Rows[e.RowIndex].DataBoundItem as Paciente;

				// Validamos que el paciente obtenido no sea nulo antes de asignar los valores a los campos de texto
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

		// Evento que se dispara al hacer clic en el botón "Modificar"
		private void btnModificar_Click(object sender, EventArgs e)
		{
			// Intentamos modificar el paciente y manejar cualquier excepción que pueda ocurrir
			try
			{
				// Validamos que el usuario haya seleccionado un paciente antes de intentar modificarlo
				if (string.IsNullOrEmpty(txtIdPaciente.Text))
				{
					MessageBox.Show("Seleccione un paciente de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				// Creamos un objeto Paciente con los datos modificados por el usuario
				Paciente pacienteMod = new Paciente
				{
					IdPaciente = Convert.ToInt32(txtIdPaciente.Text),
					Nombre = txtNombre.Text.Trim(),
					Apellido = txtApellido.Text.Trim(),
					FechaNacimiento = dtpFechaNacimiento.Value,
					Telefono = txtTelefono.Text.Trim(),
					Correo = txtCorreo.Text.Trim()
				};

				// Llamamos al método ActualizarPaciente de la capa de datos para actualizar la información del paciente
				PacienteDAL dal = new PacienteDAL();
				if (dal.ActualizarPaciente(pacienteMod))
				{
					MessageBox.Show("Paciente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridPacientes();
					LimpiarCampos();
				}
			}

			// Manejo de excepciones para capturar errores al modificar el paciente
			catch (Exception ex)
			{
				MessageBox.Show("Error al modificar paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al hacer clic en el botón "Eliminar"
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			// Intentamos eliminar el paciente y manejar cualquier excepción que pueda ocurrir
			try
			{
				// Validamos que el usuario haya seleccionado un paciente antes de intentar eliminarlo
				if (string.IsNullOrEmpty(txtIdPaciente.Text))
				{
					MessageBox.Show("Seleccione un paciente de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				// Mostramos un cuadro de diálogo para confirmar la eliminación del paciente
				DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este paciente y sus credenciales de acceso?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				// Si el usuario confirma, procedemos a eliminar el paciente
				if (resultado == DialogResult.Yes)
				{
					int idPaciente = Convert.ToInt32(txtIdPaciente.Text);
					PacienteDAL dal = new PacienteDAL();
					// Intentamos eliminar el paciente y mostramos un mensaje de éxito si se elimina correctamente
					if (dal.EliminarPaciente(idPaciente))
					{
						MessageBox.Show("Paciente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						CargarGridPacientes();
						LimpiarCampos();
					}
				}
			}
			// Manejo de excepciones para capturar errores al eliminar el paciente
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al hacer clic en el botón "Limpiar"
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
		}

		// Método para limpiar los campos de texto del formulario
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


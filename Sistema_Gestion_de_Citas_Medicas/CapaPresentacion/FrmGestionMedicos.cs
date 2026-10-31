using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Gestion_de_Citas_Medicas.CapaDatos;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas
{
    public partial class FrmGestionMedicos : Form
    {
		// Constructor del formulario
		public FrmGestionMedicos()
        {
            InitializeComponent();
        }

		// Evento que se dispara al cargar el formulario
		private void FrmGestionMedico_Load(object sender, EventArgs e)
        {
			CargarEspecialidadesComboBox();
			CargarGridMedicos();
			// Configuración de campos en modo lectura
			txtIdMedico.Enabled = false;
		}

		// Método para cargar las especialidades en el ComboBox
		private void CargarEspecialidadesComboBox()
		{
			// Intentamos cargar las especialidades y manejar cualquier excepción que pueda ocurrir
			try
			{
				EspecialidadDAL espDal = new EspecialidadDAL();
				cmbEspecialidad.DataSource = espDal.ListarEspecialidades();
				cmbEspecialidad.DisplayMember = "NombreEspecialidad"; // Lo que ve el usuario
				cmbEspecialidad.ValueMember = "IdEspecialidad";       // El ID interno
				cmbEspecialidad.SelectedIndex = -1;
			}
			// Capturamos cualquier excepción que ocurra al cargar las especialidades y mostramos un mensaje de error
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar especialidades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Método para cargar los médicos en el DataGridView
		private void CargarGridMedicos()
		{
			// Intentamos cargar los médicos y manejar cualquier excepción que pueda ocurrir
			try
			{
				MedicoDAL dal = new MedicoDAL();
				dgvMedicos.DataSource = dal.ListarMedicos();

				// Ocultar columnas heredadas de Usuario que no se deben mostrar directamente
				if (dgvMedicos.Columns["IdUsuario"] != null) dgvMedicos.Columns["IdUsuario"].Visible = false;
				if (dgvMedicos.Columns["Username"] != null) dgvMedicos.Columns["Username"].Visible = false;
				if (dgvMedicos.Columns["Password"] != null) dgvMedicos.Columns["Password"].Visible = false;
				if (dgvMedicos.Columns["Rol"] != null) dgvMedicos.Columns["Rol"].Visible = false;
				if (dgvMedicos.Columns["ID_Paciente"] != null) dgvMedicos.Columns["ID_Paciente"].Visible = false;
				if (dgvMedicos.Columns["ID_Medico"] != null) dgvMedicos.Columns["ID_Medico"].Visible = false;
				if (dgvMedicos.Columns["IdEspecialidad"] != null) dgvMedicos.Columns["IdEspecialidad"].Visible = false;
				// Configuración de encabezados de columnas
				if (dgvMedicos.Columns["IdMedico"] != null)
					dgvMedicos.Columns["IdMedico"].HeaderText = "ID Médico";
			}
			// Capturamos cualquier excepción que ocurra al cargar los médicos y mostramos un mensaje de error
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar médicos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al hacer clic en una celda del DataGridView
		private void dgvMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Verificamos que se haya seleccionado una fila válida (y no el encabezado)
			if (e.RowIndex >= 0)
			{
				// Obtenemos el objeto Medico directamente de los datos enlazados a la fila
				Medico m = dgvMedicos.Rows[e.RowIndex].DataBoundItem as Medico;

				if (m != null)
				{
					txtIdMedico.Text = m.IdMedico.ToString();
					txtNombre.Text = m.Nombre;
					txtApellido.Text = m.Apellido;
					txtTelefono.Text = m.Telefono;
					txtCorreo.Text = m.Correo;

					// Asignamos la especialidad correspondiente en el ComboBox usando su ID
					cmbEspecialidad.SelectedValue = m.IdEspecialidad;
				}
			}
		}

		// Evento que se dispara al hacer clic en el botón "Guardar Médico"
		private void btnGuardarMedico_Click(object sender, EventArgs e)
		{
			// Intentamos registrar el médico y manejar cualquier excepción que pueda ocurrir
			try
			{
				// Validaciones básicas de controles vacíos
				if (cmbEspecialidad.SelectedIndex == -1)
				{
					MessageBox.Show("Por favor, seleccione una especialidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				// Creamos un nuevo objeto Medico con los datos ingresados por el usuario
				Medico nuevoMedico = new Medico
				{
					Nombre = txtNombre.Text.Trim(),
					Apellido = txtApellido.Text.Trim(),
					Telefono = txtTelefono.Text.Trim(),
					Correo = txtCorreo.Text.Trim(),
					IdEspecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue)
				};
				// Generamos un nombre de usuario y una contraseña temporal para el médico
				string username = txtCorreo.Text.Trim();
				string password = "123"; // Contraseña temporal por defecto
				// Creamos una instancia de MedicoDAL para interactuar con la base de datos
				MedicoDAL dal = new MedicoDAL();
				if (dal.RegistrarMedico(nuevoMedico, username, password))
				{
					MessageBox.Show("Médico registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridMedicos();
					LimpiarCampos();
				}
			}
			// Capturamos cualquier excepción que ocurra al registrar el médico y mostramos un mensaje de error
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		// Evento que se dispara al hacer clic en el botón "Modificar Médico"
		private void btnModificarMedico_Click(object sender, EventArgs e)
		{
			// Intentamos modificar el médico y manejar cualquier excepción que pueda ocurrir
			try
			{
				// Validamos que el usuario haya seleccionado un médico antes de intentar modificarlo
				if (string.IsNullOrEmpty(txtIdMedico.Text))
				{
					MessageBox.Show("Seleccione un médico de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				// Validamos que el nombre y apellido del médico no estén vacíos antes de intentar modificarlo
				Medico medicoMod = new Medico
				{
					IdMedico = Convert.ToInt32(txtIdMedico.Text),
					Nombre = txtNombre.Text.Trim(),
					Apellido = txtApellido.Text.Trim(),
					Telefono = txtTelefono.Text.Trim(),
					Correo = txtCorreo.Text.Trim(),
					IdEspecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue)
				};
				// Creamos una instancia de MedicoDAL para interactuar con la base de datos
				MedicoDAL dal = new MedicoDAL();
				if (dal.ActualizarMedico(medicoMod))
				{
					MessageBox.Show("Datos del médico actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridMedicos();
					LimpiarCampos();
				}
			}
			// Capturamos cualquier excepción que ocurra al modificar el médico y mostramos un mensaje de error
			catch (Exception ex)
			{
				MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al hacer clic en el botón "Eliminar Médico"
		private void btnEliminarMedico_Click(object sender, EventArgs e)
		{
			// Intentamos eliminar el médico y manejar cualquier excepción que pueda ocurrir
			try
			{
				// Validamos que el usuario haya seleccionado un médico antes de intentar eliminarlo
				if (string.IsNullOrEmpty(txtIdMedico.Text))
				{
					MessageBox.Show("Seleccione un médico de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				// Mostramos un cuadro de diálogo para confirmar la eliminación del médico
				DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este médico y su cuenta de acceso?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				// Si el usuario confirma, procedemos a eliminar el médico
				if (resultado == DialogResult.Yes)
				{
					int idMedico = Convert.ToInt32(txtIdMedico.Text);
					MedicoDAL dal = new MedicoDAL();
					// Intentamos eliminar el médico y mostramos un mensaje de éxito si se elimina correctamente
					if (dal.EliminarMedico(idMedico))
					{
						MessageBox.Show("Médico eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						CargarGridMedicos();
						LimpiarCampos();
					}
				}
			}
			// Manejo de excepciones para capturar errores al eliminar el médico
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al hacer clic en el botón "Limpiar"
		private void btnLimpiarEspecialidad_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
		}

		// Método para limpiar los campos de texto del formulario
		private void LimpiarCampos()
		{
			txtIdMedico.Clear();
			txtNombre.Clear();
			txtApellido.Clear();
			txtTelefono.Clear();
			txtCorreo.Clear();
			cmbEspecialidad.SelectedIndex = -1;
		}
	}
}

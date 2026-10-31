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

namespace Sistema_Gestion_de_Citas_Medicas.CapaPresentacion
{
    public partial class FrmGestionEspecialidades : Form
    {
		// Constructor del formulario
		public FrmGestionEspecialidades()
        {
            InitializeComponent();
        }

		// Evento que se dispara al cargar el formulario
		private void FrmGestionEspecialidades_Load(object sender, EventArgs e)
		{
			CargarGridEspecialidades();
			// Configuración de campos en modo lectura
			txtIdEspecialidad.Enabled = false;
		}

		// Método para cargar las especialidades en el DataGridView
		private void CargarGridEspecialidades()
		{
			// Intentamos cargar las especialidades y manejar cualquier excepción que pueda ocurrir
			try
			{
				EspecialidadDAL dal = new EspecialidadDAL();
				dgvEspecialidades.DataSource = dal.ListarEspecialidades();
				// Configuración de encabezados de columnas
				if (dgvEspecialidades.Columns["IdEspecialidad"] != null)
					dgvEspecialidades.Columns["IdEspecialidad"].HeaderText = "ID";
				// Configuración de encabezados de columnas
				if (dgvEspecialidades.Columns["NombreEspecialidad"] != null)
					dgvEspecialidades.Columns["NombreEspecialidad"].HeaderText = "Nombre de Especialidad";
			}
			// Capturamos cualquier excepción que ocurra al cargar las especialidades y mostramos un mensaje de error
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar especialidades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al hacer clic en una celda del DataGridView
		private void dgvEspecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Intentamos obtener la especialidad seleccionada y manejar cualquier excepción que pueda ocurrir
			if (e.RowIndex >= 0)
			{
				Especialidad esp = dgvEspecialidades.Rows[e.RowIndex].DataBoundItem as Especialidad;
				// Si la especialidad no es nula, llenamos los campos de texto con sus datos
				if (esp != null)
				{
					txtIdEspecialidad.Text = esp.IdEspecialidad.ToString();
					txtNombreEspecialidad.Text = esp.NombreEspecialidad;
				}
			}
		}

		// Evento que se dispara al hacer clic en el botón "Guardar Especialidad"
		private void btnGuardarEspecialidad_Click(object sender, EventArgs e)
		{
			// Intentamos registrar la especialidad y manejar cualquier excepción que pueda ocurrir
			try
			{
				if (string.IsNullOrWhiteSpace(txtNombreEspecialidad.Text))
				{
					MessageBox.Show("Ingrese el nombre de la especialidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Especialidad nuevaEsp = new Especialidad
				{
					NombreEspecialidad = txtNombreEspecialidad.Text.Trim()
				};

				EspecialidadDAL dal = new EspecialidadDAL();
				if (dal.RegistrarEspecialidad(nuevaEsp))
				{
					MessageBox.Show("Especialidad registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridEspecialidades();
					LimpiarCampos();
				}
			}
			// Manejo de excepciones para capturar errores al registrar la especialidad
			catch (Exception ex)
			{
				MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al hacer clic en el botón "Modificar Especialidad"
		private void btnModificarEspecialidad_Click(object sender, EventArgs e)
		{
			// Intentamos modificar la especialidad y manejar cualquier excepción que pueda ocurrir
			try
			{
				// Validamos que el usuario haya seleccionado una especialidad antes de intentar modificarla
				if (string.IsNullOrEmpty(txtIdEspecialidad.Text))
				{
					MessageBox.Show("Seleccione una especialidad de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				// Validamos que el nombre de la especialidad no esté vacío antes de intentar modificarla
				Especialidad espMod = new Especialidad
				{
					IdEspecialidad = Convert.ToInt32(txtIdEspecialidad.Text),
					NombreEspecialidad = txtNombreEspecialidad.Text.Trim()
				};
				// Creamos una instancia de EspecialidadDAL para interactuar con la base de datos
				EspecialidadDAL dal = new EspecialidadDAL();
				if (dal.ActualizarEspecialidad(espMod))
				{
					MessageBox.Show("Especialidad actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridEspecialidades();
					LimpiarCampos();
				}
			}
			// Manejo de excepciones para capturar errores al modificar la especialidad
			catch (Exception ex)
			{
				MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al hacer clic en el botón "Eliminar Especialidad"
		private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
		{
			// Intentamos eliminar la especialidad y manejar cualquier excepción que pueda ocurrir
			try
			{
				// Validamos que el usuario haya seleccionado una especialidad antes de intentar eliminarla
				if (string.IsNullOrEmpty(txtIdEspecialidad.Text))
				{
					MessageBox.Show("Seleccione una especialidad de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				// Mostramos un cuadro de diálogo para confirmar la eliminación de la especialidad
				DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta especialidad?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				// Si el usuario confirma, procedemos a eliminar la especialidad
				if (resultado == DialogResult.Yes)
				{
					int idEspecialidad = Convert.ToInt32(txtIdEspecialidad.Text);
					EspecialidadDAL dal = new EspecialidadDAL();
					// Intentamos eliminar la especialidad y mostramos un mensaje de éxito si se elimina correctamente
					if (dal.EliminarEspecialidad(idEspecialidad))
					{
						MessageBox.Show("Especialidad eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						CargarGridEspecialidades();
						LimpiarCampos();
					}
				}
			}
			// Manejo de excepciones para capturar errores al eliminar la especialidad
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar (es posible que esté asignada a un médico): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			txtIdEspecialidad.Clear();
			txtNombreEspecialidad.Clear();
		}

		// Manejo de excepciones para capturar errores al cargar las especialidades
		private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

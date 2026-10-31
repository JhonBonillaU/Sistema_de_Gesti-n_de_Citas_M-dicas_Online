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
	public partial class FrmEmitirRecetas : Form
	{

		// Variable global en el formulario para almacenar la lista completa
		private List<Cita> listaCitasGlobal = new List<Cita>();

		// Constructor
		public FrmEmitirRecetas()
		{
			InitializeComponent();
		}

		// Evento que se dispara al cargar el formulario
		private void FrmEmitirRecetas_Load(object sender, EventArgs e)
		{
			CargarTodasLasCitas();
			// Configuración de campos en modo lectura
			txtIdCita.Enabled = false;
			txtPaciente.Enabled = false;
		}

		// Método para cargar todas las citas desde la base de datos
		private void CargarTodasLasCitas()
		{
			try
			{
				RecetaDAL dal = new RecetaDAL();
				// Traemos todas las citas activas (Pendientes y Atendidas)
				listaCitasGlobal = dal.ListarCitasPendientesParaReceta();

				// Aplicamos el filtro con la fecha que tenga el DateTimePicker actualmente
				FiltrarCitasPorFecha();

				// Formato de columnas del Grid
				if (dgvCitas.Columns["IdPaciente"] != null) dgvCitas.Columns["IdPaciente"].Visible = false;
				if (dgvCitas.Columns["IdMedico"] != null) dgvCitas.Columns["IdMedico"].Visible = false;
				if (dgvCitas.Columns["Estado"] != null) dgvCitas.Columns["Estado"].Visible = false;
				if (dgvCitas.Columns["DescripcionReceta"] != null) dgvCitas.Columns["DescripcionReceta"].Visible = false; // O true si quieres mostrarla

				if (dgvCitas.Columns["IdCita"] != null) dgvCitas.Columns["IdCita"].HeaderText = "ID Cita";
				if (dgvCitas.Columns["FechaHora"] != null) dgvCitas.Columns["FechaHora"].HeaderText = "Fecha y Hora";
				if (dgvCitas.Columns["NombrePaciente"] != null) dgvCitas.Columns["NombrePaciente"].HeaderText = "Paciente";
				if (dgvCitas.Columns["NombreMedico"] != null) dgvCitas.Columns["NombreMedico"].HeaderText = "Médico";
				if (dgvCitas.Columns["NombreEspecialidad"] != null) dgvCitas.Columns["NombreEspecialidad"].HeaderText = "Especialidad";
			}
			// Capturamos cualquier excepción que ocurra al cargar las citas y mostramos un mensaje de error
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar citas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Método para filtrar las citas según la fecha seleccionada en el DateTimePicker
		private void FiltrarCitasPorFecha()
		{
			if (listaCitasGlobal == null) return;

			// Obtenemos solo la fecha (sin horas/minutos) seleccionada en el DateTimePicker
			DateTime fechaSeleccionada = dtpFecha.Value.Date;

			// Filtramos la lista usando LINQ comparando únicamente la fecha
			var citasFiltradas = listaCitasGlobal
				.Where(c => c.FechaHora.Date == fechaSeleccionada)
				.ToList();

			// Actualizamos el origen de datos de la tabla
			dgvCitas.DataSource = citasFiltradas;
		}

		// Evento que se dispara al cambiar la fecha en el DateTimePicker
		private void dtpFecha_ValueChanged(object sender, EventArgs e)
		{
			FiltrarCitasPorFecha();
		}

		// Evento que se dispara al hacer clic en una celda del DataGridView
		private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Validamos que el índice de la fila sea válido (no encabezado ni fuera de rango)
			if (e.RowIndex >= 0)
			{
				Cita c = dgvCitas.Rows[e.RowIndex].DataBoundItem as Cita;

				// Validamos que la cita obtenida no sea nula antes de asignar los valores a los campos de texto
				if (c != null)
				{
					txtIdCita.Text = c.IdCita.ToString();
					txtPaciente.Text = c.NombrePaciente;
					txtDetalle.Text = c.DescripcionReceta;
				}
			}
		}

		// Evento que se dispara al hacer clic en el botón "Emitir Receta"
		private void btnEmitirReceta_Click(object sender, EventArgs e)
		{
			// Validamos que el usuario haya seleccionado una cita antes de intentar emitir la receta
			try
			{
				// Validamos que el usuario haya seleccionado una cita en el DataGridView
				if (string.IsNullOrEmpty(txtIdCita.Text))
				{
					MessageBox.Show("Por favor, seleccione una cita de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Validamos que el usuario haya ingresado detalles de la receta antes de intentar emitirla
				if (string.IsNullOrWhiteSpace(txtDetalle.Text))
				{
					MessageBox.Show("Debe ingresar las indicaciones o detalles de la receta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Creamos un objeto Receta con los datos ingresados por el usuario
				Receta nuevaReceta = new Receta
				{
					IdCita = Convert.ToInt32(txtIdCita.Text),
					Descripcion = txtDetalle.Text.Trim()
				};

				// Llamamos al método EmitirReceta de la capa de datos para guardar la receta y marcar la cita como atendida
				RecetaDAL dal = new RecetaDAL();
				if (dal.EmitirReceta(nuevaReceta))
				{
					MessageBox.Show("¡Receta emitida con éxito y cita marcada como atendida!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarTodasLasCitas();
					LimpiarCampos();
				}
			}
			// Manejo de excepciones para capturar errores al emitir la receta
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			txtIdCita.Clear();
			txtPaciente.Clear();
			txtDetalle.Clear();
		}

		// Evento que se dispara al hacer clic en el botón "Volver"
		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}
    }
}

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
using System.IO;

namespace Sistema_Gestion_de_Citas_Medicas
{
	public partial class FrmConsultarRecetas : Form
	{
		// Lista global para almacenar las citas con receta
		private List<Cita> listaCitasGlobal = new List<Cita>();

		// Constructor
		public FrmConsultarRecetas()
		{
			InitializeComponent();
		}

		// Evento que se dispara al cargar el formulario
		private void FrmConsultarRecetas_Load_1(object sender, EventArgs e)
		{
			CargarCitasConReceta();
			// Configuración de campos en modo lectura
			txtPaciente.ReadOnly = true;
			dtpFecha.Enabled = true;
			txtDetalle.ReadOnly = true;
		}

		// Método para cargar las citas con receta desde la base de datos
		private void CargarCitasConReceta()
		{
			// Intentamos cargar las citas con receta y manejar cualquier excepción que pueda ocurrir
			try
			{
				RecetaDAL dal = new RecetaDAL();
				listaCitasGlobal = dal.ListarCitasPendientesParaReceta();

				// Aplicamos el filtro inicial según la fecha del DateTimePicker
				FiltrarCitasPorFecha();

				// Ocultar columnas internas innecesarias
				if (dgvCitas.Columns["IdPaciente"] != null) dgvCitas.Columns["IdPaciente"].Visible = false;
				if (dgvCitas.Columns["IdMedico"] != null) dgvCitas.Columns["IdMedico"].Visible = false;
				if (dgvCitas.Columns["Estado"] != null) dgvCitas.Columns["Estado"].Visible = false;
				if (dgvCitas.Columns["DescripcionReceta"] != null) dgvCitas.Columns["DescripcionReceta"].Visible = false;

				if (dgvCitas.Columns["IdCita"] != null) dgvCitas.Columns["IdCita"].HeaderText = "ID Cita";
				if (dgvCitas.Columns["FechaHora"] != null) dgvCitas.Columns["FechaHora"].HeaderText = "Fecha y Hora";
				if (dgvCitas.Columns["NombrePaciente"] != null) dgvCitas.Columns["NombrePaciente"].HeaderText = "Paciente";
				if (dgvCitas.Columns["NombreMedico"] != null) dgvCitas.Columns["NombreMedico"].HeaderText = "Médico";
				if (dgvCitas.Columns["NombreEspecialidad"] != null) dgvCitas.Columns["NombreEspecialidad"].HeaderText = "Especialidad";
			}
			// Capturamos cualquier excepción que ocurra al cargar las citas con receta y mostramos un mensaje de error
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar recetas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Método para filtrar las citas por la fecha seleccionada en el DateTimePicker
		private void FiltrarCitasPorFecha()
		{
			// Evitamos que se ejecute al cargar el formulario por primera vez
			if (listaCitasGlobal == null) return;

			DateTime fechaSeleccionada = dtpFecha.Value.Date;
			// Filtramos la lista global de citas por la fecha seleccionada
			var citasFiltradas = listaCitasGlobal
				.Where(c => c.FechaHora.Date == fechaSeleccionada)
				.ToList();

			// Asignamos la lista filtrada al DataGridView
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
			if (e.RowIndex >= 0)
			{
				Cita c = dgvCitas.Rows[e.RowIndex].DataBoundItem as Cita;

				if (c != null)
				{
					txtPaciente.Text = c.NombrePaciente;
					txtDetalle.Text = string.IsNullOrEmpty(c.DescripcionReceta)
						? "Esta cita aún no tiene receta emitida."
						: c.DescripcionReceta;
				}
			}
		}

		// Evento que se dispara al hacer clic en el botón "Imprimir Receta"
		private void btnImprimirReceta_Click(object sender, EventArgs e)
		{
			// Validamos que el usuario haya seleccionado una cita en el DataGridView
			if (dgvCitas.CurrentRow == null)
			{
				MessageBox.Show("Por favor, seleccione una cita de la lista para exportar la receta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Obtenemos la cita seleccionada y verificamos que tenga una receta asociada
			Cita c = dgvCitas.CurrentRow.DataBoundItem as Cita;

			// Validamos que la cita tenga una receta antes de intentar exportarla
			if (c == null || string.IsNullOrWhiteSpace(c.DescripcionReceta))
			{
				MessageBox.Show("La cita seleccionada no tiene una receta registrada para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Configuración del guardado de archivo
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Archivo de texto (*.txt)|*.txt";
				saveFileDialog.Title = "Guardar Receta Médica";
				saveFileDialog.FileName = $"Receta_Cita_{c.IdCita}_{c.NombrePaciente.Replace(" ", "_")}.txt";

				// Intentamos guardar la receta en un archivo de texto y manejamos cualquier excepción que pueda ocurrir
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						// Estructura formal del documento
						string contenidoReceta =
	"=====================================================\t\n" +
	"            SISTEMA DE GESTIÓN DE CITAS MÉDICAS\r\n" +
	"                     RECETA MÉDICA\r\n" +
	"=====================================================\t\n" +
	"Cita N°: " + c.IdCita + "\t\n" +
	"Fecha de Emisión: " + c.FechaHora.ToString("dd/MM/yyyy HH:mm") + "\t\n" +
	"Especialidad: " + c.NombreEspecialidad + "\t\n\t\n" +
	"DATOS DEL PACIENTE:\t\n" +
	"-----------------------------------------------------\t\n" +
	"Nombre: " + c.NombrePaciente + "\t\n\t\n" +
	"DATOS DEL MÉDICO TRATANTE:\t\n" +
	"-----------------------------------------------------\t\n" +
	"Nombre: " + c.NombreMedico + "\t\n\t\n" +
	"INDICACIONES MÉDICAS Y TRATAMIENTO:\t\n" +
	"-----------------------------------------------------\t\n" +
	c.DescripcionReceta + "\t\n\t\n" +
	"=====================================================\t\n" +
	"   ¡Gracias por confiar en nuestra atención médica!\t\n" +
	"=====================================================";

						// Guardamos el archivo TXT en el disco
						File.WriteAllText(saveFileDialog.FileName, contenidoReceta);

						MessageBox.Show("¡La receta se ha exportado en TXT!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					// Capturamos cualquier excepción que ocurra al generar el archivo de la receta y mostramos un mensaje de error
					catch (Exception ex)
					{
						MessageBox.Show("Error al generar el archivo de la receta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		// Evento que se dispara al hacer clic en el botón "Volver"
		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

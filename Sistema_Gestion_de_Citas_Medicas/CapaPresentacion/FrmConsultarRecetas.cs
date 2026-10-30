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
		private List<Cita> listaCitasGlobal = new List<Cita>();

		public FrmConsultarRecetas()
		{
			InitializeComponent();
		}

		private void FrmConsultarRecetas_Load(object sender, EventArgs e)
		{
			CargarCitasConReceta();
			// Configuración de campos en modo lectura
			txtIdCita.ReadOnly = true;
			txtPaciente.ReadOnly = true;
			dtpFecha.Enabled = true;
			txtDetalle.ReadOnly = true;
		}
		private void CargarCitasConReceta()
		{
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
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar recetas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FiltrarCitasPorFecha()
		{
			if (listaCitasGlobal == null) return;

			DateTime fechaSeleccionada = dtpFecha.Value.Date;

			var citasFiltradas = listaCitasGlobal
				.Where(c => c.FechaHora.Date == fechaSeleccionada)
				.ToList();

			dgvCitas.DataSource = citasFiltradas;
		}

		private void dtpFecha_ValueChanged(object sender, EventArgs e)
		{
			FiltrarCitasPorFecha();
		}

		private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				Cita c = dgvCitas.Rows[e.RowIndex].DataBoundItem as Cita;

				if (c != null)
				{
					txtIdCita.Text = c.IdCita.ToString();
					txtPaciente.Text = c.NombrePaciente;
					txtDetalle.Text = string.IsNullOrEmpty(c.DescripcionReceta)
						? "Esta cita aún no tiene receta emitida."
						: c.DescripcionReceta;
				}
			}
		}

		private void btnImprimirReceta_Click(object sender, EventArgs e)
		{
			if (dgvCitas.CurrentRow == null)
			{
				MessageBox.Show("Por favor, seleccione una cita de la lista para exportar la receta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Cita c = dgvCitas.CurrentRow.DataBoundItem as Cita;

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
					catch (Exception ex)
					{
						MessageBox.Show("Error al generar el archivo de la receta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}

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

		public FrmEmitirRecetas()
		{
			InitializeComponent();
		}

		private void FrmEmitirRecetas_Load(object sender, EventArgs e)
		{
			CargarTodasLasCitas();
			txtIdCita.Enabled = false;
			txtPaciente.Enabled = false;
		}

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
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar citas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
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
					txtDetalle.Text = c.DescripcionReceta;

					// Ojo: Ya NO cambiamos dtpFecha.Value aquí para evitar que al hacer clic 
					// la tabla se vuelva a filtrar sola y se pierda la selección.
				}
			}
		}

		private void btnEmitirReceta_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtIdCita.Text))
				{
					MessageBox.Show("Por favor, seleccione una cita de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (string.IsNullOrWhiteSpace(txtDetalle.Text))
				{
					MessageBox.Show("Debe ingresar las indicaciones o detalles de la receta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Receta nuevaReceta = new Receta
				{
					IdCita = Convert.ToInt32(txtIdCita.Text),
					Descripcion = txtDetalle.Text.Trim()
				};

				RecetaDAL dal = new RecetaDAL();
				if (dal.EmitirReceta(nuevaReceta))
				{
					MessageBox.Show("¡Receta emitida con éxito y cita marcada como atendida!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarTodasLasCitas();
					LimpiarCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
		}

		private void LimpiarCampos()
		{
			txtIdCita.Clear();
			txtPaciente.Clear();
			txtDetalle.Clear();
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void grpBuscarCita_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
	public partial class FrmConsultarCitas : Form
	{
		// Constructor
		public FrmConsultarCitas()
		{
			InitializeComponent();
		}

		// Variable para evitar que el evento ValueChanged del DateTimePicker se dispare al cargar el formulario
		private bool cargandoInicial = true;
        private void FrmConsultarCitas_Load(object sender, EventArgs e)
		{
			// Mostrar el nombre del usuario logueado en el campo/etiqueta de Paciente o Médico
			txtPacienteMedico.Text = SesionUsuario.Username;
            txtPacienteMedico.Enabled = false;
			// Mostrar u ocultar el botón "Atender Cita" según el rol del usuario
			if (SesionUsuario.Rol == "Medico")
            {
                btnAtenderCita.Visible = true;
            }
            else
            {
                btnAtenderCita.Visible = false;
            }
			// Mostrar u ocultar el botón "Cancelar Cita" según el rol del usuario
			cargandoInicial = false;
            CargarHistorialCitas(); // Carga todo el historial al abrir la pantalla
        }

		// Método para cargar el historial de citas según el rol del usuario y la fecha seleccionada
		private void CargarHistorialCitas()
		{
			// Evitamos que se ejecute al cargar el formulario por primera vez
			try
			{
				CitaDAL citaDal = new CitaDAL();
				List<Cita> listaCitas = new List<Cita>();

				string rol = SesionUsuario.Rol;

				// Obtener la lista base según el rol del usuario en sesión
				if (rol == "Paciente")
				{
					int idPaciente = SesionUsuario.IdPaciente ?? 0;
					listaCitas = citaDal.ListarCitas(idPaciente: idPaciente);
				}
				else if (rol == "Medico")
				{
					int idMedico = SesionUsuario.IdMedico ?? 0;
					listaCitas = citaDal.ListarCitas(idMedico: idMedico);
				}
				else
				{
					listaCitas = citaDal.ListarCitas();
				}

				// Filtrar la lista en memoria por la fecha seleccionada en el DateTimePicker (solo la parte del día, mes y año)
				DateTime fechaFiltro = dtpFecha.Value.Date;
				var listaFiltrada = listaCitas.Where(c => c.FechaHora.Date == fechaFiltro).ToList();

				// Asignar la lista filtrada al DataGridView
				dgvCitas.DataSource = listaFiltrada;

				// Ocultar columnas internas innecesarias
				if (dgvCitas.Columns["IdCita"] != null) dgvCitas.Columns["IdCita"].Visible = false;
				if (dgvCitas.Columns["IdPaciente"] != null) dgvCitas.Columns["IdPaciente"].Visible = false;
				if (dgvCitas.Columns["IdMedico"] != null) dgvCitas.Columns["IdMedico"].Visible = false;
			}
			// Manejo de excepciones para capturar errores al filtrar las citas por fecha
			catch (Exception ex)
			{
				MessageBox.Show("Error al filtrar las citas por fecha: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al cambiar la fecha en el DateTimePicker
		private void dtpFecha_ValueChanged(object sender, EventArgs e)
		{
			CargarHistorialCitas();
		}

		// Evento que se dispara al hacer clic en el botón "Atender Cita"
		private void btnAtenderCita_Click(object sender, EventArgs e)
		{
			try
			{
				// Verificar que el usuario haya seleccionado una fila en el DataGridView
				if (dgvCitas.SelectedRows.Count > 0)
				{
					// Obtener el ID y el estado actual de la cita seleccionada
					int idCita = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["IdCita"].Value);
					string estadoActual = dgvCitas.SelectedRows[0].Cells["Estado"].Value.ToString();

					// Validar que la cita no esté ya atendida o cancelada antes de permitir marcarla como atendida
					if (estadoActual == "Atendida")
					{
						MessageBox.Show("Esta cita ya fue marcada como atendida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

					if (estadoActual == "Cancelada")
					{
						MessageBox.Show("No se puede atender una cita que ha sido cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					DialogResult confirmacion = MessageBox.Show("¿Deseas marcar esta cita como Atendida?", "Confirmar atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (confirmacion == DialogResult.Yes)
					{
						CitaDAL citaDal = new CitaDAL();
						// Usamos el método existente para cambiar el estado a "Atendida"
						bool resultado = citaDal.CambiarEstadoCita(idCita, "Atendida");

						if (resultado)
						{
							MessageBox.Show("Cita marcada como atendida exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
							CargarHistorialCitas(); // Refrescar la tabla para ver el cambio de estado
						}
					}
				}
				// Manejo de excepciones para capturar errores al cambiar el estado de la cita
				else
				{
					MessageBox.Show("Por favor, selecciona una cita de la lista.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al actualizar el estado de la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al hacer clic en el botón "Cancelar Cita"
		private void btnCancelarCita_Click(object sender, EventArgs e)
		{
			try
			{
				// Verificar que el usuario haya seleccionado una fila en el DataGridView
				if (dgvCitas.SelectedRows.Count > 0)
				{
					// Obtener el ID de la cita seleccionada
					int idCita = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["IdCita"].Value);
					string estadoActual = dgvCitas.SelectedRows[0].Cells["Estado"].Value.ToString();

					// Validar que la cita no esté ya cancelada antes de permitir cancelarla
					if (estadoActual == "Cancelada")
					{
						MessageBox.Show("Esta cita ya se encuentra cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

					DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas cancelar esta cita?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					// Si el usuario confirma, se procede a cambiar el estado de la cita a "Cancelada"
					if (confirmacion == DialogResult.Yes)
					{
						CitaDAL citaDal = new CitaDAL();
						bool resultado = citaDal.CambiarEstadoCita(idCita, "Cancelada");

						if (resultado)
						{
							MessageBox.Show("Cita cancelada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
							CargarHistorialCitas(); // Refrescar la tabla
						}
					}
				}
				// Manejo de excepciones para capturar errores al cancelar la cita
				else
				{
					MessageBox.Show("Por favor, selecciona una cita de la lista.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cancelar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al hacer clic en el botón "Volver"
		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close(); 
		}


	}
}

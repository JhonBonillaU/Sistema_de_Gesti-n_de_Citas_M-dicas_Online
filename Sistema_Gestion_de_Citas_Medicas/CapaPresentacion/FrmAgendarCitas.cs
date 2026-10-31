using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Sistema_Gestion_de_Citas_Medicas.CapaDatos;
using Sistema_Gestion_de_Citas_Medicas.CapaLogica;

namespace Sistema_Gestion_de_Citas_Medicas
{
	public partial class FrmAgendarCitas : Form
	{
		// Constructor del formulario
		public FrmAgendarCitas()
		{
			InitializeComponent();
		}

		// Evento Load del formulario
		private void FrmAgendarCitas_Load(object sender, EventArgs e)
		{
			CargarEspecialidades(); // Cargar las especialidades al iniciar el formulario
			CargarHorarios(); // Cargar los horarios al iniciar el formulario

			// Mostrar el nombre del usuario logueado en el campo/etiqueta de Paciente
			txtPaciente.Text = SesionUsuario.Username;
			txtPaciente.Enabled = false; // Bloqueado para que el usuario no edite

			// Estado predeterminado para una nueva cita
			txtEstado.Text = "Pendiente";
			txtEstado.Enabled = false;
        }

		// Método para cargar las especialidades desde la base de datos
		private void CargarEspecialidades()
		{
			try
			{
				using (SqlConnection con = Conexion.ObtenerConexion())
				{
					// Consulta SQL para obtener todas las especialidades
					string query = "SELECT ID_Especialidad, NombreEspecialidad FROM Especialidad";
					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						using (SqlDataAdapter da = new SqlDataAdapter(cmd))
						{
							DataTable dt = new DataTable();
							da.Fill(dt);
							// Asignamos el DataTable como fuente de datos del ComboBox de especialidades
							cmbEspecialidad.DataSource = dt;
							cmbEspecialidad.DisplayMember = "NombreEspecialidad";
							cmbEspecialidad.ValueMember = "ID_Especialidad";
							cmbEspecialidad.SelectedIndex = -1; // Sin selección inicial
						}
					}
				}
			}
			// Capturamos cualquier excepción que ocurra al cargar las especialidades y mostramos un mensaje de error
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar especialidades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Método para cargar los horarios disponibles en el ComboBox
		private void CargarHorarios()
		{
			cmbHora.Items.Clear();
			cmbHora.Items.Add("08:00 AM");
			cmbHora.Items.Add("09:00 AM");
			cmbHora.Items.Add("10:00 AM");
			cmbHora.Items.Add("11:00 AM");
			cmbHora.Items.Add("01:00 PM");
			cmbHora.Items.Add("02:00 PM");
			cmbHora.Items.Add("03:00 PM");
			cmbHora.Items.Add("04:00 PM");
		}

		// Evento que se dispara cuando se selecciona una especialidad en el ComboBox
		private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Validamos que haya una especialidad seleccionada antes de intentar cargar los médicos
			if (cmbEspecialidad.SelectedIndex != -1 && cmbEspecialidad.SelectedValue is int idEspecialidad)
			{
				CargarMedicosPorEspecialidad(idEspecialidad);
			}
		}

		// Método para cargar los médicos asociados a la especialidad seleccionada
		private void CargarMedicosPorEspecialidad(int idEspecialidad)
		{
			// Intentamos cargar los médicos de la especialidad seleccionada desde la base de datos
			try
			{
				using (SqlConnection con = Conexion.ObtenerConexion())
				{
					// Consultamos los médicos que pertenecen a esa especialidad usando la tabla Medico
					string query = "SELECT ID_Medico, (Nombre + ' ' + Apellido) AS NombreCompleto FROM Medico WHERE ID_Especialidad = @ID_Especialidad";
					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.AddWithValue("@ID_Especialidad", idEspecialidad);
						using (SqlDataAdapter da = new SqlDataAdapter(cmd))
						{
							DataTable dt = new DataTable();
							da.Fill(dt);

							cmbMedico.DataSource = dt;
							cmbMedico.DisplayMember = "NombreCompleto";
							cmbMedico.ValueMember = "ID_Medico";
							cmbMedico.SelectedIndex = -1;
						}
					}
				}
			}
			// Capturamos cualquier excepción que ocurra al cargar los médicos y mostramos un mensaje de error
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar médicos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Evento que se dispara al hacer clic en el botón "Agendar Cita"
		private void btnAgendarCita_Click(object sender, EventArgs e)
		{
			try
			{
				// alidaciones básicas de controles vacíos
				if (cmbEspecialidad.SelectedIndex == -1 || cmbMedico.SelectedIndex == -1 || string.IsNullOrEmpty(cmbHora.Text))
				{
					MessageBox.Show("Por favor, selecciona una especialidad, un médico y un horario.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Extraer IDs de la sesión y controles
				int idPaciente = SesionUsuario.IdPaciente ?? 0;
				int idMedico = Convert.ToInt32(cmbMedico.SelectedValue);

				// Solución para leer "08:00 AM" o formato de 12/24 horas sin errores
				DateTime fechaSeleccionada = dtpFecha.Value.Date;
				DateTime horaParseada = DateTime.Parse(cmbHora.Text); // Lee perfectamente cadenas con AM/PM

				// Unimos la fecha seleccionada con la hora y minutos extraídos
				DateTime fechaHoraCita = fechaSeleccionada.AddHours(horaParseada.Hour).AddMinutes(horaParseada.Minute);

				// Crear instancia de Cita
				Cita nuevaCita = new Cita
				{
					IdPaciente = idPaciente,
					IdMedico = idMedico,
					FechaHora = fechaHoraCita
				};

				// Enviar a la capa de datos
				CitaDAL citaDal = new CitaDAL();
				bool resultado = citaDal.AgendarCita(nuevaCita);

				if (resultado)
				{
					MessageBox.Show("¡Cita agendada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

					// Limpiar selecciones posteriores
					cmbEspecialidad.SelectedIndex = -1;
					cmbMedico.DataSource = null;
					cmbHora.SelectedIndex = -1;
				}
			}
			catch (Exception ex)
			{
				// Atrapa la excepción si el médico ya está ocupado en ese horario
				MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// Evento que se dispara al hacer clic en el botón "Limpiar"
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			cmbEspecialidad.SelectedIndex = -1;
			cmbMedico.DataSource = null; // Limpia los médicos asociados
			cmbHora.SelectedIndex = -1;
			dtpFecha.Value = DateTime.Today;
		}

		// Evento que se dispara al hacer clic en el botón "Volver"
		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

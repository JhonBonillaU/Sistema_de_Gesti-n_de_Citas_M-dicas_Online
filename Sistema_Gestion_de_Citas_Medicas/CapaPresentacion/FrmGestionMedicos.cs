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
        public FrmGestionMedicos()
        {
            InitializeComponent();
        }

        private void FrmGestionMedico_Load(object sender, EventArgs e)
        {
			CargarEspecialidadesComboBox();
			CargarGridMedicos();
			txtIdMedico.Enabled = false;
		}

		private void CargarEspecialidadesComboBox()
		{
			try
			{
				EspecialidadDAL espDal = new EspecialidadDAL();
				cmbEspecialidad.DataSource = espDal.ListarEspecialidades();
				cmbEspecialidad.DisplayMember = "NombreEspecialidad"; // Lo que ve el usuario
				cmbEspecialidad.ValueMember = "IdEspecialidad";       // El ID interno
				cmbEspecialidad.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar especialidades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CargarGridMedicos()
		{
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

				if (dgvMedicos.Columns["IdMedico"] != null)
					dgvMedicos.Columns["IdMedico"].HeaderText = "ID Médico";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar médicos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

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

		private void btnGuardarMedico_Click(object sender, EventArgs e)
		{
			try
			{
				if (cmbEspecialidad.SelectedIndex == -1)
				{
					MessageBox.Show("Por favor, seleccione una especialidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Medico nuevoMedico = new Medico
				{
					Nombre = txtNombre.Text.Trim(),
					Apellido = txtApellido.Text.Trim(),
					Telefono = txtTelefono.Text.Trim(),
					Correo = txtCorreo.Text.Trim(),
					IdEspecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue)
				};

				string username = txtCorreo.Text.Trim();
				string password = "123"; // Contraseña temporal por defecto

				MedicoDAL dal = new MedicoDAL();
				if (dal.RegistrarMedico(nuevoMedico, username, password))
				{
					MessageBox.Show("Médico registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridMedicos();
					LimpiarCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnModificarMedico_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtIdMedico.Text))
				{
					MessageBox.Show("Seleccione un médico de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Medico medicoMod = new Medico
				{
					IdMedico = Convert.ToInt32(txtIdMedico.Text),
					Nombre = txtNombre.Text.Trim(),
					Apellido = txtApellido.Text.Trim(),
					Telefono = txtTelefono.Text.Trim(),
					Correo = txtCorreo.Text.Trim(),
					IdEspecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue)
				};

				MedicoDAL dal = new MedicoDAL();
				if (dal.ActualizarMedico(medicoMod))
				{
					MessageBox.Show("Datos del médico actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridMedicos();
					LimpiarCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEliminarMedico_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtIdMedico.Text))
				{
					MessageBox.Show("Seleccione un médico de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este médico y su cuenta de acceso?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (resultado == DialogResult.Yes)
				{
					int idMedico = Convert.ToInt32(txtIdMedico.Text);
					MedicoDAL dal = new MedicoDAL();

					if (dal.EliminarMedico(idMedico))
					{
						MessageBox.Show("Médico eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						CargarGridMedicos();
						LimpiarCampos();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLimpiarEspecialidad_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
		}

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

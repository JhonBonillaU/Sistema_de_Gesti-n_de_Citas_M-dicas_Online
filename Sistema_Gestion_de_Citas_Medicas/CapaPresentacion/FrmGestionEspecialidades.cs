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
        public FrmGestionEspecialidades()
        {
            InitializeComponent();
        }

		private void FrmGestionEspecialidades_Load(object sender, EventArgs e)
		{
			CargarGridEspecialidades();
			txtIdEspecialidad.Enabled = false;
		}

		private void CargarGridEspecialidades()
		{
			try
			{
				EspecialidadDAL dal = new EspecialidadDAL();
				dgvEspecialidades.DataSource = dal.ListarEspecialidades();

				if (dgvEspecialidades.Columns["IdEspecialidad"] != null)
					dgvEspecialidades.Columns["IdEspecialidad"].HeaderText = "ID";

				if (dgvEspecialidades.Columns["NombreEspecialidad"] != null)
					dgvEspecialidades.Columns["NombreEspecialidad"].HeaderText = "Nombre de Especialidad";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar especialidades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvEspecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				Especialidad esp = dgvEspecialidades.Rows[e.RowIndex].DataBoundItem as Especialidad;

				if (esp != null)
				{
					txtIdEspecialidad.Text = esp.IdEspecialidad.ToString();
					txtNombreEspecialidad.Text = esp.NombreEspecialidad;
				}
			}
		}

		private void btnGuardarEspecialidad_Click(object sender, EventArgs e)
		{
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
			catch (Exception ex)
			{
				MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnModificarEspecialidad_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtIdEspecialidad.Text))
				{
					MessageBox.Show("Seleccione una especialidad de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Especialidad espMod = new Especialidad
				{
					IdEspecialidad = Convert.ToInt32(txtIdEspecialidad.Text),
					NombreEspecialidad = txtNombreEspecialidad.Text.Trim()
				};

				EspecialidadDAL dal = new EspecialidadDAL();
				if (dal.ActualizarEspecialidad(espMod))
				{
					MessageBox.Show("Especialidad actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridEspecialidades();
					LimpiarCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtIdEspecialidad.Text))
				{
					MessageBox.Show("Seleccione una especialidad de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta especialidad?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (resultado == DialogResult.Yes)
				{
					int idEspecialidad = Convert.ToInt32(txtIdEspecialidad.Text);
					EspecialidadDAL dal = new EspecialidadDAL();

					if (dal.EliminarEspecialidad(idEspecialidad))
					{
						MessageBox.Show("Especialidad eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						CargarGridEspecialidades();
						LimpiarCampos();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar (es posible que esté asignada a un médico): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLimpiarEspecialidad_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
		}

		private void LimpiarCampos()
		{
			txtIdEspecialidad.Clear();
			txtNombreEspecialidad.Clear();
		}
	}
}

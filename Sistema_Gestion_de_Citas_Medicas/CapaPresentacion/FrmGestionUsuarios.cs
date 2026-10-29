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
    public partial class FrmGestionUsuarios : Form
    {
        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
			CargarGridUsuarios();
			txtIdUsuario.Enabled = false;

	        // Llenar el ComboBox de roles si tienes un ComboBox para el rol
			cmbRol.Items.Add("Administrador");
			cmbRol.Items.Add("Medico");
			cmbRol.Items.Add("Paciente");
		}

		private void CargarGridUsuarios()
		{
			try
			{
				UsuarioDAL dal = new UsuarioDAL();
				dgvUsuarios.DataSource = dal.ListarUsuarios();

				if (dgvUsuarios.Columns["IdUsuario"] != null)
					dgvUsuarios.Columns["IdUsuario"].HeaderText = "ID";
				if (dgvUsuarios.Columns["Username"] != null)
					dgvUsuarios.Columns["Username"].HeaderText = "Nombre de Usuario";
				if (dgvUsuarios.Columns["Password"] != null)
					dgvUsuarios.Columns["Password"].HeaderText = "Contraseña";
				if (dgvUsuarios.Columns["Rol"] != null)
					dgvUsuarios.Columns["Rol"].HeaderText = "Rol";

				// Ocultar columnas heredadas o innecesarias si aparecen
				if (dgvUsuarios.Columns["ID_Paciente"] != null) dgvUsuarios.Columns["ID_Paciente"].Visible = false;
				if (dgvUsuarios.Columns["ID_Medico"] != null) dgvUsuarios.Columns["ID_Medico"].Visible = false;
				if (dgvUsuarios.Columns["Nombre"] != null) dgvUsuarios.Columns["Nombre"].Visible = false;
				if (dgvUsuarios.Columns["Apellido"] != null) dgvUsuarios.Columns["Apellido"].Visible = false;
				if (dgvUsuarios.Columns["Telefono"] != null) dgvUsuarios.Columns["Telefono"].Visible = false;
				if (dgvUsuarios.Columns["Correo"] != null) dgvUsuarios.Columns["Correo"].Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				Usuario u = dgvUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;

				if (u != null)
				{
					txtIdUsuario.Text = u.IdUsuario.ToString();
					txtUsername.Text = u.Username;
					txtPassword.Text = u.Password;
					cmbRol.SelectedItem = u.Rol;
				}
			}
		}

		private void btnModificarUsuario_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtIdUsuario.Text))
				{
					MessageBox.Show("Seleccione un usuario de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Usuario uMod = new Usuario
				{
					IdUsuario = Convert.ToInt32(txtIdUsuario.Text),
					Username = txtUsername.Text.Trim(),
					Password = txtPassword.Text.Trim(),
					Rol = cmbRol.SelectedItem?.ToString()
				};

				UsuarioDAL dal = new UsuarioDAL();
				if (dal.ActualizarUsuario(uMod))
				{
					MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarGridUsuarios();
					LimpiarCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEliminarUsuario_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtIdUsuario.Text))
				{
					MessageBox.Show("Seleccione un usuario de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (resultado == DialogResult.Yes)
				{
					int idUsuario = Convert.ToInt32(txtIdUsuario.Text);
					UsuarioDAL dal = new UsuarioDAL();

					if (dal.EliminarUsuario(idUsuario))
					{
						MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						CargarGridUsuarios();
						LimpiarCampos();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLimpiarUsuario_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
		}

		private void LimpiarCampos()
		{
			txtIdUsuario.Clear();
			txtUsername.Clear();
			txtPassword.Clear();
			cmbRol.SelectedIndex = -1;
		}
	}
}

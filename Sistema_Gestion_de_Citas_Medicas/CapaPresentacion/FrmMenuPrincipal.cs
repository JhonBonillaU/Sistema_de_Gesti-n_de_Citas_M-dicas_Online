using Sistema_Gestion_de_Citas_Medicas.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_de_Citas_Medicas
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        public void AbrirFormularioEnPanel(Form formularioHijo)
        {

            panelContenedor.Visible = true;

            // 1. Si ya hay un formulario abierto en el panel, lo removemos
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            // 2. Configuramos el formulario hijo para que actúe como un control interno
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // 3. Lo agregamos al panel contenedor y lo mostramos
            this.panelContenedor.Controls.Add(formularioHijo);
            this.panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            AplicarPermisos();

            AbrirFormularioEnPanel(new FrmResumen());
        }

        private void AplicarPermisos()
        {
            string rol = SesionUsuario.Rol;

            if (rol == "Admin")
            {
                btnPacientes.Visible = true;
                btnMedicos.Visible = true;
                btnUsuarios.Visible = true;
                btnEspecialidad.Visible = true;
                btnAgendarCitas.Visible = true;
                btnConsultarCitas.Visible = true;
                btnEmitirRecetas.Visible = true;
                btnConsultarRecetas.Visible = true;
                btnResumen.Visible = true;
				btnSalir.Visible = true;
			}
            else if (rol == "Medico")
            {
                btnEmitirRecetas.Visible = true;
                btnConsultarRecetas.Visible = true;
                btnPacientes.Visible = true;
                btnAgendarCitas.Visible = true;
                btnConsultarCitas.Visible = true;// Ver historial de pacientes
                btnMedicos.Visible = false;      // No puede administrar médicos
                btnUsuarios.Visible = false;
                btnEspecialidad.Visible = false;
                btnResumen.Visible = false;
				btnSalir.Visible = true;
			}
            else if (rol == "Paciente")
            {
                btnConsultarCitas.Visible = true;
                btnAgendarCitas.Visible = true;
                btnConsultarRecetas.Visible = true;
                btnPacientes.Visible = false;     // No administra otros pacientes
                btnMedicos.Visible = false;
                btnUsuarios.Visible = false;
                btnEspecialidad.Visible = false;
                btnEmitirRecetas.Visible = false;
                btnResumen.Visible = false;
                btnSalir.Visible = true;
			}
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            // Abre el formulario de gestión de pacientes dentro del panel
            AbrirFormularioEnPanel(new FrmGestionPacientes());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmGestionEspecialidades());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmGestionUsuarios());
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmGestionMedicos());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmAgendarCitas());
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmConsultarRecetas());
        }

        private void btnEmitirRecetas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmEmitirRecetas());
        }

        private void btnConsultarCitas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmConsultarCitas());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmResumen());
        }

		private void btnSalir_Click(object sender, EventArgs e)
		{
            Environment.Exit(0);
		}
	}
}

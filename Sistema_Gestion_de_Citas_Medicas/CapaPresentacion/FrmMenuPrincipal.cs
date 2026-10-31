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

            formularioHijo.Location = new Point(10, 10);

            // 3. Lo agregamos al panel contenedor y lo mostramos
            this.panelContenedor.Controls.Add(formularioHijo);
            this.panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            AplicarPermisos();

            string rol = SesionUsuario.Rol;

            // Dependiendo del rol, abrimos su pantalla inicial correspondiente por defecto:
            if (rol == "Administrador")
            {
                AbrirFormularioEnPanel(new FrmResumen());
            }
            else if (rol == "Medico")
            {
                AbrirFormularioEnPanel(new FrmConsultarCitas()); 
            }
            else if (rol == "Paciente")
            {
                AbrirFormularioEnPanel(new FrmConsultarCitas());
            }
        }

        private void AplicarPermisos()
        {
            string rol = SesionUsuario.Rol;

            if (rol == "Administrador")
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
                btnConsultarRecetas.Visible = false;
                btnPacientes.Visible = true;
                btnAgendarCitas.Visible = false;
                btnConsultarCitas.Visible = true;// Ver historial de pacientes
                btnMedicos.Visible = true;      // No puede administrar médicos
                btnUsuarios.Visible = false;
                btnEspecialidad.Visible = true;
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

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            // Abre el formulario de gestión de pacientes dentro del panel
            AbrirFormularioEnPanel(new FrmGestionPacientes());
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

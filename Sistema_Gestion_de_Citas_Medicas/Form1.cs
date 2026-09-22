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

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            string rol = SesionUsuario.Rol;

            if (rol == "Admin")
            {
                btnPacientes.Visible = true;
                btnMedicos.Visible = true;
                btnUsuarios.Visible = true;
            }
            else if (rol == "Medico")
            {
                btnPacientes.Visible = true;      // Ver historial de pacientes
                btnMedicos.Visible = false;      // No puede administrar médicos
                btnUsuarios.Visible = false;
            }
            else if (rol == "Paciente")
            {
                btnPacientes.Visible = false;     // No administra otros pacientes
                btnMedicos.Visible = false;
                btnUsuarios.Visible = false;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}

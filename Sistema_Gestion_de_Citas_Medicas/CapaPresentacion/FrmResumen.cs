using Sistema_Gestion_de_Citas_Medicas.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_de_Citas_Medicas.CapaPresentacion
{
    public partial class FrmResumen : Form
    {
        public FrmResumen()
        {
            InitializeComponent();
        }

        private void FrmResumen_Load(object sender, EventArgs e)
        {
            EstadisticasDelSistema();   
        }

        private void EstadisticasDelSistema()
        {
            try
            {
                // Si ya existen las clases y métodos de la capa lógica, los usamos:
                /*
                PacienteBLL pacienteBll = new PacienteBLL();
                CitaBLL citaBll = new CitaBLL();
                RecetaBLL recetaBll = new RecetaBLL();

                lblTotalPacientes.Text = pacienteBll.ObtenerConteoTotal().ToString();
                lblCitasHoy.Text = citaBll.ObtenerConteoCitasHoy().ToString();
                lblCitasPendientes.Text = citaBll.ObtenerConteoCitasPendientes().ToString();
                lblRecetasEmitidas.Text = recetaBll.ObtenerConteoRecetas().ToString();
                */

                //  Valores estáticos de prueba (Elimina los errores en rojo por completo)
                // Asegúrate de cambiar "lblTotalPacientes" por el nombre real de tu Label si es diferente.
                lblTotalPacientes.Text = "24";
                lblCitas.Text = "5";
                lblMedicos.Text = "8";
                lblRecetasEmitidas.Text = "12";
            }
            catch (Exception ex)
            {
                // Si algo falla, el sistema no se cae, solo muestra el error en consola o un aviso suave
                Console.WriteLine("Error al cargar estadísticas: " + ex.Message);
            }
        }

        private void btnDetallesRegistro_Click(object sender, EventArgs e)
        {
            // Buscamos el formulario contenedor (el Menú Principal)
            FrmMenuPrincipal menu = (FrmMenuPrincipal)this.TopLevelControl;
            if (menu != null)
            {
                // Llamamos al método que abre la gestión de pacientes en el panel central
                menu.AbrirFormularioEnPanel(new FrmGestionPacientes());
            }
        }

        private void btnDetallesCitas_Click(object sender, EventArgs e)
        {
            
            FrmMenuPrincipal menu = (FrmMenuPrincipal)this.TopLevelControl;
            if (menu != null)
            {
                
                menu.AbrirFormularioEnPanel(new FrmConsultarCitas());
            }
        }


        private void btnDetallesRecetas_Click(object sender, EventArgs e)
        {
            
            FrmMenuPrincipal menu = (FrmMenuPrincipal)this.TopLevelControl;
            if (menu != null)
            {

                menu.AbrirFormularioEnPanel(new FrmConsultarRecetas());
            }
        }

        private void btnDetallesMedicos_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = (FrmMenuPrincipal)this.TopLevelControl;
            if (menu != null)
            {
                menu.AbrirFormularioEnPanel(new FrmGestionMedicos());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


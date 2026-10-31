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
using System.Windows.Forms.DataVisualization.Charting;



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
            if (SesionUsuario.Rol != "Administrador")
            {
                MessageBox.Show("No tienes permisos para ver este módulo de resumen.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // Cierra la ventana automáticamente si es Paciente o Médico
                return;
            }
            CargarEstadisticasReales();
            ConfigurarYGenerarGrafico();
        }

        private void CargarEstadisticasReales()
        {
            try
            {
                CitaDAL datosDal = new CitaDAL();

                int totalPacientes = datosDal.ObtenerConteoPacientes();
                int totalCitas = datosDal.ObtenerConteoCitasTotales();
                int totalMedicos = datosDal.ObtenerConteoMedicos();
                int totalRecetas = datosDal.ObtenerConteoRecetas();

                lblTotalPacientes.Text = totalPacientes.ToString();
                lblCitas.Text = totalCitas.ToString();
                lblMedicos.Text = totalMedicos.ToString();
                lblRecetasEmitidas.Text = totalRecetas.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las estadísticas: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigurarYGenerarGrafico()
        {
            try
            {
                CitaDAL datosDal = new CitaDAL();

                int totalPacientes = datosDal.ObtenerConteoPacientes();
                int totalCitas = datosDal.ObtenerConteoCitasTotales();
                int totalMedicos = datosDal.ObtenerConteoMedicos();
                int totalRecetas = datosDal.ObtenerConteoRecetas();

                chartResumen.Series.Clear();
                chartResumen.ChartAreas.Clear();

                // Crear área del gráfico
                ChartArea area = new ChartArea("AreaPrincipal");
                chartResumen.ChartAreas.Add(area);

                // Crear la serie de datos 
                Series serie = new Series("Estadísticas");
                serie.ChartType = SeriesChartType.Column;
                serie.IsValueShownAsLabel = true;

                // Añadir puntos
                serie.Points.AddXY("Pacientes", totalPacientes);
                serie.Points.AddXY("Citas", totalCitas);
                serie.Points.AddXY("Médicos", totalMedicos);
                serie.Points.AddXY("Recetas", totalRecetas);

                // Asignar colores intermedios
                serie.Points[0].Color = Color.FromArgb(41, 112, 190);
                serie.Points[1].Color = Color.FromArgb(0, 52, 99);
                serie.Points[2].Color = Color.FromArgb(41, 112, 190);
                serie.Points[3].Color = Color.FromArgb(0, 52, 99);

                chartResumen.Series.Add(serie);

                // Título del gráfico
                chartResumen.Titles.Clear();
                chartResumen.Titles.Add("Distribución General del Sistema");

                
                chartResumen.Invalidate();
                chartResumen.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en gráfico: " + ex.Message, "Error Gráfico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDetallesRegistro_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = (FrmMenuPrincipal)this.TopLevelControl;
            if (menu != null)
            {
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


namespace Sistema_Gestion_de_Citas_Medicas
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.herraminetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.btnPacientes = new System.Windows.Forms.Button();
			this.btnMedicos = new System.Windows.Forms.Button();
			this.btnAgendarCitas = new System.Windows.Forms.Button();
			this.btnUsuarios = new System.Windows.Forms.Button();
			this.btnEspecialidad = new System.Windows.Forms.Button();
			this.btnEmitirRecetas = new System.Windows.Forms.Button();
			this.btnConsultarRecetas = new System.Windows.Forms.Button();
			this.btnConsultarCitas = new System.Windows.Forms.Button();
			this.btnResumen = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.herraminetasToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1756, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// ediciónToolStripMenuItem
			// 
			this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
			this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
			this.ediciónToolStripMenuItem.Text = "Edición";
			// 
			// herraminetasToolStripMenuItem
			// 
			this.herraminetasToolStripMenuItem.Name = "herraminetasToolStripMenuItem";
			this.herraminetasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
			this.herraminetasToolStripMenuItem.Text = "Herraminetas";
			// 
			// baseDeDatosToolStripMenuItem
			// 
			this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
			this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
			this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(134, 80);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(151, 23);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(637, 42);
			this.lblTitulo.TabIndex = 3;
			this.lblTitulo.Text = "Sistema de Gestión de Citas Médicas ";
			this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.panel2.Controls.Add(this.panel7);
			this.panel2.Controls.Add(this.lblTitulo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1756, 90);
			this.panel2.TabIndex = 4;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.panel7.Controls.Add(this.panel8);
			this.panel7.Controls.Add(this.label12);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(1756, 90);
			this.panel7.TabIndex = 5;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.panel8.Controls.Add(this.label13);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(1756, 90);
			this.panel8.TabIndex = 6;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.label13.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(151, 23);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(637, 42);
			this.label13.TabIndex = 3;
			this.label13.Text = "Sistema de Gestión de Citas Médicas ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.label12.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(151, 23);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(637, 42);
			this.label12.TabIndex = 3;
			this.label12.Text = "Sistema de Gestión de Citas Médicas ";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 1033);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1756, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// panelContenedor
			// 
			this.panelContenedor.Location = new System.Drawing.Point(206, 117);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(1547, 923);
			this.panelContenedor.TabIndex = 13;
			this.panelContenedor.Visible = false;
			this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
			// 
			// btnPacientes
			// 
			this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPacientes.ForeColor = System.Drawing.Color.White;
			this.btnPacientes.Location = new System.Drawing.Point(12, 139);
			this.btnPacientes.Name = "btnPacientes";
			this.btnPacientes.Size = new System.Drawing.Size(175, 50);
			this.btnPacientes.TabIndex = 5;
			this.btnPacientes.Text = "Pacientes";
			this.btnPacientes.UseVisualStyleBackColor = true;
			this.btnPacientes.Click += new System.EventHandler(this.btnPaciente_Click);
			// 
			// btnMedicos
			// 
			this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMedicos.ForeColor = System.Drawing.Color.White;
			this.btnMedicos.Location = new System.Drawing.Point(12, 83);
			this.btnMedicos.Name = "btnMedicos";
			this.btnMedicos.Size = new System.Drawing.Size(175, 50);
			this.btnMedicos.TabIndex = 6;
			this.btnMedicos.Text = "Medicos";
			this.btnMedicos.UseVisualStyleBackColor = true;
			this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
			// 
			// btnAgendarCitas
			// 
			this.btnAgendarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgendarCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgendarCitas.ForeColor = System.Drawing.Color.White;
			this.btnAgendarCitas.Location = new System.Drawing.Point(12, 195);
			this.btnAgendarCitas.Name = "btnAgendarCitas";
			this.btnAgendarCitas.Size = new System.Drawing.Size(175, 70);
			this.btnAgendarCitas.TabIndex = 8;
			this.btnAgendarCitas.Text = "Agendar \r\nCitas";
			this.btnAgendarCitas.UseVisualStyleBackColor = true;
			this.btnAgendarCitas.Click += new System.EventHandler(this.btnCitas_Click);
			// 
			// btnUsuarios
			// 
			this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUsuarios.ForeColor = System.Drawing.Color.White;
			this.btnUsuarios.Location = new System.Drawing.Point(12, 499);
			this.btnUsuarios.Name = "btnUsuarios";
			this.btnUsuarios.Size = new System.Drawing.Size(175, 50);
			this.btnUsuarios.TabIndex = 6;
			this.btnUsuarios.Text = "Usuario";
			this.btnUsuarios.UseVisualStyleBackColor = true;
			this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
			// 
			// btnEspecialidad
			// 
			this.btnEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEspecialidad.ForeColor = System.Drawing.Color.White;
			this.btnEspecialidad.Location = new System.Drawing.Point(12, 27);
			this.btnEspecialidad.Name = "btnEspecialidad";
			this.btnEspecialidad.Size = new System.Drawing.Size(175, 50);
			this.btnEspecialidad.TabIndex = 9;
			this.btnEspecialidad.Text = "Especialidad";
			this.btnEspecialidad.UseVisualStyleBackColor = true;
			this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
			// 
			// btnEmitirRecetas
			// 
			this.btnEmitirRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmitirRecetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmitirRecetas.ForeColor = System.Drawing.Color.White;
			this.btnEmitirRecetas.Location = new System.Drawing.Point(12, 423);
			this.btnEmitirRecetas.Name = "btnEmitirRecetas";
			this.btnEmitirRecetas.Size = new System.Drawing.Size(175, 70);
			this.btnEmitirRecetas.TabIndex = 10;
			this.btnEmitirRecetas.Text = "Emitir \r\nRecetas";
			this.btnEmitirRecetas.UseVisualStyleBackColor = true;
			this.btnEmitirRecetas.Click += new System.EventHandler(this.btnEmitirRecetas_Click);
			// 
			// btnConsultarRecetas
			// 
			this.btnConsultarRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultarRecetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultarRecetas.ForeColor = System.Drawing.Color.White;
			this.btnConsultarRecetas.Location = new System.Drawing.Point(12, 347);
			this.btnConsultarRecetas.Name = "btnConsultarRecetas";
			this.btnConsultarRecetas.Size = new System.Drawing.Size(175, 70);
			this.btnConsultarRecetas.TabIndex = 7;
			this.btnConsultarRecetas.Text = "Consultar \r\nRecetas";
			this.btnConsultarRecetas.UseVisualStyleBackColor = true;
			this.btnConsultarRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
			// 
			// btnConsultarCitas
			// 
			this.btnConsultarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultarCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultarCitas.ForeColor = System.Drawing.Color.White;
			this.btnConsultarCitas.Location = new System.Drawing.Point(12, 271);
			this.btnConsultarCitas.Name = "btnConsultarCitas";
			this.btnConsultarCitas.Size = new System.Drawing.Size(175, 70);
			this.btnConsultarCitas.TabIndex = 11;
			this.btnConsultarCitas.Text = "Consultar \r\nCitas";
			this.btnConsultarCitas.UseVisualStyleBackColor = true;
			this.btnConsultarCitas.Click += new System.EventHandler(this.btnConsultarCitas_Click);
			// 
			// btnResumen
			// 
			this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResumen.ForeColor = System.Drawing.Color.White;
			this.btnResumen.Location = new System.Drawing.Point(12, 555);
			this.btnResumen.Name = "btnResumen";
			this.btnResumen.Size = new System.Drawing.Size(175, 50);
			this.btnResumen.TabIndex = 12;
			this.btnResumen.Text = "Resumen";
			this.btnResumen.UseVisualStyleBackColor = true;
			this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Brown;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Location = new System.Drawing.Point(12, 611);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(175, 50);
			this.btnSalir.TabIndex = 13;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(112)))), ((int)(((byte)(190)))));
			this.panel1.Controls.Add(this.btnEspecialidad);
			this.panel1.Controls.Add(this.btnSalir);
			this.panel1.Controls.Add(this.btnResumen);
			this.panel1.Controls.Add(this.btnConsultarCitas);
			this.panel1.Controls.Add(this.btnConsultarRecetas);
			this.panel1.Controls.Add(this.btnEmitirRecetas);
			this.panel1.Controls.Add(this.btnUsuarios);
			this.panel1.Controls.Add(this.btnAgendarCitas);
			this.panel1.Controls.Add(this.btnMedicos);
			this.panel1.Controls.Add(this.btnPacientes);
			this.panel1.Location = new System.Drawing.Point(0, 117);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 926);
			this.panel1.TabIndex = 1;
			// 
			// FrmMenuPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
			this.ClientSize = new System.Drawing.Size(1756, 1055);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panelContenedor);
			this.Name = "FrmMenuPrincipal";
			this.Text = "Menu Principal";
			this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herraminetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelContenedor;
		private System.Windows.Forms.Button btnPacientes;
		private System.Windows.Forms.Button btnMedicos;
		private System.Windows.Forms.Button btnAgendarCitas;
		private System.Windows.Forms.Button btnUsuarios;
		private System.Windows.Forms.Button btnEspecialidad;
		private System.Windows.Forms.Button btnEmitirRecetas;
		private System.Windows.Forms.Button btnConsultarRecetas;
		private System.Windows.Forms.Button btnConsultarCitas;
		private System.Windows.Forms.Button btnResumen;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Panel panel1;
	}
}


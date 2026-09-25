namespace Sistema_Gestion_de_Citas_Medicas
{
	partial class FrmConsultarRecetas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarRecetas));
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnImprimirReceta = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.grpBuscarCita = new System.Windows.Forms.GroupBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.grpListaCitas = new System.Windows.Forms.GroupBox();
			this.dgvCitas = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.grpBuscarCita.SuspendLayout();
			this.grpListaCitas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.panel2.Controls.Add(this.lblTitulo);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(885, 90);
			this.panel2.TabIndex = 15;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(119, 23);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(350, 42);
			this.lblTitulo.TabIndex = 13;
			this.lblTitulo.Text = "Historial de Recetas";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(89, 67);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// btnImprimirReceta
			// 
			this.btnImprimirReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(203)))), ((int)(((byte)(109)))));
			this.btnImprimirReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImprimirReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimirReceta.ForeColor = System.Drawing.Color.Black;
			this.btnImprimirReceta.Location = new System.Drawing.Point(711, 246);
			this.btnImprimirReceta.Name = "btnImprimirReceta";
			this.btnImprimirReceta.Size = new System.Drawing.Size(161, 75);
			this.btnImprimirReceta.TabIndex = 37;
			this.btnImprimirReceta.Text = "Imprimir Receta";
			this.btnImprimirReceta.UseVisualStyleBackColor = false;
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.Silver;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.Color.Black;
			this.btnVolver.Location = new System.Drawing.Point(712, 488);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(160, 59);
			this.btnVolver.TabIndex = 36;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = false;
			// 
			// grpBuscarCita
			// 
			this.grpBuscarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.grpBuscarCita.Controls.Add(this.richTextBox1);
			this.grpBuscarCita.Controls.Add(this.label1);
			this.grpBuscarCita.Controls.Add(this.dtpFecha);
			this.grpBuscarCita.Controls.Add(this.txtNombre);
			this.grpBuscarCita.Controls.Add(this.label6);
			this.grpBuscarCita.Controls.Add(this.label2);
			this.grpBuscarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpBuscarCita.Location = new System.Drawing.Point(12, 238);
			this.grpBuscarCita.Name = "grpBuscarCita";
			this.grpBuscarCita.Size = new System.Drawing.Size(690, 315);
			this.grpBuscarCita.TabIndex = 34;
			this.grpBuscarCita.TabStop = false;
			this.grpBuscarCita.Text = "Indicaciones Médicas";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(24, 161);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(618, 148);
			this.richTextBox1.TabIndex = 26;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(21, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 25);
			this.label1.TabIndex = 25;
			this.label1.Text = "Detalle:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(130, 82);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(387, 28);
			this.dtpFecha.TabIndex = 24;
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(130, 35);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.ReadOnly = true;
			this.txtNombre.Size = new System.Drawing.Size(512, 28);
			this.txtNombre.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(21, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 25);
			this.label6.TabIndex = 17;
			this.label6.Text = "Paciente:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(21, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 25);
			this.label2.TabIndex = 14;
			this.label2.Text = "Fecha:";
			// 
			// grpListaCitas
			// 
			this.grpListaCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.grpListaCitas.Controls.Add(this.dgvCitas);
			this.grpListaCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpListaCitas.Location = new System.Drawing.Point(12, 96);
			this.grpListaCitas.Name = "grpListaCitas";
			this.grpListaCitas.Size = new System.Drawing.Size(859, 136);
			this.grpListaCitas.TabIndex = 33;
			this.grpListaCitas.TabStop = false;
			this.grpListaCitas.Text = "Seleccionar Cita";
			// 
			// dgvCitas
			// 
			this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCitas.Location = new System.Drawing.Point(3, 24);
			this.dgvCitas.Name = "dgvCitas";
			this.dgvCitas.ReadOnly = true;
			this.dgvCitas.RowHeadersWidth = 51;
			this.dgvCitas.RowTemplate.Height = 24;
			this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCitas.Size = new System.Drawing.Size(853, 109);
			this.dgvCitas.TabIndex = 1;
			// 
			// FrmConsultarRecetas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 616);
			this.Controls.Add(this.btnImprimirReceta);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.grpBuscarCita);
			this.Controls.Add(this.grpListaCitas);
			this.Controls.Add(this.panel2);
			this.Name = "FrmConsultarRecetas";
			this.Text = "FrmControlRecetas";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.grpBuscarCita.ResumeLayout(false);
			this.grpBuscarCita.PerformLayout();
			this.grpListaCitas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnImprimirReceta;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.GroupBox grpBuscarCita;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox grpListaCitas;
		private System.Windows.Forms.DataGridView dgvCitas;
	}
}
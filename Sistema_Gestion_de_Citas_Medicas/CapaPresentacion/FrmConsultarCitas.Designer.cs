namespace Sistema_Gestion_de_Citas_Medicas
{
	partial class FrmConsultarCitas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarCitas));
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.grpBuscarCita = new System.Windows.Forms.GroupBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnNuevaCita = new System.Windows.Forms.Button();
			this.btnCancelarCita = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
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
			this.panel2.Size = new System.Drawing.Size(1281, 90);
			this.panel2.TabIndex = 14;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(119, 23);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(281, 42);
			this.lblTitulo.TabIndex = 13;
			this.lblTitulo.Text = "Control de Citas";
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
			// grpBuscarCita
			// 
			this.grpBuscarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.grpBuscarCita.Controls.Add(this.dtpFecha);
			this.grpBuscarCita.Controls.Add(this.txtNombre);
			this.grpBuscarCita.Controls.Add(this.label6);
			this.grpBuscarCita.Controls.Add(this.label2);
			this.grpBuscarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpBuscarCita.Location = new System.Drawing.Point(12, 105);
			this.grpBuscarCita.Name = "grpBuscarCita";
			this.grpBuscarCita.Size = new System.Drawing.Size(813, 136);
			this.grpBuscarCita.TabIndex = 15;
			this.grpBuscarCita.TabStop = false;
			this.grpBuscarCita.Text = "Buscar Cita";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(219, 85);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(387, 28);
			this.dtpFecha.TabIndex = 24;
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(219, 32);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(578, 28);
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
			this.label6.Size = new System.Drawing.Size(192, 25);
			this.label6.TabIndex = 17;
			this.label6.Text = "Paciente / Medico:";
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
			// btnNuevaCita
			// 
			this.btnNuevaCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(203)))), ((int)(((byte)(109)))));
			this.btnNuevaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevaCita.ForeColor = System.Drawing.Color.Black;
			this.btnNuevaCita.Location = new System.Drawing.Point(831, 105);
			this.btnNuevaCita.Name = "btnNuevaCita";
			this.btnNuevaCita.Size = new System.Drawing.Size(209, 50);
			this.btnNuevaCita.TabIndex = 27;
			this.btnNuevaCita.Text = "Nueva Cita";
			this.btnNuevaCita.UseVisualStyleBackColor = false;
			// 
			// btnCancelarCita
			// 
			this.btnCancelarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnCancelarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelarCita.ForeColor = System.Drawing.Color.Black;
			this.btnCancelarCita.Location = new System.Drawing.Point(1060, 105);
			this.btnCancelarCita.Name = "btnCancelarCita";
			this.btnCancelarCita.Size = new System.Drawing.Size(209, 50);
			this.btnCancelarCita.TabIndex = 29;
			this.btnCancelarCita.Text = "Cancelar Cita";
			this.btnCancelarCita.UseVisualStyleBackColor = false;
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.Silver;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.Color.Black;
			this.btnVolver.Location = new System.Drawing.Point(1057, 177);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(209, 50);
			this.btnVolver.TabIndex = 30;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = false;
			// 
			// grpListaCitas
			// 
			this.grpListaCitas.Controls.Add(this.dgvCitas);
			this.grpListaCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpListaCitas.Location = new System.Drawing.Point(12, 247);
			this.grpListaCitas.Name = "grpListaCitas";
			this.grpListaCitas.Size = new System.Drawing.Size(1257, 303);
			this.grpListaCitas.TabIndex = 31;
			this.grpListaCitas.TabStop = false;
			this.grpListaCitas.Text = "Lista de Citas";
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
			this.dgvCitas.Size = new System.Drawing.Size(1251, 276);
			this.dgvCitas.TabIndex = 0;
			// 
			// FrmConsultarCitas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1281, 562);
			this.Controls.Add(this.grpListaCitas);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnNuevaCita);
			this.Controls.Add(this.btnCancelarCita);
			this.Controls.Add(this.grpBuscarCita);
			this.Controls.Add(this.panel2);
			this.Name = "FrmConsultarCitas";
			this.Text = "FrmControlCitas";
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
		private System.Windows.Forms.GroupBox grpBuscarCita;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnNuevaCita;
		private System.Windows.Forms.Button btnCancelarCita;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.GroupBox grpListaCitas;
		private System.Windows.Forms.DataGridView dgvCitas;
	}
}
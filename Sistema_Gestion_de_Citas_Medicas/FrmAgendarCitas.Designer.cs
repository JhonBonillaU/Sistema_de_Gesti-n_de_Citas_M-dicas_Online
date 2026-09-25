namespace Sistema_Gestion_de_Citas_Medicas
{
	partial class FrmAgendarCitas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendarCitas));
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.grpAgendaCita = new System.Windows.Forms.GroupBox();
			this.cmbHora = new System.Windows.Forms.ComboBox();
			this.cmbMedico = new System.Windows.Forms.ComboBox();
			this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtPaciente = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAgendarCita = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.grpAgendaCita.SuspendLayout();
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
			this.panel2.Size = new System.Drawing.Size(987, 90);
			this.panel2.TabIndex = 13;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(119, 23);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(398, 42);
			this.lblTitulo.TabIndex = 13;
			this.lblTitulo.Text = "Agendamiento de Citas";
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
			// grpAgendaCita
			// 
			this.grpAgendaCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.grpAgendaCita.Controls.Add(this.cmbHora);
			this.grpAgendaCita.Controls.Add(this.cmbMedico);
			this.grpAgendaCita.Controls.Add(this.cmbEspecialidad);
			this.grpAgendaCita.Controls.Add(this.dtpFecha);
			this.grpAgendaCita.Controls.Add(this.txtEstado);
			this.grpAgendaCita.Controls.Add(this.txtPaciente);
			this.grpAgendaCita.Controls.Add(this.label6);
			this.grpAgendaCita.Controls.Add(this.label5);
			this.grpAgendaCita.Controls.Add(this.label3);
			this.grpAgendaCita.Controls.Add(this.label2);
			this.grpAgendaCita.Controls.Add(this.label1);
			this.grpAgendaCita.Controls.Add(this.label4);
			this.grpAgendaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpAgendaCita.Location = new System.Drawing.Point(12, 96);
			this.grpAgendaCita.Name = "grpAgendaCita";
			this.grpAgendaCita.Size = new System.Drawing.Size(776, 322);
			this.grpAgendaCita.TabIndex = 14;
			this.grpAgendaCita.TabStop = false;
			this.grpAgendaCita.Text = "Informacion requerida";
			// 
			// cmbHora
			// 
			this.cmbHora.FormattingEnabled = true;
			this.cmbHora.Location = new System.Drawing.Point(180, 233);
			this.cmbHora.Name = "cmbHora";
			this.cmbHora.Size = new System.Drawing.Size(387, 30);
			this.cmbHora.TabIndex = 27;
			// 
			// cmbMedico
			// 
			this.cmbMedico.FormattingEnabled = true;
			this.cmbMedico.Location = new System.Drawing.Point(180, 142);
			this.cmbMedico.Name = "cmbMedico";
			this.cmbMedico.Size = new System.Drawing.Size(578, 30);
			this.cmbMedico.TabIndex = 26;
			// 
			// cmbEspecialidad
			// 
			this.cmbEspecialidad.FormattingEnabled = true;
			this.cmbEspecialidad.Location = new System.Drawing.Point(180, 93);
			this.cmbEspecialidad.Name = "cmbEspecialidad";
			this.cmbEspecialidad.Size = new System.Drawing.Size(578, 30);
			this.cmbEspecialidad.TabIndex = 25;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(180, 189);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(387, 28);
			this.dtpFecha.TabIndex = 24;
			// 
			// txtEstado
			// 
			this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEstado.Location = new System.Drawing.Point(180, 277);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.ReadOnly = true;
			this.txtEstado.Size = new System.Drawing.Size(387, 28);
			this.txtEstado.TabIndex = 22;
			// 
			// txtPaciente
			// 
			this.txtPaciente.Enabled = false;
			this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPaciente.Location = new System.Drawing.Point(180, 49);
			this.txtPaciente.Name = "txtPaciente";
			this.txtPaciente.ReadOnly = true;
			this.txtPaciente.Size = new System.Drawing.Size(578, 28);
			this.txtPaciente.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(25, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 25);
			this.label6.TabIndex = 17;
			this.label6.Text = "Paciente:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(26, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 25);
			this.label5.TabIndex = 16;
			this.label5.Text = "Especialidad:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(25, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 25);
			this.label3.TabIndex = 15;
			this.label3.Text = "Médico:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(26, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 25);
			this.label2.TabIndex = 14;
			this.label2.Text = "Fecha:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(25, 236);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 25);
			this.label1.TabIndex = 13;
			this.label1.Text = "Hora:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(25, 277);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 25);
			this.label4.TabIndex = 12;
			this.label4.Text = "Estado:";
			// 
			// btnAgendarCita
			// 
			this.btnAgendarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(203)))), ((int)(((byte)(109)))));
			this.btnAgendarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgendarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgendarCita.ForeColor = System.Drawing.Color.Black;
			this.btnAgendarCita.Location = new System.Drawing.Point(815, 105);
			this.btnAgendarCita.Name = "btnAgendarCita";
			this.btnAgendarCita.Size = new System.Drawing.Size(160, 77);
			this.btnAgendarCita.TabIndex = 26;
			this.btnAgendarCita.Text = "Agendar Cita";
			this.btnAgendarCita.UseVisualStyleBackColor = false;
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.Silver;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.Color.Black;
			this.btnVolver.Location = new System.Drawing.Point(812, 356);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(160, 59);
			this.btnVolver.TabIndex = 28;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = false;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
			this.btnLimpiar.Location = new System.Drawing.Point(812, 285);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(160, 59);
			this.btnLimpiar.TabIndex = 29;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			// 
			// FrmAgendarCitas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 432);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnAgendarCita);
			this.Controls.Add(this.grpAgendaCita);
			this.Controls.Add(this.panel2);
			this.Name = "FrmAgendarCitas";
			this.Text = "FrmAgendarCitas";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.grpAgendaCita.ResumeLayout(false);
			this.grpAgendaCita.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.GroupBox grpAgendaCita;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtPaciente;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.ComboBox cmbHora;
		private System.Windows.Forms.ComboBox cmbMedico;
		private System.Windows.Forms.ComboBox cmbEspecialidad;
		private System.Windows.Forms.Button btnAgendarCita;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.Button btnLimpiar;
	}
}
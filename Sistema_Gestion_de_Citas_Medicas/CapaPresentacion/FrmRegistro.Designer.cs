namespace Sistema_Gestion_de_Citas_Medicas
{
    partial class FrmRegistro
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.grpDatosRegistro = new System.Windows.Forms.GroupBox();
			this.cmbGeneroRegistro = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dtpFechaNacimientoRegistro = new System.Windows.Forms.DateTimePicker();
			this.mtxtTelefonoRegistro = new System.Windows.Forms.MaskedTextBox();
			this.txtCorreoRegistro = new System.Windows.Forms.TextBox();
			this.txtApellidoRegistro = new System.Windows.Forms.TextBox();
			this.txtNombreRegistro = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCancelarRegistrar = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.txtConfirmarContraseñaRegistro = new System.Windows.Forms.TextBox();
			this.txtContraseñaRegistro = new System.Windows.Forms.TextBox();
			this.txtNombreUsuarioRegistro = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.errorProviderRegistro = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.grpDatosRegistro.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistro)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.lblTitulo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(967, 126);
			this.panel2.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(359, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(201, 25);
			this.label2.TabIndex = 8;
			this.label2.Text = "Registro de Usuario";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(44, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 102);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
			this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(190, 23);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(571, 52);
			this.lblTitulo.TabIndex = 4;
			this.lblTitulo.Text = "UNIVERSIDAD DON BOSCO";
			// 
			// grpDatosRegistro
			// 
			this.grpDatosRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.grpDatosRegistro.Controls.Add(this.cmbGeneroRegistro);
			this.grpDatosRegistro.Controls.Add(this.label8);
			this.grpDatosRegistro.Controls.Add(this.dtpFechaNacimientoRegistro);
			this.grpDatosRegistro.Controls.Add(this.mtxtTelefonoRegistro);
			this.grpDatosRegistro.Controls.Add(this.txtCorreoRegistro);
			this.grpDatosRegistro.Controls.Add(this.txtApellidoRegistro);
			this.grpDatosRegistro.Controls.Add(this.txtNombreRegistro);
			this.grpDatosRegistro.Controls.Add(this.label3);
			this.grpDatosRegistro.Controls.Add(this.label4);
			this.grpDatosRegistro.Controls.Add(this.label5);
			this.grpDatosRegistro.Controls.Add(this.label6);
			this.grpDatosRegistro.Controls.Add(this.label7);
			this.grpDatosRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpDatosRegistro.Location = new System.Drawing.Point(12, 147);
			this.grpDatosRegistro.Name = "grpDatosRegistro";
			this.grpDatosRegistro.Size = new System.Drawing.Size(450, 442);
			this.grpDatosRegistro.TabIndex = 9;
			this.grpDatosRegistro.TabStop = false;
			this.grpDatosRegistro.Text = "Datos del Paciente";
			// 
			// cmbGeneroRegistro
			// 
			this.cmbGeneroRegistro.FormattingEnabled = true;
			this.cmbGeneroRegistro.Location = new System.Drawing.Point(40, 387);
			this.cmbGeneroRegistro.Name = "cmbGeneroRegistro";
			this.cmbGeneroRegistro.Size = new System.Drawing.Size(373, 30);
			this.cmbGeneroRegistro.TabIndex = 26;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(35, 359);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 25);
			this.label8.TabIndex = 25;
			this.label8.Text = "Género:";
			// 
			// dtpFechaNacimientoRegistro
			// 
			this.dtpFechaNacimientoRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaNacimientoRegistro.Location = new System.Drawing.Point(266, 186);
			this.dtpFechaNacimientoRegistro.Name = "dtpFechaNacimientoRegistro";
			this.dtpFechaNacimientoRegistro.Size = new System.Drawing.Size(147, 28);
			this.dtpFechaNacimientoRegistro.TabIndex = 24;
			// 
			// mtxtTelefonoRegistro
			// 
			this.mtxtTelefonoRegistro.Location = new System.Drawing.Point(180, 233);
			this.mtxtTelefonoRegistro.Mask = "0000-0000";
			this.mtxtTelefonoRegistro.Name = "mtxtTelefonoRegistro";
			this.mtxtTelefonoRegistro.Size = new System.Drawing.Size(109, 28);
			this.mtxtTelefonoRegistro.TabIndex = 23;
			// 
			// txtCorreoRegistro
			// 
			this.txtCorreoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreoRegistro.Location = new System.Drawing.Point(40, 305);
			this.txtCorreoRegistro.Name = "txtCorreoRegistro";
			this.txtCorreoRegistro.Size = new System.Drawing.Size(373, 28);
			this.txtCorreoRegistro.TabIndex = 22;
			// 
			// txtApellidoRegistro
			// 
			this.txtApellidoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoRegistro.Location = new System.Drawing.Point(40, 142);
			this.txtApellidoRegistro.Name = "txtApellidoRegistro";
			this.txtApellidoRegistro.Size = new System.Drawing.Size(373, 28);
			this.txtApellidoRegistro.TabIndex = 21;
			// 
			// txtNombreRegistro
			// 
			this.txtNombreRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreRegistro.Location = new System.Drawing.Point(40, 67);
			this.txtNombreRegistro.Name = "txtNombreRegistro";
			this.txtNombreRegistro.Size = new System.Drawing.Size(373, 28);
			this.txtNombreRegistro.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(35, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 25);
			this.label3.TabIndex = 16;
			this.label3.Text = "Nombre:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(35, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 25);
			this.label4.TabIndex = 15;
			this.label4.Text = "Apellido:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(35, 189);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(222, 25);
			this.label5.TabIndex = 14;
			this.label5.Text = "Fecha de Nacimiento:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(35, 234);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 25);
			this.label6.TabIndex = 13;
			this.label6.Text = "Teléfono:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(35, 277);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 25);
			this.label7.TabIndex = 12;
			this.label7.Text = "Correo:";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
			this.groupBox1.Controls.Add(this.btnCancelarRegistrar);
			this.groupBox1.Controls.Add(this.btnRegistrar);
			this.groupBox1.Controls.Add(this.txtConfirmarContraseñaRegistro);
			this.groupBox1.Controls.Add(this.txtContraseñaRegistro);
			this.groupBox1.Controls.Add(this.txtNombreUsuarioRegistro);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(495, 147);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(450, 442);
			this.groupBox1.TabIndex = 27;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Credenciales de Usuario";
			// 
			// btnCancelarRegistrar
			// 
			this.btnCancelarRegistrar.BackColor = System.Drawing.Color.Red;
			this.btnCancelarRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelarRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelarRegistrar.ForeColor = System.Drawing.Color.Black;
			this.btnCancelarRegistrar.Location = new System.Drawing.Point(235, 343);
			this.btnCancelarRegistrar.Name = "btnCancelarRegistrar";
			this.btnCancelarRegistrar.Size = new System.Drawing.Size(178, 53);
			this.btnCancelarRegistrar.TabIndex = 25;
			this.btnCancelarRegistrar.Text = "Cancelar";
			this.btnCancelarRegistrar.UseVisualStyleBackColor = false;
			this.btnCancelarRegistrar.Click += new System.EventHandler(this.btnCancelarRegistrar_Click);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(157)))), ((int)(((byte)(71)))));
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
			this.btnRegistrar.Location = new System.Drawing.Point(40, 343);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(176, 53);
			this.btnRegistrar.TabIndex = 24;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// txtConfirmarContraseñaRegistro
			// 
			this.txtConfirmarContraseñaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfirmarContraseñaRegistro.Location = new System.Drawing.Point(40, 217);
			this.txtConfirmarContraseñaRegistro.Name = "txtConfirmarContraseñaRegistro";
			this.txtConfirmarContraseñaRegistro.Size = new System.Drawing.Size(373, 28);
			this.txtConfirmarContraseñaRegistro.TabIndex = 22;
			this.txtConfirmarContraseñaRegistro.UseSystemPasswordChar = true;
			// 
			// txtContraseñaRegistro
			// 
			this.txtContraseñaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContraseñaRegistro.Location = new System.Drawing.Point(40, 142);
			this.txtContraseñaRegistro.Name = "txtContraseñaRegistro";
			this.txtContraseñaRegistro.Size = new System.Drawing.Size(373, 28);
			this.txtContraseñaRegistro.TabIndex = 21;
			// 
			// txtNombreUsuarioRegistro
			// 
			this.txtNombreUsuarioRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreUsuarioRegistro.Location = new System.Drawing.Point(40, 67);
			this.txtNombreUsuarioRegistro.Name = "txtNombreUsuarioRegistro";
			this.txtNombreUsuarioRegistro.Size = new System.Drawing.Size(373, 28);
			this.txtNombreUsuarioRegistro.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(35, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(204, 25);
			this.label9.TabIndex = 16;
			this.label9.Text = "Nombre de Usuario:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(35, 114);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(131, 25);
			this.label10.TabIndex = 15;
			this.label10.Text = "Contraseña:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(35, 189);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(231, 25);
			this.label11.TabIndex = 12;
			this.label11.Text = "Confirmar Contraseña:";
			// 
			// errorProviderRegistro
			// 
			this.errorProviderRegistro.ContainerControl = this;
			// 
			// FrmRegistrocs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(967, 619);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grpDatosRegistro);
			this.Controls.Add(this.panel2);
			this.Name = "FrmRegistrocs";
			this.Text = "FrmRegistrocs";
			this.Load += new System.EventHandler(this.FrmRegistrocs_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.grpDatosRegistro.ResumeLayout(false);
			this.grpDatosRegistro.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistro)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDatosRegistro;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoRegistro;
        private System.Windows.Forms.MaskedTextBox mtxtTelefonoRegistro;
        private System.Windows.Forms.TextBox txtCorreoRegistro;
        private System.Windows.Forms.TextBox txtApellidoRegistro;
        private System.Windows.Forms.TextBox txtNombreRegistro;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGeneroRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConfirmarContraseñaRegistro;
        private System.Windows.Forms.TextBox txtContraseñaRegistro;
        private System.Windows.Forms.TextBox txtNombreUsuarioRegistro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnCancelarRegistrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ErrorProvider errorProviderRegistro;
    }
}
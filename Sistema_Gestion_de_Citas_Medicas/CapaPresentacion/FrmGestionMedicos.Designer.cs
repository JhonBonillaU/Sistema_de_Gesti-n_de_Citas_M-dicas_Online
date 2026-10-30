namespace Sistema_Gestion_de_Citas_Medicas
{
    partial class FrmGestionMedicos
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
            this.grpDatosMedico = new System.Windows.Forms.GroupBox();
            this.btnLimpiarEspecialidad = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotalMedicos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEliminarMedico = new System.Windows.Forms.Button();
            this.btnModificarMedico = new System.Windows.Forms.Button();
            this.btnGuardarMedico = new System.Windows.Forms.Button();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.grpDatosMedico.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosMedico
            // 
            this.grpDatosMedico.Controls.Add(this.btnLimpiarEspecialidad);
            this.grpDatosMedico.Controls.Add(this.statusStrip1);
            this.grpDatosMedico.Controls.Add(this.btnEliminarMedico);
            this.grpDatosMedico.Controls.Add(this.btnModificarMedico);
            this.grpDatosMedico.Controls.Add(this.btnGuardarMedico);
            this.grpDatosMedico.Controls.Add(this.cmbEspecialidad);
            this.grpDatosMedico.Controls.Add(this.label6);
            this.grpDatosMedico.Controls.Add(this.txtTelefono);
            this.grpDatosMedico.Controls.Add(this.txtCorreo);
            this.grpDatosMedico.Controls.Add(this.txtApellido);
            this.grpDatosMedico.Controls.Add(this.txtNombre);
            this.grpDatosMedico.Controls.Add(this.txtIdMedico);
            this.grpDatosMedico.Controls.Add(this.label1);
            this.grpDatosMedico.Controls.Add(this.label2);
            this.grpDatosMedico.Controls.Add(this.label3);
            this.grpDatosMedico.Controls.Add(this.label4);
            this.grpDatosMedico.Controls.Add(this.label5);
            this.grpDatosMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosMedico.Location = new System.Drawing.Point(341, 221);
            this.grpDatosMedico.Name = "grpDatosMedico";
            this.grpDatosMedico.Size = new System.Drawing.Size(489, 587);
            this.grpDatosMedico.TabIndex = 9;
            this.grpDatosMedico.TabStop = false;
            this.grpDatosMedico.Text = "Datos del Médico";
            // 
            // btnLimpiarEspecialidad
            // 
            this.btnLimpiarEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimpiarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarEspecialidad.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarEspecialidad.Location = new System.Drawing.Point(55, 478);
            this.btnLimpiarEspecialidad.Name = "btnLimpiarEspecialidad";
            this.btnLimpiarEspecialidad.Size = new System.Drawing.Size(142, 40);
            this.btnLimpiarEspecialidad.TabIndex = 29;
            this.btnLimpiarEspecialidad.Text = "Limpiar";
            this.btnLimpiarEspecialidad.UseVisualStyleBackColor = false;
            this.btnLimpiarEspecialidad.Click += new System.EventHandler(this.btnLimpiarEspecialidad_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalMedicos,
            this.lblEstadoConexion});
            this.statusStrip1.Location = new System.Drawing.Point(3, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(483, 26);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTotalMedicos
            // 
            this.lblTotalMedicos.Name = "lblTotalMedicos";
            this.lblTotalMedicos.Size = new System.Drawing.Size(158, 20);
            this.lblTotalMedicos.Text = "Médicos registrados: 0";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(212, 20);
            this.lblEstadoConexion.Text = "Conexión: Base de Datos Local";
            // 
            // btnEliminarMedico
            // 
            this.btnEliminarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMedico.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarMedico.Location = new System.Drawing.Point(246, 478);
            this.btnEliminarMedico.Name = "btnEliminarMedico";
            this.btnEliminarMedico.Size = new System.Drawing.Size(164, 40);
            this.btnEliminarMedico.TabIndex = 27;
            this.btnEliminarMedico.Text = "Eliminar";
            this.btnEliminarMedico.UseVisualStyleBackColor = false;
            this.btnEliminarMedico.Click += new System.EventHandler(this.btnEliminarMedico_Click);
            // 
            // btnModificarMedico
            // 
            this.btnModificarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.btnModificarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMedico.ForeColor = System.Drawing.Color.Black;
            this.btnModificarMedico.Location = new System.Drawing.Point(246, 414);
            this.btnModificarMedico.Name = "btnModificarMedico";
            this.btnModificarMedico.Size = new System.Drawing.Size(164, 40);
            this.btnModificarMedico.TabIndex = 26;
            this.btnModificarMedico.Text = "Modificar";
            this.btnModificarMedico.UseVisualStyleBackColor = false;
            this.btnModificarMedico.Click += new System.EventHandler(this.btnModificarMedico_Click);
            // 
            // btnGuardarMedico
            // 
            this.btnGuardarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(203)))), ((int)(((byte)(109)))));
            this.btnGuardarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMedico.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarMedico.Location = new System.Drawing.Point(55, 414);
            this.btnGuardarMedico.Name = "btnGuardarMedico";
            this.btnGuardarMedico.Size = new System.Drawing.Size(142, 40);
            this.btnGuardarMedico.TabIndex = 25;
            this.btnGuardarMedico.Text = "Guardar";
            this.btnGuardarMedico.UseVisualStyleBackColor = false;
            this.btnGuardarMedico.Click += new System.EventHandler(this.btnGuardarMedico_Click);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(181, 272);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(259, 30);
            this.cmbEspecialidad.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Especialidad:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(181, 187);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(109, 28);
            this.txtTelefono.TabIndex = 23;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(181, 228);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 28);
            this.txtCorreo.TabIndex = 22;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(180, 142);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(260, 28);
            this.txtApellido.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(180, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 28);
            this.txtNombre.TabIndex = 20;
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Enabled = false;
            this.txtIdMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMedico.Location = new System.Drawing.Point(180, 50);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.ReadOnly = true;
            this.txtIdMedico.Size = new System.Drawing.Size(148, 28);
            this.txtIdMedico.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID Médico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Correo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(836, 139);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(333, 42);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Control de Médicos";
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(843, 221);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.RowHeadersWidth = 51;
            this.dgvMedicos.RowTemplate.Height = 24;
            this.dgvMedicos.Size = new System.Drawing.Size(1056, 584);
            this.dgvMedicos.TabIndex = 13;
            this.dgvMedicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicos_CellContentClick);
            // 
            // FrmGestionMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 851);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpDatosMedico);
            this.Name = "FrmGestionMedicos";
            this.Text = "Gestion Medico";
            this.Load += new System.EventHandler(this.FrmGestionMedico_Load);
            this.grpDatosMedico.ResumeLayout(false);
            this.grpDatosMedico.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosMedico;
		private System.Windows.Forms.MaskedTextBox txtTelefono;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnGuardarMedico;
        private System.Windows.Forms.Button btnModificarMedico;
        private System.Windows.Forms.Button btnEliminarMedico;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalMedicos;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
		private System.Windows.Forms.Button btnLimpiarEspecialidad;
	}
}
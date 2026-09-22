namespace Sistema_Gestion_de_Citas_Medicas
{
    partial class FrmGestionMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionMedico));
            this.grpDatosPacientes = new System.Windows.Forms.GroupBox();
            this.mtxtTelefonoMedico = new System.Windows.Forms.MaskedTextBox();
            this.txtCorreoMedico = new System.Windows.Forms.TextBox();
            this.txtApellidoMedico = new System.Windows.Forms.TextBox();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardarMedico = new System.Windows.Forms.Button();
            this.btnModificarMedico = new System.Windows.Forms.Button();
            this.btnEliminarMedico = new System.Windows.Forms.Button();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotalMedicos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpDatosPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPacientes
            // 
            this.grpDatosPacientes.Controls.Add(this.statusStrip1);
            this.grpDatosPacientes.Controls.Add(this.btnEliminarMedico);
            this.grpDatosPacientes.Controls.Add(this.btnModificarMedico);
            this.grpDatosPacientes.Controls.Add(this.btnGuardarMedico);
            this.grpDatosPacientes.Controls.Add(this.cmbEspecialidad);
            this.grpDatosPacientes.Controls.Add(this.label2);
            this.grpDatosPacientes.Controls.Add(this.mtxtTelefonoMedico);
            this.grpDatosPacientes.Controls.Add(this.txtCorreoMedico);
            this.grpDatosPacientes.Controls.Add(this.txtApellidoMedico);
            this.grpDatosPacientes.Controls.Add(this.txtNombreMedico);
            this.grpDatosPacientes.Controls.Add(this.txtIdMedico);
            this.grpDatosPacientes.Controls.Add(this.label6);
            this.grpDatosPacientes.Controls.Add(this.c);
            this.grpDatosPacientes.Controls.Add(this.label3);
            this.grpDatosPacientes.Controls.Add(this.label1);
            this.grpDatosPacientes.Controls.Add(this.label4);
            this.grpDatosPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosPacientes.Location = new System.Drawing.Point(36, 107);
            this.grpDatosPacientes.Name = "grpDatosPacientes";
            this.grpDatosPacientes.Size = new System.Drawing.Size(469, 587);
            this.grpDatosPacientes.TabIndex = 9;
            this.grpDatosPacientes.TabStop = false;
            this.grpDatosPacientes.Text = "Datos del Paciente";
            // 
            // mtxtTelefonoMedico
            // 
            this.mtxtTelefonoMedico.Location = new System.Drawing.Point(181, 187);
            this.mtxtTelefonoMedico.Mask = "0000-0000";
            this.mtxtTelefonoMedico.Name = "mtxtTelefonoMedico";
            this.mtxtTelefonoMedico.Size = new System.Drawing.Size(109, 28);
            this.mtxtTelefonoMedico.TabIndex = 23;
            // 
            // txtCorreoMedico
            // 
            this.txtCorreoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoMedico.Location = new System.Drawing.Point(181, 228);
            this.txtCorreoMedico.Name = "txtCorreoMedico";
            this.txtCorreoMedico.Size = new System.Drawing.Size(259, 28);
            this.txtCorreoMedico.TabIndex = 22;
            // 
            // txtApellidoMedico
            // 
            this.txtApellidoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMedico.Location = new System.Drawing.Point(180, 142);
            this.txtApellidoMedico.Name = "txtApellidoMedico";
            this.txtApellidoMedico.Size = new System.Drawing.Size(260, 28);
            this.txtApellidoMedico.TabIndex = 21;
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMedico.Location = new System.Drawing.Point(180, 94);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(260, 28);
            this.txtNombreMedico.TabIndex = 20;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID Médico:";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.BackColor = System.Drawing.Color.Transparent;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.Color.Black;
            this.c.Location = new System.Drawing.Point(26, 94);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(94, 25);
            this.c.TabIndex = 16;
            this.c.Text = "Nombre:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Correo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(143, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(333, 42);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Control de Médicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Especialidad:";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 90);
            this.panel2.TabIndex = 12;
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
            // 
            // btnEliminarMedico
            // 
            this.btnEliminarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMedico.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarMedico.Location = new System.Drawing.Point(148, 473);
            this.btnEliminarMedico.Name = "btnEliminarMedico";
            this.btnEliminarMedico.Size = new System.Drawing.Size(142, 40);
            this.btnEliminarMedico.TabIndex = 27;
            this.btnEliminarMedico.Text = "Eliminar";
            this.btnEliminarMedico.UseVisualStyleBackColor = false;
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(538, 157);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.RowHeadersWidth = 51;
            this.dgvMedicos.RowTemplate.Height = 24;
            this.dgvMedicos.Size = new System.Drawing.Size(751, 534);
            this.dgvMedicos.TabIndex = 13;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(624, 123);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(406, 28);
            this.txtBuscar.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(543, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Buscar:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalMedicos,
            this.lblEstadoConexion});
            this.statusStrip1.Location = new System.Drawing.Point(3, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(463, 26);
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
            // FrmGestionMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 703);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpDatosPacientes);
            this.Controls.Add(this.panel2);
            this.Name = "FrmGestionMedico";
            this.Text = "FrmGestionMedico";
            this.Load += new System.EventHandler(this.FrmGestionMedico_Load);
            this.grpDatosPacientes.ResumeLayout(false);
            this.grpDatosPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPacientes;
        private System.Windows.Forms.MaskedTextBox mtxtTelefonoMedico;
        private System.Windows.Forms.TextBox txtCorreoMedico;
        private System.Windows.Forms.TextBox txtApellidoMedico;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardarMedico;
        private System.Windows.Forms.Button btnModificarMedico;
        private System.Windows.Forms.Button btnEliminarMedico;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalMedicos;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
    }
}
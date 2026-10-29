namespace Sistema_Gestion_de_Citas_Medicas.CapaPresentacion
{
    partial class FrmGestionUsuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionUsuarios));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.grpDatosPacientes = new System.Windows.Forms.GroupBox();
			this.btnLimpiarUsuario = new System.Windows.Forms.Button();
			this.btnEliminarUsuario = new System.Windows.Forms.Button();
			this.btnModificarUsuario = new System.Windows.Forms.Button();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtIdUsuario = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.grpDatosPacientes.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(32, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(89, 67);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(139, 21);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(348, 42);
			this.lblTitulo.TabIndex = 22;
			this.lblTitulo.Text = "Gestión de Usuarios";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.lblTitulo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1283, 90);
			this.panel2.TabIndex = 24;
			// 
			// grpDatosPacientes
			// 
			this.grpDatosPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.grpDatosPacientes.Controls.Add(this.btnLimpiarUsuario);
			this.grpDatosPacientes.Controls.Add(this.btnEliminarUsuario);
			this.grpDatosPacientes.Controls.Add(this.btnModificarUsuario);
			this.grpDatosPacientes.Controls.Add(this.cmbRol);
			this.grpDatosPacientes.Controls.Add(this.txtPassword);
			this.grpDatosPacientes.Controls.Add(this.txtUsername);
			this.grpDatosPacientes.Controls.Add(this.txtIdUsuario);
			this.grpDatosPacientes.Controls.Add(this.label1);
			this.grpDatosPacientes.Controls.Add(this.label2);
			this.grpDatosPacientes.Controls.Add(this.label3);
			this.grpDatosPacientes.Controls.Add(this.label6);
			this.grpDatosPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpDatosPacientes.Location = new System.Drawing.Point(32, 117);
			this.grpDatosPacientes.Name = "grpDatosPacientes";
			this.grpDatosPacientes.Size = new System.Drawing.Size(575, 451);
			this.grpDatosPacientes.TabIndex = 25;
			this.grpDatosPacientes.TabStop = false;
			this.grpDatosPacientes.Text = "Datos del Usuario";
			// 
			// btnLimpiarUsuario
			// 
			this.btnLimpiarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnLimpiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiarUsuario.ForeColor = System.Drawing.Color.Black;
			this.btnLimpiarUsuario.Location = new System.Drawing.Point(219, 307);
			this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
			this.btnLimpiarUsuario.Size = new System.Drawing.Size(164, 40);
			this.btnLimpiarUsuario.TabIndex = 28;
			this.btnLimpiarUsuario.Text = "Limpiar";
			this.btnLimpiarUsuario.UseVisualStyleBackColor = false;
			this.btnLimpiarUsuario.Click += new System.EventHandler(this.btnLimpiarUsuario_Click);
			// 
			// btnEliminarUsuario
			// 
			this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminarUsuario.ForeColor = System.Drawing.Color.Black;
			this.btnEliminarUsuario.Location = new System.Drawing.Point(403, 307);
			this.btnEliminarUsuario.Name = "btnEliminarUsuario";
			this.btnEliminarUsuario.Size = new System.Drawing.Size(142, 40);
			this.btnEliminarUsuario.TabIndex = 27;
			this.btnEliminarUsuario.Text = "Eliminar";
			this.btnEliminarUsuario.UseVisualStyleBackColor = false;
			this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
			// 
			// btnModificarUsuario
			// 
			this.btnModificarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
			this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificarUsuario.ForeColor = System.Drawing.Color.Black;
			this.btnModificarUsuario.Location = new System.Drawing.Point(28, 307);
			this.btnModificarUsuario.Name = "btnModificarUsuario";
			this.btnModificarUsuario.Size = new System.Drawing.Size(164, 40);
			this.btnModificarUsuario.TabIndex = 26;
			this.btnModificarUsuario.Text = "Modificar";
			this.btnModificarUsuario.UseVisualStyleBackColor = false;
			this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
			// 
			// cmbRol
			// 
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Location = new System.Drawing.Point(236, 194);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(309, 30);
			this.cmbRol.TabIndex = 22;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(236, 142);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(309, 28);
			this.txtPassword.TabIndex = 21;
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(236, 91);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(309, 28);
			this.txtUsername.TabIndex = 20;
			// 
			// txtIdUsuario
			// 
			this.txtIdUsuario.Enabled = false;
			this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdUsuario.Location = new System.Drawing.Point(236, 48);
			this.txtIdUsuario.Name = "txtIdUsuario";
			this.txtIdUsuario.ReadOnly = true;
			this.txtIdUsuario.Size = new System.Drawing.Size(148, 28);
			this.txtIdUsuario.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(25, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 25);
			this.label1.TabIndex = 17;
			this.label1.Text = "ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(26, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(204, 25);
			this.label2.TabIndex = 16;
			this.label2.Text = "Nombre de Usuario:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(25, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 25);
			this.label3.TabIndex = 15;
			this.label3.Text = "Contraseña:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(25, 194);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 25);
			this.label6.TabIndex = 12;
			this.label6.Text = "Rol:";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.groupBox1.Controls.Add(this.dgvUsuarios);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(627, 117);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(632, 451);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Usuario Registradas";
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUsuarios.Location = new System.Drawing.Point(3, 24);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.ReadOnly = true;
			this.dgvUsuarios.RowHeadersWidth = 51;
			this.dgvUsuarios.RowTemplate.Height = 24;
			this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsuarios.Size = new System.Drawing.Size(626, 424);
			this.dgvUsuarios.TabIndex = 1;
			this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
			// 
			// FrmGestionUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1283, 580);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grpDatosPacientes);
			this.Controls.Add(this.panel2);
			this.Name = "FrmGestionUsuarios";
			this.Text = "Gestion Usuarios";
			this.Load += new System.EventHandler(this.FrmGestionUsuarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.grpDatosPacientes.ResumeLayout(false);
			this.grpDatosPacientes.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpDatosPacientes;
        private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}
namespace Sistema_Gestion_de_Citas_Medicas.CapaPresentacion
{
    partial class FrmGestionEspecialidades
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpDatosPacientes = new System.Windows.Forms.GroupBox();
            this.btnLimpiarEspecialidad = new System.Windows.Forms.Button();
            this.btnEliminarEspecialidad = new System.Windows.Forms.Button();
            this.btnModificarEspecialidad = new System.Windows.Forms.Button();
            this.btnGuardarEspecialidad = new System.Windows.Forms.Button();
            this.txtNombreEspecialidad = new System.Windows.Forms.TextBox();
            this.txtIdEspecialidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.grpDatosPacientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(542, 140);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(414, 42);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Gestión de Especialidad";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1302, 90);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // grpDatosPacientes
            // 
            this.grpDatosPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.grpDatosPacientes.Controls.Add(this.btnLimpiarEspecialidad);
            this.grpDatosPacientes.Controls.Add(this.btnEliminarEspecialidad);
            this.grpDatosPacientes.Controls.Add(this.btnModificarEspecialidad);
            this.grpDatosPacientes.Controls.Add(this.btnGuardarEspecialidad);
            this.grpDatosPacientes.Controls.Add(this.txtNombreEspecialidad);
            this.grpDatosPacientes.Controls.Add(this.txtIdEspecialidad);
            this.grpDatosPacientes.Controls.Add(this.label1);
            this.grpDatosPacientes.Controls.Add(this.label2);
            this.grpDatosPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosPacientes.Location = new System.Drawing.Point(277, 206);
            this.grpDatosPacientes.Name = "grpDatosPacientes";
            this.grpDatosPacientes.Size = new System.Drawing.Size(433, 472);
            this.grpDatosPacientes.TabIndex = 16;
            this.grpDatosPacientes.TabStop = false;
            this.grpDatosPacientes.Text = "Datos de Especialidad";
            // 
            // btnLimpiarEspecialidad
            // 
            this.btnLimpiarEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimpiarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarEspecialidad.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarEspecialidad.Location = new System.Drawing.Point(30, 378);
            this.btnLimpiarEspecialidad.Name = "btnLimpiarEspecialidad";
            this.btnLimpiarEspecialidad.Size = new System.Drawing.Size(142, 40);
            this.btnLimpiarEspecialidad.TabIndex = 24;
            this.btnLimpiarEspecialidad.Text = "Limpiar";
            this.btnLimpiarEspecialidad.UseVisualStyleBackColor = false;
            this.btnLimpiarEspecialidad.Click += new System.EventHandler(this.btnLimpiarEspecialidad_Click);
            // 
            // btnEliminarEspecialidad
            // 
            this.btnEliminarEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEspecialidad.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarEspecialidad.Location = new System.Drawing.Point(241, 378);
            this.btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            this.btnEliminarEspecialidad.Size = new System.Drawing.Size(164, 40);
            this.btnEliminarEspecialidad.TabIndex = 23;
            this.btnEliminarEspecialidad.Text = "Eliminar";
            this.btnEliminarEspecialidad.UseVisualStyleBackColor = false;
            this.btnEliminarEspecialidad.Click += new System.EventHandler(this.btnEliminarEspecialidad_Click);
            // 
            // btnModificarEspecialidad
            // 
            this.btnModificarEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.btnModificarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEspecialidad.ForeColor = System.Drawing.Color.Black;
            this.btnModificarEspecialidad.Location = new System.Drawing.Point(241, 301);
            this.btnModificarEspecialidad.Name = "btnModificarEspecialidad";
            this.btnModificarEspecialidad.Size = new System.Drawing.Size(164, 40);
            this.btnModificarEspecialidad.TabIndex = 22;
            this.btnModificarEspecialidad.Text = "Modificar";
            this.btnModificarEspecialidad.UseVisualStyleBackColor = false;
            this.btnModificarEspecialidad.Click += new System.EventHandler(this.btnModificarEspecialidad_Click);
            // 
            // btnGuardarEspecialidad
            // 
            this.btnGuardarEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(203)))), ((int)(((byte)(109)))));
            this.btnGuardarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEspecialidad.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarEspecialidad.Location = new System.Drawing.Point(30, 301);
            this.btnGuardarEspecialidad.Name = "btnGuardarEspecialidad";
            this.btnGuardarEspecialidad.Size = new System.Drawing.Size(142, 40);
            this.btnGuardarEspecialidad.TabIndex = 21;
            this.btnGuardarEspecialidad.Text = "Guardar";
            this.btnGuardarEspecialidad.UseVisualStyleBackColor = false;
            this.btnGuardarEspecialidad.Click += new System.EventHandler(this.btnGuardarEspecialidad_Click);
            // 
            // txtNombreEspecialidad
            // 
            this.txtNombreEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEspecialidad.Location = new System.Drawing.Point(29, 183);
            this.txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            this.txtNombreEspecialidad.Size = new System.Drawing.Size(376, 28);
            this.txtNombreEspecialidad.TabIndex = 20;
            // 
            // txtIdEspecialidad
            // 
            this.txtIdEspecialidad.Enabled = false;
            this.txtIdEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEspecialidad.Location = new System.Drawing.Point(29, 95);
            this.txtIdEspecialidad.Name = "txtIdEspecialidad";
            this.txtIdEspecialidad.ReadOnly = true;
            this.txtIdEspecialidad.Size = new System.Drawing.Size(148, 28);
            this.txtIdEspecialidad.TabIndex = 19;
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
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre de Especialidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.groupBox1.Controls.Add(this.dgvEspecialidades);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(741, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 472);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especialidades Registradas";
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecialidades.Location = new System.Drawing.Point(3, 24);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.RowHeadersWidth = 51;
            this.dgvEspecialidades.RowTemplate.Height = 24;
            this.dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Size = new System.Drawing.Size(512, 445);
            this.dgvEspecialidades.TabIndex = 1;
            this.dgvEspecialidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialidad_CellContentClick);
            // 
            // FrmGestionEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 761);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDatosPacientes);
            this.Controls.Add(this.panel2);
            this.Name = "FrmGestionEspecialidades";
            this.Text = "Gestion Especialidades";
            this.Load += new System.EventHandler(this.FrmGestionEspecialidades_Load);
            this.grpDatosPacientes.ResumeLayout(false);
            this.grpDatosPacientes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpDatosPacientes;
        private System.Windows.Forms.TextBox txtNombreEspecialidad;
        private System.Windows.Forms.TextBox txtIdEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarEspecialidad;
        private System.Windows.Forms.Button btnModificarEspecialidad;
        private System.Windows.Forms.Button btnLimpiarEspecialidad;
        private System.Windows.Forms.Button btnEliminarEspecialidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
    }
}
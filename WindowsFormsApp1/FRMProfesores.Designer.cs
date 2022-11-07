namespace WindowsFormsApp1
{
    partial class FRMProfesores
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
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAltaProfesor = new System.Windows.Forms.Button();
            this.btnBajaProfesor = new System.Windows.Forms.Button();
            this.btnModProfeosr = new System.Windows.Forms.Button();
            this.dtgProfesor = new System.Windows.Forms.DataGridView();
            this.idProfesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAntiguoProfesor = new System.Windows.Forms.Button();
            this.btnNuevoProfesor = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(Logica.Profesor);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(1043, 169);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAltaProfesor
            // 
            this.btnAltaProfesor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAltaProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProfesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaProfesor.Location = new System.Drawing.Point(31, 63);
            this.btnAltaProfesor.Name = "btnAltaProfesor";
            this.btnAltaProfesor.Size = new System.Drawing.Size(194, 42);
            this.btnAltaProfesor.TabIndex = 5;
            this.btnAltaProfesor.Text = "Alta Profesor";
            this.btnAltaProfesor.UseVisualStyleBackColor = false;
            this.btnAltaProfesor.Click += new System.EventHandler(this.btnAltaProfesor_Click);
            // 
            // btnBajaProfesor
            // 
            this.btnBajaProfesor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBajaProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaProfesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBajaProfesor.Location = new System.Drawing.Point(431, 63);
            this.btnBajaProfesor.Name = "btnBajaProfesor";
            this.btnBajaProfesor.Size = new System.Drawing.Size(194, 42);
            this.btnBajaProfesor.TabIndex = 10;
            this.btnBajaProfesor.Text = "Baja Profesor";
            this.btnBajaProfesor.UseVisualStyleBackColor = false;
            this.btnBajaProfesor.Click += new System.EventHandler(this.btnBajaProfesor_Click);
            // 
            // btnModProfeosr
            // 
            this.btnModProfeosr.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModProfeosr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModProfeosr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModProfeosr.Location = new System.Drawing.Point(231, 63);
            this.btnModProfeosr.Name = "btnModProfeosr";
            this.btnModProfeosr.Size = new System.Drawing.Size(194, 42);
            this.btnModProfeosr.TabIndex = 11;
            this.btnModProfeosr.Text = "Modificacion Profesor";
            this.btnModProfeosr.UseVisualStyleBackColor = false;
            this.btnModProfeosr.Click += new System.EventHandler(this.btnModProfeosr_Click);
            // 
            // dtgProfesor
            // 
            this.dtgProfesor.AutoGenerateColumns = false;
            this.dtgProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProfesorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fechaNac,
            this.correoElecDataGridViewTextBoxColumn});
            this.dtgProfesor.DataSource = this.profesorBindingSource;
            this.dtgProfesor.Location = new System.Drawing.Point(31, 169);
            this.dtgProfesor.Name = "dtgProfesor";
            this.dtgProfesor.Size = new System.Drawing.Size(993, 423);
            this.dtgProfesor.TabIndex = 8;
            // 
            // idProfesorDataGridViewTextBoxColumn
            // 
            this.idProfesorDataGridViewTextBoxColumn.DataPropertyName = "idProfesor";
            this.idProfesorDataGridViewTextBoxColumn.HeaderText = "idProfesor";
            this.idProfesorDataGridViewTextBoxColumn.Name = "idProfesorDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Nro documento";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // fechaNac
            // 
            this.fechaNac.DataPropertyName = "fechaNac";
            this.fechaNac.HeaderText = "Fecha nacimiento";
            this.fechaNac.Name = "fechaNac";
            // 
            // correoElecDataGridViewTextBoxColumn
            // 
            this.correoElecDataGridViewTextBoxColumn.DataPropertyName = "correoElec";
            this.correoElecDataGridViewTextBoxColumn.HeaderText = "Correo Electronico";
            this.correoElecDataGridViewTextBoxColumn.Name = "correoElecDataGridViewTextBoxColumn";
            this.correoElecDataGridViewTextBoxColumn.Width = 150;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1135, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 18F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(1090, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 31);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAntiguoProfesor);
            this.panel1.Controls.Add(this.btnNuevoProfesor);
            this.panel1.Location = new System.Drawing.Point(31, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 80);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // btnAntiguoProfesor
            // 
            this.btnAntiguoProfesor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAntiguoProfesor.FlatAppearance.BorderSize = 0;
            this.btnAntiguoProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntiguoProfesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAntiguoProfesor.Location = new System.Drawing.Point(3, 43);
            this.btnAntiguoProfesor.Name = "btnAntiguoProfesor";
            this.btnAntiguoProfesor.Size = new System.Drawing.Size(186, 30);
            this.btnAntiguoProfesor.TabIndex = 13;
            this.btnAntiguoProfesor.Text = "Alta de profesor antiguo";
            this.btnAntiguoProfesor.UseVisualStyleBackColor = false;
            this.btnAntiguoProfesor.Click += new System.EventHandler(this.btnAntiguoProfesor_Click);
            // 
            // btnNuevoProfesor
            // 
            this.btnNuevoProfesor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNuevoProfesor.FlatAppearance.BorderSize = 0;
            this.btnNuevoProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProfesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoProfesor.Location = new System.Drawing.Point(3, 7);
            this.btnNuevoProfesor.Name = "btnNuevoProfesor";
            this.btnNuevoProfesor.Size = new System.Drawing.Size(186, 30);
            this.btnNuevoProfesor.TabIndex = 12;
            this.btnNuevoProfesor.Text = "Nuevo Profesor";
            this.btnNuevoProfesor.UseVisualStyleBackColor = false;
            this.btnNuevoProfesor.Click += new System.EventHandler(this.btnNuevoProfesor_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(800, 75);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(144, 20);
            this.txtBusqueda.TabIndex = 16;
            this.txtBusqueda.Tag = "Ingrese nro de documento";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(961, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRMProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1166, 701);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModProfeosr);
            this.Controls.Add(this.btnBajaProfesor);
            this.Controls.Add(this.dtgProfesor);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAltaProfesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMProfesores";
            this.Load += new System.EventHandler(this.FRMProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAltaProfesor;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.Button btnBajaProfesor;
        private System.Windows.Forms.Button btnModProfeosr;
        private System.Windows.Forms.DataGridView dtgProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElecDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAntiguoProfesor;
        private System.Windows.Forms.Button btnNuevoProfesor;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button button3;
    }
}
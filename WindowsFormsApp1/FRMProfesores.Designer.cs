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
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnAltaProfesor = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBajaProfesor = new System.Windows.Forms.Button();
            this.btnModProfeosr = new System.Windows.Forms.Button();
            this.correoElecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProfesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProfesor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(Logica.Profesor);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(1092, 91);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(81, 23);
            this.btnBusqueda.TabIndex = 7;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(980, 91);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(106, 20);
            this.txtBusqueda.TabIndex = 6;
            // 
            // btnAltaProfesor
            // 
            this.btnAltaProfesor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAltaProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProfesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaProfesor.Location = new System.Drawing.Point(31, 81);
            this.btnAltaProfesor.Name = "btnAltaProfesor";
            this.btnAltaProfesor.Size = new System.Drawing.Size(207, 42);
            this.btnAltaProfesor.TabIndex = 5;
            this.btnAltaProfesor.Text = "Alta Profesor";
            this.btnAltaProfesor.UseVisualStyleBackColor = false;
            this.btnAltaProfesor.Click += new System.EventHandler(this.btnAltaProfesor_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1102, 626);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(81, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBajaProfesor
            // 
            this.btnBajaProfesor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBajaProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaProfesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBajaProfesor.Location = new System.Drawing.Point(492, 81);
            this.btnBajaProfesor.Name = "btnBajaProfesor";
            this.btnBajaProfesor.Size = new System.Drawing.Size(207, 42);
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
            this.btnModProfeosr.Location = new System.Drawing.Point(263, 81);
            this.btnModProfeosr.Name = "btnModProfeosr";
            this.btnModProfeosr.Size = new System.Drawing.Size(207, 42);
            this.btnModProfeosr.TabIndex = 11;
            this.btnModProfeosr.Text = "Modificacion Profesor";
            this.btnModProfeosr.UseVisualStyleBackColor = false;
            this.btnModProfeosr.Click += new System.EventHandler(this.btnModProfeosr_Click);
            // 
            // correoElecDataGridViewTextBoxColumn
            // 
            this.correoElecDataGridViewTextBoxColumn.DataPropertyName = "correoElec";
            this.correoElecDataGridViewTextBoxColumn.HeaderText = "Correo Electronico";
            this.correoElecDataGridViewTextBoxColumn.Name = "correoElecDataGridViewTextBoxColumn";
            this.correoElecDataGridViewTextBoxColumn.Width = 200;
            // 
            // fechaNac
            // 
            this.fechaNac.DataPropertyName = "fechaNac";
            this.fechaNac.HeaderText = "Fecha nacimiento";
            this.fechaNac.Name = "fechaNac";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Nro documento";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 200;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // idProfesorDataGridViewTextBoxColumn
            // 
            this.idProfesorDataGridViewTextBoxColumn.DataPropertyName = "idProfesor";
            this.idProfesorDataGridViewTextBoxColumn.HeaderText = "idProfesor";
            this.idProfesorDataGridViewTextBoxColumn.Name = "idProfesorDataGridViewTextBoxColumn";
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
            this.dtgProfesor.Size = new System.Drawing.Size(1142, 423);
            this.dtgProfesor.TabIndex = 8;
            // 
            // FRMProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnModProfeosr);
            this.Controls.Add(this.btnBajaProfesor);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgProfesor);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnAltaProfesor);
            this.Name = "FRMProfesores";
            this.Text = "FRMProfesores";
            this.Load += new System.EventHandler(this.FRMProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnAltaProfesor;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBajaProfesor;
        private System.Windows.Forms.Button btnModProfeosr;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dtgProfesor;
    }
}
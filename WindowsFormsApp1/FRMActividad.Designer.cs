namespace WindowsFormsApp1
{
    partial class FRMActividad
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
            this.dtgActividad = new System.Windows.Forms.DataGridView();
            this.idActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnAltaActividad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModActividad = new System.Windows.Forms.Button();
            this.btnBajaActividad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgActividad
            // 
            this.dtgActividad.AutoGenerateColumns = false;
            this.dtgActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActividadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.profesorDataGridViewTextBoxColumn,
            this.horarioInicioDataGridViewTextBoxColumn,
            this.horarioFinDataGridViewTextBoxColumn});
            this.dtgActividad.DataSource = this.actividadBindingSource;
            this.dtgActividad.Location = new System.Drawing.Point(32, 164);
            this.dtgActividad.Name = "dtgActividad";
            this.dtgActividad.Size = new System.Drawing.Size(743, 410);
            this.dtgActividad.TabIndex = 8;
            // 
            // idActividadDataGridViewTextBoxColumn
            // 
            this.idActividadDataGridViewTextBoxColumn.DataPropertyName = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.HeaderText = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.Name = "idActividadDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // profesorDataGridViewTextBoxColumn
            // 
            this.profesorDataGridViewTextBoxColumn.DataPropertyName = "profesor";
            this.profesorDataGridViewTextBoxColumn.HeaderText = "Profesor";
            this.profesorDataGridViewTextBoxColumn.Name = "profesorDataGridViewTextBoxColumn";
            this.profesorDataGridViewTextBoxColumn.Width = 200;
            // 
            // horarioInicioDataGridViewTextBoxColumn
            // 
            this.horarioInicioDataGridViewTextBoxColumn.DataPropertyName = "horarioInicio";
            this.horarioInicioDataGridViewTextBoxColumn.HeaderText = "Inicio";
            this.horarioInicioDataGridViewTextBoxColumn.Name = "horarioInicioDataGridViewTextBoxColumn";
            // 
            // horarioFinDataGridViewTextBoxColumn
            // 
            this.horarioFinDataGridViewTextBoxColumn.DataPropertyName = "horarioFin";
            this.horarioFinDataGridViewTextBoxColumn.HeaderText = "Fin";
            this.horarioFinDataGridViewTextBoxColumn.Name = "horarioFinDataGridViewTextBoxColumn";
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataSource = typeof(Logica.Actividad);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(1108, 98);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 7;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(1002, 98);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 6;
            // 
            // btnAltaActividad
            // 
            this.btnAltaActividad.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAltaActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaActividad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaActividad.Location = new System.Drawing.Point(32, 79);
            this.btnAltaActividad.Name = "btnAltaActividad";
            this.btnAltaActividad.Size = new System.Drawing.Size(207, 42);
            this.btnAltaActividad.TabIndex = 5;
            this.btnAltaActividad.Text = "Alta Actividad";
            this.btnAltaActividad.UseVisualStyleBackColor = false;
            this.btnAltaActividad.Click += new System.EventHandler(this.btnAltaActividad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1263, 694);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModActividad
            // 
            this.btnModActividad.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModActividad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModActividad.Location = new System.Drawing.Point(262, 79);
            this.btnModActividad.Name = "btnModActividad";
            this.btnModActividad.Size = new System.Drawing.Size(207, 42);
            this.btnModActividad.TabIndex = 10;
            this.btnModActividad.Text = "Modificacion Actividad";
            this.btnModActividad.UseVisualStyleBackColor = false;
            this.btnModActividad.Click += new System.EventHandler(this.btnModActividad_Click);
            // 
            // btnBajaActividad
            // 
            this.btnBajaActividad.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBajaActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaActividad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBajaActividad.Location = new System.Drawing.Point(487, 79);
            this.btnBajaActividad.Name = "btnBajaActividad";
            this.btnBajaActividad.Size = new System.Drawing.Size(207, 42);
            this.btnBajaActividad.TabIndex = 11;
            this.btnBajaActividad.Text = "Baja Actividad";
            this.btnBajaActividad.UseVisualStyleBackColor = false;
            this.btnBajaActividad.Click += new System.EventHandler(this.btnBajaActividad_Click);
            // 
            // FRMActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnBajaActividad);
            this.Controls.Add(this.btnModActividad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgActividad);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnAltaActividad);
            this.Name = "FRMActividad";
            this.Text = "FRMActividad";
            this.Load += new System.EventHandler(this.FRMActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgActividad;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnAltaActividad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnModActividad;
        private System.Windows.Forms.Button btnBajaActividad;
    }
}
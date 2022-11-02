namespace WindowsFormsApp1
{
    partial class FRMSocio
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
            this.btnAltaSocio = new System.Windows.Forms.Button();
            this.dtgSocio = new System.Windows.Forms.DataGridView();
            this.idSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModSocio = new System.Windows.Forms.Button();
            this.btnBajaSocio = new System.Windows.Forms.Button();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAntiguoSocio = new System.Windows.Forms.Button();
            this.btnNuevoSocio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltaSocio
            // 
            this.btnAltaSocio.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAltaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaSocio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaSocio.Location = new System.Drawing.Point(44, 40);
            this.btnAltaSocio.Name = "btnAltaSocio";
            this.btnAltaSocio.Size = new System.Drawing.Size(194, 42);
            this.btnAltaSocio.TabIndex = 0;
            this.btnAltaSocio.Text = "Alta Socio";
            this.btnAltaSocio.UseVisualStyleBackColor = false;
            this.btnAltaSocio.Click += new System.EventHandler(this.btnAltaSocio_Click);
            // 
            // dtgSocio
            // 
            this.dtgSocio.AutoGenerateColumns = false;
            this.dtgSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSocio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocioDataGridViewTextBoxColumn,
            this.nombre,
            this.apellido,
            this.tipoDoc,
            this.dni,
            this.activo,
            this.telefono,
            this.fechaNac,
            this.direccion});
            this.dtgSocio.DataSource = this.socioBindingSource1;
            this.dtgSocio.Location = new System.Drawing.Point(25, 145);
            this.dtgSocio.Name = "dtgSocio";
            this.dtgSocio.Size = new System.Drawing.Size(993, 509);
            this.dtgSocio.TabIndex = 4;
            // 
            // idSocioDataGridViewTextBoxColumn
            // 
            this.idSocioDataGridViewTextBoxColumn.DataPropertyName = "idSocio";
            this.idSocioDataGridViewTextBoxColumn.HeaderText = "idSocio";
            this.idSocioDataGridViewTextBoxColumn.Name = "idSocioDataGridViewTextBoxColumn";
            this.idSocioDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 150;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.Width = 150;
            // 
            // tipoDoc
            // 
            this.tipoDoc.DataPropertyName = "tipoDoc";
            this.tipoDoc.HeaderText = "Tipo documento";
            this.tipoDoc.Name = "tipoDoc";
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "Nro documento";
            this.dni.Name = "dni";
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // fechaNac
            // 
            this.fechaNac.DataPropertyName = "fechaNac";
            this.fechaNac.HeaderText = "Fecha nacimiento";
            this.fechaNac.Name = "fechaNac";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // socioBindingSource1
            // 
            this.socioBindingSource1.DataSource = typeof(Logica.Socio);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1299, 743);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnModSocio
            // 
            this.btnModSocio.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModSocio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModSocio.Location = new System.Drawing.Point(244, 40);
            this.btnModSocio.Name = "btnModSocio";
            this.btnModSocio.Size = new System.Drawing.Size(194, 42);
            this.btnModSocio.TabIndex = 6;
            this.btnModSocio.Text = "Modificacion Socio";
            this.btnModSocio.UseVisualStyleBackColor = false;
            this.btnModSocio.Click += new System.EventHandler(this.btnModSocio_Click);
            // 
            // btnBajaSocio
            // 
            this.btnBajaSocio.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBajaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaSocio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBajaSocio.Location = new System.Drawing.Point(444, 40);
            this.btnBajaSocio.Name = "btnBajaSocio";
            this.btnBajaSocio.Size = new System.Drawing.Size(194, 42);
            this.btnBajaSocio.TabIndex = 7;
            this.btnBajaSocio.Text = "Baja Socio";
            this.btnBajaSocio.UseVisualStyleBackColor = false;
            this.btnBajaSocio.Click += new System.EventHandler(this.btnBajaSocio_Click);
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataSource = typeof(Logica.Socio);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 18F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(1094, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 31);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1043, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1130, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAntiguoSocio);
            this.panel1.Controls.Add(this.btnNuevoSocio);
            this.panel1.Location = new System.Drawing.Point(44, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 80);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // btnAntiguoSocio
            // 
            this.btnAntiguoSocio.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAntiguoSocio.FlatAppearance.BorderSize = 0;
            this.btnAntiguoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntiguoSocio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAntiguoSocio.Location = new System.Drawing.Point(3, 43);
            this.btnAntiguoSocio.Name = "btnAntiguoSocio";
            this.btnAntiguoSocio.Size = new System.Drawing.Size(186, 30);
            this.btnAntiguoSocio.TabIndex = 13;
            this.btnAntiguoSocio.Text = "Alta de socio antiguo";
            this.btnAntiguoSocio.UseVisualStyleBackColor = false;
            this.btnAntiguoSocio.Click += new System.EventHandler(this.btnAntiguoSocio_Click);
            // 
            // btnNuevoSocio
            // 
            this.btnNuevoSocio.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNuevoSocio.FlatAppearance.BorderSize = 0;
            this.btnNuevoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoSocio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoSocio.Location = new System.Drawing.Point(3, 7);
            this.btnNuevoSocio.Name = "btnNuevoSocio";
            this.btnNuevoSocio.Size = new System.Drawing.Size(186, 30);
            this.btnNuevoSocio.TabIndex = 12;
            this.btnNuevoSocio.Text = "Nuevo Socio";
            this.btnNuevoSocio.UseVisualStyleBackColor = false;
            this.btnNuevoSocio.Click += new System.EventHandler(this.btnNuevoSocio_Click);
            // 
            // FRMSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1161, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBajaSocio);
            this.Controls.Add(this.btnModSocio);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgSocio);
            this.Controls.Add(this.btnAltaSocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMSocio";
            this.Load += new System.EventHandler(this.FRMSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaSocio;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private System.Windows.Forms.BindingSource socioBindingSource1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModSocio;
        private System.Windows.Forms.Button btnBajaSocio;
        public System.Windows.Forms.DataGridView dtgSocio;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAntiguoSocio;
        private System.Windows.Forms.Button btnNuevoSocio;
    }
}
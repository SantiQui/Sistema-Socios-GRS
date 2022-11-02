namespace WindowsFormsApp1
{
    partial class FRMElemento
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.dtgElemento = new System.Windows.Forms.DataGridView();
            this.idElementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAltaElemento = new System.Windows.Forms.Button();
            this.btnBajaElemento = new System.Windows.Forms.Button();
            this.btnModElemento = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgElemento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1263, 694);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtgElemento
            // 
            this.dtgElemento.AutoGenerateColumns = false;
            this.dtgElemento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgElemento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idElementoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dtgElemento.DataSource = this.elementoBindingSource;
            this.dtgElemento.Location = new System.Drawing.Point(32, 152);
            this.dtgElemento.Name = "dtgElemento";
            this.dtgElemento.Size = new System.Drawing.Size(443, 519);
            this.dtgElemento.TabIndex = 13;
            // 
            // idElementoDataGridViewTextBoxColumn
            // 
            this.idElementoDataGridViewTextBoxColumn.DataPropertyName = "idElemento";
            this.idElementoDataGridViewTextBoxColumn.HeaderText = "idElemento";
            this.idElementoDataGridViewTextBoxColumn.Name = "idElementoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // elementoBindingSource
            // 
            this.elementoBindingSource.DataSource = typeof(Logica.Elemento);
            // 
            // btnAltaElemento
            // 
            this.btnAltaElemento.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAltaElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaElemento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaElemento.Location = new System.Drawing.Point(32, 79);
            this.btnAltaElemento.Name = "btnAltaElemento";
            this.btnAltaElemento.Size = new System.Drawing.Size(207, 42);
            this.btnAltaElemento.TabIndex = 10;
            this.btnAltaElemento.Text = "Alta Elemento ";
            this.btnAltaElemento.UseVisualStyleBackColor = false;
            this.btnAltaElemento.Click += new System.EventHandler(this.btnAltaElemento_Click);
            // 
            // btnBajaElemento
            // 
            this.btnBajaElemento.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBajaElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaElemento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBajaElemento.Location = new System.Drawing.Point(504, 79);
            this.btnBajaElemento.Name = "btnBajaElemento";
            this.btnBajaElemento.Size = new System.Drawing.Size(207, 42);
            this.btnBajaElemento.TabIndex = 15;
            this.btnBajaElemento.Text = "Baja Elemento";
            this.btnBajaElemento.UseVisualStyleBackColor = false;
            this.btnBajaElemento.Click += new System.EventHandler(this.btnBajaElemento_Click);
            // 
            // btnModElemento
            // 
            this.btnModElemento.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModElemento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModElemento.Location = new System.Drawing.Point(268, 79);
            this.btnModElemento.Name = "btnModElemento";
            this.btnModElemento.Size = new System.Drawing.Size(207, 42);
            this.btnModElemento.TabIndex = 16;
            this.btnModElemento.Text = "Modificacion Elemento";
            this.btnModElemento.UseVisualStyleBackColor = false;
            this.btnModElemento.Click += new System.EventHandler(this.btnModElemento_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(504, 152);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.button2.TabIndex = 19;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 18F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1085, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1161, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnModElemento);
            this.Controls.Add(this.btnBajaElemento);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgElemento);
            this.Controls.Add(this.btnAltaElemento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMElemento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMElemento";
            this.Load += new System.EventHandler(this.FRMElemento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgElemento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dtgElemento;
        private System.Windows.Forms.Button btnAltaElemento;
        private System.Windows.Forms.BindingSource elementoBindingSource;
        private System.Windows.Forms.Button btnBajaElemento;
        private System.Windows.Forms.Button btnModElemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idElementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
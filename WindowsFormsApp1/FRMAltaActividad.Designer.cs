namespace WindowsFormsApp1
{
    partial class FRMAltaActividad
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
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.Label();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.txtBProfesor = new System.Windows.Forms.TextBox();
            this.txtBInicio = new System.Windows.Forms.TextBox();
            this.txtBFin = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombre.Location = new System.Drawing.Point(16, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(64, 18);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            // 
            // txtProfesor
            // 
            this.txtProfesor.AutoSize = true;
            this.txtProfesor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtProfesor.Location = new System.Drawing.Point(16, 106);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(68, 18);
            this.txtProfesor.TabIndex = 1;
            this.txtProfesor.Text = "Profesor";
            // 
            // txtHorario
            // 
            this.txtHorario.AutoSize = true;
            this.txtHorario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHorario.Location = new System.Drawing.Point(16, 148);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(60, 18);
            this.txtHorario.TabIndex = 2;
            this.txtHorario.Text = "Horario";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(19, 83);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(229, 20);
            this.txtBNombre.TabIndex = 3;
            // 
            // txtBProfesor
            // 
            this.txtBProfesor.Location = new System.Drawing.Point(19, 125);
            this.txtBProfesor.Name = "txtBProfesor";
            this.txtBProfesor.Size = new System.Drawing.Size(229, 20);
            this.txtBProfesor.TabIndex = 4;
            // 
            // txtBInicio
            // 
            this.txtBInicio.Location = new System.Drawing.Point(19, 169);
            this.txtBInicio.Name = "txtBInicio";
            this.txtBInicio.Size = new System.Drawing.Size(100, 20);
            this.txtBInicio.TabIndex = 5;
            // 
            // txtBFin
            // 
            this.txtBFin.Location = new System.Drawing.Point(148, 169);
            this.txtBFin.Name = "txtBFin";
            this.txtBFin.Size = new System.Drawing.Size(100, 20);
            this.txtBFin.TabIndex = 6;
            // 
            // txtA
            // 
            this.txtA.AutoSize = true;
            this.txtA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtA.Location = new System.Drawing.Point(125, 169);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(17, 18);
            this.txtA.TabIndex = 7;
            this.txtA.Text = "a";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1064, 666);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTitulo.Location = new System.Drawing.Point(12, 9);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(235, 42);
            this.txtTitulo.TabIndex = 16;
            this.txtTitulo.Text = "Alta Actividad";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1130, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.TabIndex = 17;
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
            this.btnBack.Location = new System.Drawing.Point(1085, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 31);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FRMAltaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1161, 701);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtBFin);
            this.Controls.Add(this.txtBInicio);
            this.Controls.Add(this.txtBProfesor);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMAltaActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMActividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtProfesor;
        private System.Windows.Forms.Label txtHorario;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.TextBox txtBProfesor;
        private System.Windows.Forms.TextBox txtBInicio;
        private System.Windows.Forms.TextBox txtBFin;
        private System.Windows.Forms.Label txtA;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
    }
}
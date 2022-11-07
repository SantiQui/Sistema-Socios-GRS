namespace WindowsFormsApp1
{
    partial class FRMModSocio
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
            this.dtfechaNac = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBTipoDoc = new System.Windows.Forms.TextBox();
            this.chckBActivo = new System.Windows.Forms.CheckBox();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBDireccion = new System.Windows.Forms.TextBox();
            this.txtBNroDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBCelular = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtfechaNac
            // 
            this.dtfechaNac.Location = new System.Drawing.Point(18, 313);
            this.dtfechaNac.Name = "dtfechaNac";
            this.dtfechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtfechaNac.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 42);
            this.label4.TabIndex = 49;
            this.label4.Text = "Modificacion Socio";
            // 
            // txtBTipoDoc
            // 
            this.txtBTipoDoc.Location = new System.Drawing.Point(19, 222);
            this.txtBTipoDoc.Name = "txtBTipoDoc";
            this.txtBTipoDoc.Size = new System.Drawing.Size(116, 20);
            this.txtBTipoDoc.TabIndex = 48;
            // 
            // chckBActivo
            // 
            this.chckBActivo.AutoSize = true;
            this.chckBActivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chckBActivo.Location = new System.Drawing.Point(206, 355);
            this.chckBActivo.Name = "chckBActivo";
            this.chckBActivo.Size = new System.Drawing.Size(70, 22);
            this.chckBActivo.TabIndex = 47;
            this.chckBActivo.Text = "Activo";
            this.chckBActivo.UseVisualStyleBackColor = true;
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(19, 132);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(272, 20);
            this.txtBNombre.TabIndex = 36;
            this.txtBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Apellido";
            // 
            // txtBApellido
            // 
            this.txtBApellido.Location = new System.Drawing.Point(19, 178);
            this.txtBApellido.Name = "txtBApellido";
            this.txtBApellido.Size = new System.Drawing.Size(272, 20);
            this.txtBApellido.TabIndex = 37;
            this.txtBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBApellido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 111);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre";
            // 
            // txtBDireccion
            // 
            this.txtBDireccion.Location = new System.Drawing.Point(19, 357);
            this.txtBDireccion.Name = "txtBDireccion";
            this.txtBDireccion.Size = new System.Drawing.Size(167, 20);
            this.txtBDireccion.TabIndex = 40;
            // 
            // txtBNroDoc
            // 
            this.txtBNroDoc.Location = new System.Drawing.Point(153, 222);
            this.txtBNroDoc.Name = "txtBNroDoc";
            this.txtBNroDoc.Size = new System.Drawing.Size(138, 20);
            this.txtBNroDoc.TabIndex = 38;
            this.txtBNroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBNroDoc_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tipo y numero de documento ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(16, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(16, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Telefono/Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // txtBCelular
            // 
            this.txtBCelular.Location = new System.Drawing.Point(19, 269);
            this.txtBCelular.Name = "txtBCelular";
            this.txtBCelular.Size = new System.Drawing.Size(116, 20);
            this.txtBCelular.TabIndex = 39;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1058, 666);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 23);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(18, 67);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 51;
            this.label8.Text = "Numero de ID";
            // 
            // txtBID
            // 
            this.txtBID.Enabled = false;
            this.txtBID.Location = new System.Drawing.Point(19, 88);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(72, 20);
            this.txtBID.TabIndex = 52;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1132, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.TabIndex = 53;
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
            this.btnBack.Location = new System.Drawing.Point(1087, -2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 31);
            this.btnBack.TabIndex = 54;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FRMModSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1161, 701);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtfechaNac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBTipoDoc);
            this.Controls.Add(this.chckBActivo);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBDireccion);
            this.Controls.Add(this.txtBNroDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBCelular);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMModSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMModSocio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtBID;
        public System.Windows.Forms.DateTimePicker dtfechaNac;
        public System.Windows.Forms.TextBox txtBTipoDoc;
        public System.Windows.Forms.CheckBox chckBActivo;
        public System.Windows.Forms.TextBox txtBNombre;
        public System.Windows.Forms.TextBox txtBApellido;
        public System.Windows.Forms.TextBox txtBDireccion;
        public System.Windows.Forms.TextBox txtBNroDoc;
        public System.Windows.Forms.TextBox txtBCelular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
    }
}
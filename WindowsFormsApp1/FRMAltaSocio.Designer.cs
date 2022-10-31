namespace WindowsFormsApp1
{
    partial class FRMAltaSocio
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtfechaNac = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1092, 626);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(995, 626);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBTipoDoc
            // 
            this.txtBTipoDoc.Location = new System.Drawing.Point(483, 345);
            this.txtBTipoDoc.Name = "txtBTipoDoc";
            this.txtBTipoDoc.Size = new System.Drawing.Size(116, 20);
            this.txtBTipoDoc.TabIndex = 31;
            // 
            // chckBActivo
            // 
            this.chckBActivo.AutoSize = true;
            this.chckBActivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chckBActivo.Location = new System.Drawing.Point(670, 478);
            this.chckBActivo.Name = "chckBActivo";
            this.chckBActivo.Size = new System.Drawing.Size(70, 22);
            this.chckBActivo.TabIndex = 30;
            this.chckBActivo.Text = "Activo";
            this.chckBActivo.UseVisualStyleBackColor = true;
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(483, 255);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(272, 20);
            this.txtBNombre.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(479, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Apellido";
            // 
            // txtBApellido
            // 
            this.txtBApellido.Location = new System.Drawing.Point(483, 301);
            this.txtBApellido.Name = "txtBApellido";
            this.txtBApellido.Size = new System.Drawing.Size(272, 20);
            this.txtBApellido.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(483, 234);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre";
            // 
            // txtBDireccion
            // 
            this.txtBDireccion.Location = new System.Drawing.Point(483, 480);
            this.txtBDireccion.Name = "txtBDireccion";
            this.txtBDireccion.Size = new System.Drawing.Size(167, 20);
            this.txtBDireccion.TabIndex = 23;
            // 
            // txtBNroDoc
            // 
            this.txtBNroDoc.Location = new System.Drawing.Point(617, 345);
            this.txtBNroDoc.Name = "txtBNroDoc";
            this.txtBNroDoc.Size = new System.Drawing.Size(138, 20);
            this.txtBNroDoc.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(480, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo y numero de documento ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(480, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(480, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefono/Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(480, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // txtBCelular
            // 
            this.txtBCelular.Location = new System.Drawing.Point(483, 392);
            this.txtBCelular.Name = "txtBCelular";
            this.txtBCelular.Size = new System.Drawing.Size(116, 20);
            this.txtBCelular.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(539, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 42);
            this.label4.TabIndex = 32;
            this.label4.Text = "Alta Socio";
            // 
            // dtfechaNac
            // 
            this.dtfechaNac.Location = new System.Drawing.Point(482, 436);
            this.dtfechaNac.Name = "dtfechaNac";
            this.dtfechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtfechaNac.TabIndex = 33;
            // 
            // FRMAltaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 661);
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
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FRMAltaSocio";
            this.Text = "Modificar Socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBTipoDoc;
        private System.Windows.Forms.CheckBox chckBActivo;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBDireccion;
        private System.Windows.Forms.TextBox txtBNroDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtfechaNac;
    }
}
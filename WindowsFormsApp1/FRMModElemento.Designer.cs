namespace WindowsFormsApp1
{
    partial class FRMModElemento
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
            this.txtTitulo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.txtBCantidad = new System.Windows.Forms.TextBox();
            this.txtBId = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTitulo.Location = new System.Drawing.Point(12, 9);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(387, 42);
            this.txtTitulo.TabIndex = 24;
            this.txtTitulo.Text = "Modificacion Elemento";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Location = new System.Drawing.Point(15, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(108, 20);
            this.txtID.TabIndex = 23;
            this.txtID.Text = "Numero de ID";
            // 
            // txtBCantidad
            // 
            this.txtBCantidad.Location = new System.Drawing.Point(19, 183);
            this.txtBCantidad.Name = "txtBCantidad";
            this.txtBCantidad.Size = new System.Drawing.Size(122, 20);
            this.txtBCantidad.TabIndex = 21;
            this.txtBCantidad.TextChanged += new System.EventHandler(this.txtBCantidad_TextChanged);
            this.txtBCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBCantidad_KeyPress);
            // 
            // txtBId
            // 
            this.txtBId.Location = new System.Drawing.Point(19, 91);
            this.txtBId.Name = "txtBId";
            this.txtBId.Size = new System.Drawing.Size(61, 20);
            this.txtBId.TabIndex = 22;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCantidad.Location = new System.Drawing.Point(15, 160);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(73, 20);
            this.txtCantidad.TabIndex = 19;
            this.txtCantidad.Text = "Cantidad";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNombre.Location = new System.Drawing.Point(15, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(65, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.Text = "Nombre";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(19, 137);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(218, 20);
            this.txtBNombre.TabIndex = 20;
            this.txtBNombre.TextChanged += new System.EventHandler(this.txtBNombre_TextChanged);
            this.txtBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBNombre_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1059, 666);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.button2.TabIndex = 25;
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
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FRMModElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1161, 701);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtBCantidad);
            this.Controls.Add(this.txtBId);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMModElemento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMModElemento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label txtID;
        public System.Windows.Forms.TextBox txtBCantidad;
        public System.Windows.Forms.TextBox txtBId;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.Label txtNombre;
        public System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
    }
}
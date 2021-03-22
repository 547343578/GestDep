namespace GestDep.GUI.Forms
{
    partial class InscribirEnActividad
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
            this.comboBoxActividades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.inscribirButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelRetirado = new System.Windows.Forms.Label();
            this.añadirUsrButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxActividades
            // 
            this.comboBoxActividades.FormattingEnabled = true;
            this.comboBoxActividades.Location = new System.Drawing.Point(143, 87);
            this.comboBoxActividades.Name = "comboBoxActividades";
            this.comboBoxActividades.Size = new System.Drawing.Size(121, 24);
            this.comboBoxActividades.TabIndex = 0;
            this.comboBoxActividades.SelectedIndexChanged += new System.EventHandler(this.comboBoxActividades_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI Usuario";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(143, 158);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(121, 22);
            this.textBoxDNI.TabIndex = 3;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(210)))));
            this.pictureBox1.Location = new System.Drawing.Point(228, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 99);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(210)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio de la cuota";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(210)))));
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(290, 314);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPrecio.Size = new System.Drawing.Size(92, 32);
            this.labelPrecio.TabIndex = 9;
            this.labelPrecio.Text = "00.00";
            // 
            // inscribirButton
            // 
            this.inscribirButton.Location = new System.Drawing.Point(41, 399);
            this.inscribirButton.Name = "inscribirButton";
            this.inscribirButton.Size = new System.Drawing.Size(165, 47);
            this.inscribirButton.TabIndex = 10;
            this.inscribirButton.Text = "Inscribir";
            this.inscribirButton.UseVisualStyleBackColor = true;
            this.inscribirButton.Click += new System.EventHandler(this.inscribirButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(486, 399);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(165, 47);
            this.cancelarButton.TabIndex = 11;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Código postal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha de nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Retirado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(210)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(372, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 32);
            this.label11.TabIndex = 18;
            this.label11.Text = "€";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(516, 58);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(0, 17);
            this.labelNombre.TabIndex = 19;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(516, 90);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(0, 17);
            this.labelDireccion.TabIndex = 20;
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Location = new System.Drawing.Point(516, 119);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(0, 17);
            this.labelCodigoPostal.TabIndex = 21;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(516, 151);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(0, 17);
            this.labelFechaNacimiento.TabIndex = 22;
            // 
            // labelRetirado
            // 
            this.labelRetirado.AutoSize = true;
            this.labelRetirado.Location = new System.Drawing.Point(516, 180);
            this.labelRetirado.Name = "labelRetirado";
            this.labelRetirado.Size = new System.Drawing.Size(0, 17);
            this.labelRetirado.TabIndex = 23;
            // 
            // añadirUsrButton
            // 
            this.añadirUsrButton.Enabled = false;
            this.añadirUsrButton.Location = new System.Drawing.Point(263, 399);
            this.añadirUsrButton.Name = "añadirUsrButton";
            this.añadirUsrButton.Size = new System.Drawing.Size(165, 47);
            this.añadirUsrButton.TabIndex = 24;
            this.añadirUsrButton.Text = "Añadir usuario";
            this.añadirUsrButton.UseVisualStyleBackColor = true;
            this.añadirUsrButton.Click += new System.EventHandler(this.añadirUsrButton_Click);
            // 
            // InscribirEnActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 471);
            this.Controls.Add(this.añadirUsrButton);
            this.Controls.Add(this.labelRetirado);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.labelCodigoPostal);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.inscribirButton);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxActividades);
            this.Name = "InscribirEnActividad";
            this.Text = "Inscribir usuario en actividad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxActividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button inscribirButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelRetirado;
        private System.Windows.Forms.Button añadirUsrButton;
    }
}
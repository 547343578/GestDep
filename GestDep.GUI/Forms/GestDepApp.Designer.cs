namespace GestDep.GUI
{
    partial class GestDepApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAñadirAct = new System.Windows.Forms.Button();
            this.buttonAñadirUsr = new System.Windows.Forms.Button();
            this.buttonSalasLibres = new System.Windows.Forms.Button();
            this.buttonInscribirUsr = new System.Windows.Forms.Button();
            this.buttonAñadirMon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAñadirAct
            // 
            this.buttonAñadirAct.Location = new System.Drawing.Point(42, 34);
            this.buttonAñadirAct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonAñadirAct.Name = "buttonAñadirAct";
            this.buttonAñadirAct.Size = new System.Drawing.Size(300, 50);
            this.buttonAñadirAct.TabIndex = 0;
            this.buttonAñadirAct.Text = "Añadir Actividad";
            this.buttonAñadirAct.UseVisualStyleBackColor = true;
            this.buttonAñadirAct.Click += new System.EventHandler(this.añadirActividad);
            // 
            // buttonAñadirUsr
            // 
            this.buttonAñadirUsr.Location = new System.Drawing.Point(39, 291);
            this.buttonAñadirUsr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonAñadirUsr.Name = "buttonAñadirUsr";
            this.buttonAñadirUsr.Size = new System.Drawing.Size(302, 48);
            this.buttonAñadirUsr.TabIndex = 1;
            this.buttonAñadirUsr.Text = "Añadir Usuario";
            this.buttonAñadirUsr.UseVisualStyleBackColor = true;
            this.buttonAñadirUsr.Click += new System.EventHandler(this.añadirUsuario);
            // 
            // buttonSalasLibres
            // 
            this.buttonSalasLibres.Location = new System.Drawing.Point(40, 373);
            this.buttonSalasLibres.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonSalasLibres.Name = "buttonSalasLibres";
            this.buttonSalasLibres.Size = new System.Drawing.Size(302, 48);
            this.buttonSalasLibres.TabIndex = 2;
            this.buttonSalasLibres.Text = "Salas Libres";
            this.buttonSalasLibres.UseVisualStyleBackColor = true;
            this.buttonSalasLibres.Click += new System.EventHandler(this.salasLibres);
            // 
            // buttonInscribirUsr
            // 
            this.buttonInscribirUsr.Location = new System.Drawing.Point(40, 208);
            this.buttonInscribirUsr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonInscribirUsr.Name = "buttonInscribirUsr";
            this.buttonInscribirUsr.Size = new System.Drawing.Size(302, 48);
            this.buttonInscribirUsr.TabIndex = 3;
            this.buttonInscribirUsr.Text = "Inscribir Usuario";
            this.buttonInscribirUsr.UseVisualStyleBackColor = true;
            this.buttonInscribirUsr.Click += new System.EventHandler(this.inscribirUsuario);
            // 
            // buttonAñadirMon
            // 
            this.buttonAñadirMon.Location = new System.Drawing.Point(40, 121);
            this.buttonAñadirMon.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonAñadirMon.Name = "buttonAñadirMon";
            this.buttonAñadirMon.Size = new System.Drawing.Size(302, 48);
            this.buttonAñadirMon.TabIndex = 4;
            this.buttonAñadirMon.Text = "Añadir Monitor";
            this.buttonAñadirMon.UseVisualStyleBackColor = true;
            this.buttonAñadirMon.Click += new System.EventHandler(this.añadirMonitor);
            // 
            // GestDepApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(396, 462);
            this.Controls.Add(this.buttonAñadirMon);
            this.Controls.Add(this.buttonInscribirUsr);
            this.Controls.Add(this.buttonSalasLibres);
            this.Controls.Add(this.buttonAñadirUsr);
            this.Controls.Add(this.buttonAñadirAct);
            this.Location = new System.Drawing.Point(1500, 1500);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(566, 662);
            this.MinimumSize = new System.Drawing.Size(412, 501);
            this.Name = "GestDepApp";
            this.Text = "GestDepApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAñadirAct;
        private System.Windows.Forms.Button buttonAñadirUsr;
        private System.Windows.Forms.Button buttonSalasLibres;
        private System.Windows.Forms.Button buttonInscribirUsr;
        private System.Windows.Forms.Button buttonAñadirMon;
    }
}



namespace GestDep.GUI.Forms
{
    partial class SelectMonitor
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
            this.monitorCombox = new System.Windows.Forms.ComboBox();
            this.Monitor = new System.Windows.Forms.Label();
            this.Confirmar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monitorCombox
            // 
            this.monitorCombox.FormattingEnabled = true;
            this.monitorCombox.Location = new System.Drawing.Point(161, 106);
            this.monitorCombox.Name = "monitorCombox";
            this.monitorCombox.Size = new System.Drawing.Size(121, 23);
            this.monitorCombox.TabIndex = 0;
            this.monitorCombox.SelectedIndexChanged += new System.EventHandler(this.monitorCombox_SelectedIndexChanged);
            // 
            // Monitor
            // 
            this.Monitor.AutoSize = true;
            this.Monitor.Location = new System.Drawing.Point(72, 106);
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(63, 15);
            this.Monitor.TabIndex = 1;
            this.Monitor.Text = "Monitor";
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(182, 203);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(100, 32);
            this.Confirmar.TabIndex = 2;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(288, 203);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(101, 32);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // SelectMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 244);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.Monitor);
            this.Controls.Add(this.monitorCombox);
            this.Name = "SelectMonitor";
            this.Text = "SelectMonitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox monitorCombox;
        private System.Windows.Forms.Label Monitor;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Button Cancelar;
    }
}

namespace GestDep.GUI.Forms
{
    partial class AñadirMonitor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Día = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinEnrollments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxEnrollments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddMonitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityCombox = new System.Windows.Forms.ComboBox();
            this.activityLabel = new System.Windows.Forms.Label();
            this.AddMonitor = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Confirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddMonitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Día,
            this.Nombre,
            this.Duracion,
            this.FechaInicio,
            this.FechaFin,
            this.HoraInicio,
            this.MinEnrollments,
            this.MaxEnrollments,
            this.Precio,
            this.Monitor});
            this.dataGridView1.DataSource = this.AddMonitorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1263, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // Día
            // 
            this.Día.DataPropertyName = "ds_day";
            this.Día.HeaderText = "Día";
            this.Día.MinimumWidth = 6;
            this.Día.Name = "Día";
            this.Día.ReadOnly = true;
            this.Día.Width = 75;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "ds_name";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 75;
            // 
            // Duracion
            // 
            this.Duracion.DataPropertyName = "ds_duration";
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.MinimumWidth = 6;
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            this.Duracion.Width = 75;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "ds_iniDate";
            this.FechaInicio.HeaderText = "Fecha de inicio";
            this.FechaInicio.MinimumWidth = 6;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 125;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "ds_finDate";
            this.FechaFin.HeaderText = "Fecha de finalizacion";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 125;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "ds_iniTime";
            this.HoraInicio.HeaderText = "Hora de inicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Width = 125;
            // 
            // MinEnrollments
            // 
            this.MinEnrollments.DataPropertyName = "ds_min";
            this.MinEnrollments.HeaderText = "Minimo de asistentes";
            this.MinEnrollments.MinimumWidth = 6;
            this.MinEnrollments.Name = "MinEnrollments";
            this.MinEnrollments.ReadOnly = true;
            this.MinEnrollments.Width = 75;
            // 
            // MaxEnrollments
            // 
            this.MaxEnrollments.DataPropertyName = "ds_max";
            this.MaxEnrollments.HeaderText = "Maximo de asistentes";
            this.MaxEnrollments.MinimumWidth = 6;
            this.MaxEnrollments.Name = "MaxEnrollments";
            this.MaxEnrollments.ReadOnly = true;
            this.MaxEnrollments.Width = 75;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "ds_precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 75;
            // 
            // Monitor
            // 
            this.Monitor.DataPropertyName = "ds_monitor";
            this.Monitor.HeaderText = "Monitor";
            this.Monitor.MinimumWidth = 6;
            this.Monitor.Name = "Monitor";
            this.Monitor.ReadOnly = true;
            this.Monitor.Width = 75;
            // 
            // activityCombox
            // 
            this.activityCombox.FormattingEnabled = true;
            this.activityCombox.Location = new System.Drawing.Point(105, 32);
            this.activityCombox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activityCombox.Name = "activityCombox";
            this.activityCombox.Size = new System.Drawing.Size(121, 24);
            this.activityCombox.TabIndex = 1;
            this.activityCombox.SelectedIndexChanged += new System.EventHandler(this.activityCombox_SelectedIndexChanged);
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Location = new System.Drawing.Point(36, 36);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(65, 17);
            this.activityLabel.TabIndex = 2;
            this.activityLabel.Text = "Actividad";
            // 
            // AddMonitor
            // 
            this.AddMonitor.Location = new System.Drawing.Point(36, 321);
            this.AddMonitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddMonitor.Name = "AddMonitor";
            this.AddMonitor.Size = new System.Drawing.Size(165, 48);
            this.AddMonitor.TabIndex = 3;
            this.AddMonitor.Text = "Añadir monitor";
            this.AddMonitor.UseVisualStyleBackColor = true;
            this.AddMonitor.Click += new System.EventHandler(this.AddMonitor_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(1133, 321);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(165, 48);
            this.Cancelar.TabIndex = 4;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(940, 321);
            this.Confirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(165, 48);
            this.Confirmar.TabIndex = 5;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // AñadirMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 420);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.AddMonitor);
            this.Controls.Add(this.activityLabel);
            this.Controls.Add(this.activityCombox);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AñadirMonitor";
            this.Text = "Añadir monitor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddMonitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource AddMonitorBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox activityCombox;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.Button AddMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Día;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinEnrollments;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxEnrollments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monitor;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Confirmar;
    }
}
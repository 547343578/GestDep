namespace GestDep.GUI.Forms
{
    partial class Salas
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMostrarSalas = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.GymComboBox = new System.Windows.Forms.ComboBox();
            this.GymName = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione fecha:";
            // 
            // buttonMostrarSalas
            // 
            this.buttonMostrarSalas.Location = new System.Drawing.Point(315, 78);
            this.buttonMostrarSalas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMostrarSalas.Name = "buttonMostrarSalas";
            this.buttonMostrarSalas.Size = new System.Drawing.Size(143, 32);
            this.buttonMostrarSalas.TabIndex = 2;
            this.buttonMostrarSalas.Text = "Mostrar";
            this.buttonMostrarSalas.UseVisualStyleBackColor = true;
            this.buttonMostrarSalas.Click += new System.EventHandler(this.buttonMostrarSalas_Click);
            // 
            // tabla
            // 
            this.tabla.AutoGenerateColumns = false;
            this.tabla.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.Lunes,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes,
            this.Sabado});
            this.tabla.DataSource = this.bindingSource1;
            this.tabla.Location = new System.Drawing.Point(12, 251);
            this.tabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersWidth = 102;
            this.tabla.RowTemplate.Height = 40;
            this.tabla.Size = new System.Drawing.Size(1153, 399);
            this.tabla.TabIndex = 3;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellContentClick);
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.MinimumWidth = 6;
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Width = 125;
            // 
            // Lunes
            // 
            this.Lunes.DataPropertyName = "Lunes";
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.MinimumWidth = 10;
            this.Lunes.Name = "Lunes";
            this.Lunes.ReadOnly = true;
            this.Lunes.Width = 110;
            // 
            // Martes
            // 
            this.Martes.DataPropertyName = "Martes";
            this.Martes.HeaderText = "Martes";
            this.Martes.MinimumWidth = 12;
            this.Martes.Name = "Martes";
            this.Martes.ReadOnly = true;
            this.Martes.Width = 110;
            // 
            // Miercoles
            // 
            this.Miercoles.DataPropertyName = "Miercoles";
            this.Miercoles.HeaderText = "Miercoles";
            this.Miercoles.MinimumWidth = 12;
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.ReadOnly = true;
            this.Miercoles.Width = 110;
            // 
            // Jueves
            // 
            this.Jueves.DataPropertyName = "Jueves";
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.MinimumWidth = 12;
            this.Jueves.Name = "Jueves";
            this.Jueves.ReadOnly = true;
            this.Jueves.Width = 110;
            // 
            // Viernes
            // 
            this.Viernes.DataPropertyName = "Viernes";
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.MinimumWidth = 12;
            this.Viernes.Name = "Viernes";
            this.Viernes.ReadOnly = true;
            this.Viernes.Width = 110;
            // 
            // Sabado
            // 
            this.Sabado.DataPropertyName = "Sabado";
            this.Sabado.HeaderText = "Sabado";
            this.Sabado.MinimumWidth = 12;
            this.Sabado.Name = "Sabado";
            this.Sabado.ReadOnly = true;
            this.Sabado.Width = 110;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 667);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Botoncancelar);
            // 
            // GymComboBox
            // 
            this.GymComboBox.FormattingEnabled = true;
            this.GymComboBox.Location = new System.Drawing.Point(315, 33);
            this.GymComboBox.Name = "GymComboBox";
            this.GymComboBox.Size = new System.Drawing.Size(143, 23);
            this.GymComboBox.TabIndex = 5;
            this.GymComboBox.SelectedIndexChanged += new System.EventHandler(this.GymComboBox_SelectedIndexChanged);
            // 
            // GymName
            // 
            this.GymName.AutoSize = true;
            this.GymName.Location = new System.Drawing.Point(312, 9);
            this.GymName.Name = "GymName";
            this.GymName.Size = new System.Drawing.Size(31, 15);
            this.GymName.TabIndex = 6;
            this.GymName.Text = "Gym";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(12, 33);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 7;
            // 
            // Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1176, 710);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.GymName);
            this.Controls.Add(this.GymComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.buttonMostrarSalas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Salas";
            this.Text = "Salas Disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMostrarSalas;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox GymComboBox;
        private System.Windows.Forms.Label GymName;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabado;
    }
}
namespace GestDep.GUI.Forms
{
    partial class AñadirAct
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
            this.fechaInicio = new System.Windows.Forms.Label();
            this.fechaFinalizacion = new System.Windows.Forms.Label();
            this.horaInicio = new System.Windows.Forms.Label();
            this.dias = new System.Windows.Forms.Label();
            this.diasLMXJVSD = new System.Windows.Forms.Label();
            this.minimoAsistentes = new System.Windows.Forms.Label();
            this.maximoAsistentes = new System.Windows.Forms.Label();
            this.duracion = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fechaInicioDia = new System.Windows.Forms.TextBox();
            this.fechaInicioMes = new System.Windows.Forms.TextBox();
            this.fechaInicioAño = new System.Windows.Forms.TextBox();
            this.fechaFinDia = new System.Windows.Forms.TextBox();
            this.fechaFinMes = new System.Windows.Forms.TextBox();
            this.fechaFinAño = new System.Windows.Forms.TextBox();
            this.lunes = new System.Windows.Forms.CheckBox();
            this.martes = new System.Windows.Forms.CheckBox();
            this.miercoles = new System.Windows.Forms.CheckBox();
            this.jueves = new System.Windows.Forms.CheckBox();
            this.viernes = new System.Windows.Forms.CheckBox();
            this.sabado = new System.Windows.Forms.CheckBox();
            this.domingo = new System.Windows.Forms.CheckBox();
            this.horaInicioText = new System.Windows.Forms.TextBox();
            this.duracionText = new System.Windows.Forms.TextBox();
            this.minimoText = new System.Windows.Forms.TextBox();
            this.maximoText = new System.Windows.Forms.TextBox();
            this.precioText = new System.Windows.Forms.TextBox();
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.botonAñadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.salasText = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSize = true;
            this.fechaInicio.Location = new System.Drawing.Point(39, 40);
            this.fechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(82, 13);
            this.fechaInicio.TabIndex = 0;
            this.fechaInicio.Text = "Fecha de inicio:";
            // 
            // fechaFinalizacion
            // 
            this.fechaFinalizacion.AutoSize = true;
            this.fechaFinalizacion.Location = new System.Drawing.Point(39, 68);
            this.fechaFinalizacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fechaFinalizacion.Name = "fechaFinalizacion";
            this.fechaFinalizacion.Size = new System.Drawing.Size(110, 13);
            this.fechaFinalizacion.TabIndex = 1;
            this.fechaFinalizacion.Text = "Fecha de finalización:";
            // 
            // horaInicio
            // 
            this.horaInicio.AutoSize = true;
            this.horaInicio.Location = new System.Drawing.Point(39, 147);
            this.horaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.Size = new System.Drawing.Size(115, 13);
            this.horaInicio.TabIndex = 2;
            this.horaInicio.Text = "Hora de inicio (hh:mm):";
            // 
            // dias
            // 
            this.dias.AutoSize = true;
            this.dias.Location = new System.Drawing.Point(39, 115);
            this.dias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dias.Name = "dias";
            this.dias.Size = new System.Drawing.Size(33, 13);
            this.dias.TabIndex = 3;
            this.dias.Text = "Días:";
            // 
            // diasLMXJVSD
            // 
            this.diasLMXJVSD.AutoSize = true;
            this.diasLMXJVSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diasLMXJVSD.Location = new System.Drawing.Point(158, 100);
            this.diasLMXJVSD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diasLMXJVSD.Name = "diasLMXJVSD";
            this.diasLMXJVSD.Size = new System.Drawing.Size(10, 13);
            this.diasLMXJVSD.TabIndex = 4;
            this.diasLMXJVSD.Text = " ";
            // 
            // minimoAsistentes
            // 
            this.minimoAsistentes.AutoSize = true;
            this.minimoAsistentes.Location = new System.Drawing.Point(39, 205);
            this.minimoAsistentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minimoAsistentes.Name = "minimoAsistentes";
            this.minimoAsistentes.Size = new System.Drawing.Size(113, 13);
            this.minimoAsistentes.TabIndex = 5;
            this.minimoAsistentes.Text = "Mínimo de asistentes: ";
            // 
            // maximoAsistentes
            // 
            this.maximoAsistentes.AutoSize = true;
            this.maximoAsistentes.Location = new System.Drawing.Point(39, 234);
            this.maximoAsistentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maximoAsistentes.Name = "maximoAsistentes";
            this.maximoAsistentes.Size = new System.Drawing.Size(114, 13);
            this.maximoAsistentes.TabIndex = 6;
            this.maximoAsistentes.Text = "Máximo de asistentes: ";
            // 
            // duracion
            // 
            this.duracion.AutoSize = true;
            this.duracion.Location = new System.Drawing.Point(39, 176);
            this.duracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.duracion.Name = "duracion";
            this.duracion.Size = new System.Drawing.Size(81, 13);
            this.duracion.TabIndex = 7;
            this.duracion.Text = "Duración (min): ";
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(39, 292);
            this.descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(66, 13);
            this.descripcion.TabIndex = 8;
            this.descripcion.Text = "Descripción:";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(39, 263);
            this.precio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(55, 13);
            this.precio.TabIndex = 9;
            this.precio.Text = "Precio (€):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(160, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "dia        mes        año";
            // 
            // fechaInicioDia
            // 
            this.fechaInicioDia.Location = new System.Drawing.Point(159, 37);
            this.fechaInicioDia.Margin = new System.Windows.Forms.Padding(2);
            this.fechaInicioDia.Name = "fechaInicioDia";
            this.fechaInicioDia.Size = new System.Drawing.Size(26, 20);
            this.fechaInicioDia.TabIndex = 11;
            // 
            // fechaInicioMes
            // 
            this.fechaInicioMes.Location = new System.Drawing.Point(196, 37);
            this.fechaInicioMes.Margin = new System.Windows.Forms.Padding(2);
            this.fechaInicioMes.Name = "fechaInicioMes";
            this.fechaInicioMes.Size = new System.Drawing.Size(26, 20);
            this.fechaInicioMes.TabIndex = 12;
            // 
            // fechaInicioAño
            // 
            this.fechaInicioAño.Location = new System.Drawing.Point(233, 37);
            this.fechaInicioAño.Margin = new System.Windows.Forms.Padding(2);
            this.fechaInicioAño.Name = "fechaInicioAño";
            this.fechaInicioAño.Size = new System.Drawing.Size(38, 20);
            this.fechaInicioAño.TabIndex = 13;
            // 
            // fechaFinDia
            // 
            this.fechaFinDia.Location = new System.Drawing.Point(159, 66);
            this.fechaFinDia.Margin = new System.Windows.Forms.Padding(2);
            this.fechaFinDia.Name = "fechaFinDia";
            this.fechaFinDia.Size = new System.Drawing.Size(26, 20);
            this.fechaFinDia.TabIndex = 14;
            // 
            // fechaFinMes
            // 
            this.fechaFinMes.Location = new System.Drawing.Point(196, 66);
            this.fechaFinMes.Margin = new System.Windows.Forms.Padding(2);
            this.fechaFinMes.Name = "fechaFinMes";
            this.fechaFinMes.Size = new System.Drawing.Size(26, 20);
            this.fechaFinMes.TabIndex = 15;
            // 
            // fechaFinAño
            // 
            this.fechaFinAño.Location = new System.Drawing.Point(233, 66);
            this.fechaFinAño.Margin = new System.Windows.Forms.Padding(2);
            this.fechaFinAño.Name = "fechaFinAño";
            this.fechaFinAño.Size = new System.Drawing.Size(38, 20);
            this.fechaFinAño.TabIndex = 16;
            // 
            // lunes
            // 
            this.lunes.AutoSize = true;
            this.lunes.Location = new System.Drawing.Point(159, 115);
            this.lunes.Margin = new System.Windows.Forms.Padding(2);
            this.lunes.Name = "lunes";
            this.lunes.Size = new System.Drawing.Size(15, 14);
            this.lunes.TabIndex = 17;
            this.lunes.UseVisualStyleBackColor = true;
            // 
            // martes
            // 
            this.martes.AutoSize = true;
            this.martes.Location = new System.Drawing.Point(181, 115);
            this.martes.Margin = new System.Windows.Forms.Padding(2);
            this.martes.Name = "martes";
            this.martes.Size = new System.Drawing.Size(15, 14);
            this.martes.TabIndex = 18;
            this.martes.UseVisualStyleBackColor = true;
            // 
            // miercoles
            // 
            this.miercoles.AutoSize = true;
            this.miercoles.Location = new System.Drawing.Point(203, 115);
            this.miercoles.Margin = new System.Windows.Forms.Padding(2);
            this.miercoles.Name = "miercoles";
            this.miercoles.Size = new System.Drawing.Size(15, 14);
            this.miercoles.TabIndex = 19;
            this.miercoles.UseVisualStyleBackColor = true;
            // 
            // jueves
            // 
            this.jueves.AutoSize = true;
            this.jueves.Location = new System.Drawing.Point(225, 115);
            this.jueves.Margin = new System.Windows.Forms.Padding(2);
            this.jueves.Name = "jueves";
            this.jueves.Size = new System.Drawing.Size(15, 14);
            this.jueves.TabIndex = 20;
            this.jueves.UseVisualStyleBackColor = true;
            // 
            // viernes
            // 
            this.viernes.AutoSize = true;
            this.viernes.Location = new System.Drawing.Point(247, 115);
            this.viernes.Margin = new System.Windows.Forms.Padding(2);
            this.viernes.Name = "viernes";
            this.viernes.Size = new System.Drawing.Size(15, 14);
            this.viernes.TabIndex = 21;
            this.viernes.UseVisualStyleBackColor = true;
            // 
            // sabado
            // 
            this.sabado.AutoSize = true;
            this.sabado.Location = new System.Drawing.Point(269, 115);
            this.sabado.Margin = new System.Windows.Forms.Padding(2);
            this.sabado.Name = "sabado";
            this.sabado.Size = new System.Drawing.Size(15, 14);
            this.sabado.TabIndex = 22;
            this.sabado.UseVisualStyleBackColor = true;
            // 
            // domingo
            // 
            this.domingo.AutoSize = true;
            this.domingo.Location = new System.Drawing.Point(291, 115);
            this.domingo.Margin = new System.Windows.Forms.Padding(2);
            this.domingo.Name = "domingo";
            this.domingo.Size = new System.Drawing.Size(15, 14);
            this.domingo.TabIndex = 23;
            this.domingo.UseVisualStyleBackColor = true;
            // 
            // horaInicioText
            // 
            this.horaInicioText.Location = new System.Drawing.Point(159, 144);
            this.horaInicioText.Margin = new System.Windows.Forms.Padding(2);
            this.horaInicioText.Name = "horaInicioText";
            this.horaInicioText.Size = new System.Drawing.Size(32, 20);
            this.horaInicioText.TabIndex = 24;
            // 
            // duracionText
            // 
            this.duracionText.Location = new System.Drawing.Point(159, 202);
            this.duracionText.Margin = new System.Windows.Forms.Padding(2);
            this.duracionText.Name = "duracionText";
            this.duracionText.Size = new System.Drawing.Size(32, 20);
            this.duracionText.TabIndex = 25;
            // 
            // minimoText
            // 
            this.minimoText.Location = new System.Drawing.Point(159, 173);
            this.minimoText.Margin = new System.Windows.Forms.Padding(2);
            this.minimoText.Name = "minimoText";
            this.minimoText.Size = new System.Drawing.Size(32, 20);
            this.minimoText.TabIndex = 26;
            // 
            // maximoText
            // 
            this.maximoText.Location = new System.Drawing.Point(159, 231);
            this.maximoText.Margin = new System.Windows.Forms.Padding(2);
            this.maximoText.Name = "maximoText";
            this.maximoText.Size = new System.Drawing.Size(32, 20);
            this.maximoText.TabIndex = 27;
            // 
            // precioText
            // 
            this.precioText.Location = new System.Drawing.Point(159, 260);
            this.precioText.Margin = new System.Windows.Forms.Padding(2);
            this.precioText.Name = "precioText";
            this.precioText.Size = new System.Drawing.Size(32, 20);
            this.precioText.TabIndex = 28;
            // 
            // descripcionText
            // 
            this.descripcionText.Location = new System.Drawing.Point(159, 289);
            this.descripcionText.Margin = new System.Windows.Forms.Padding(2);
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.Size = new System.Drawing.Size(165, 20);
            this.descripcionText.TabIndex = 29;
            // 
            // botonAñadir
            // 
            this.botonAñadir.BackColor = System.Drawing.SystemColors.Control;
            this.botonAñadir.Location = new System.Drawing.Point(28, 366);
            this.botonAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.botonAñadir.Name = "botonAñadir";
            this.botonAñadir.Size = new System.Drawing.Size(107, 28);
            this.botonAñadir.TabIndex = 30;
            this.botonAñadir.Text = "Añadir actividad";
            this.botonAñadir.UseVisualStyleBackColor = false;
            this.botonAñadir.Click += new System.EventHandler(this.botonAñadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 321);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Salas (1-2-4...): ";
            // 
            // salasText
            // 
            this.salasText.Location = new System.Drawing.Point(159, 318);
            this.salasText.Margin = new System.Windows.Forms.Padding(2);
            this.salasText.Name = "salasText";
            this.salasText.Size = new System.Drawing.Size(88, 20);
            this.salasText.TabIndex = 32;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(230, 366);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(107, 28);
            this.buttonCancelar.TabIndex = 33;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "L     M     X     J     V     S     D";
            // 
            // AñadirAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(368, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.salasText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonAñadir);
            this.Controls.Add(this.descripcionText);
            this.Controls.Add(this.precioText);
            this.Controls.Add(this.maximoText);
            this.Controls.Add(this.minimoText);
            this.Controls.Add(this.duracionText);
            this.Controls.Add(this.horaInicioText);
            this.Controls.Add(this.domingo);
            this.Controls.Add(this.sabado);
            this.Controls.Add(this.viernes);
            this.Controls.Add(this.jueves);
            this.Controls.Add(this.miercoles);
            this.Controls.Add(this.martes);
            this.Controls.Add(this.lunes);
            this.Controls.Add(this.fechaFinAño);
            this.Controls.Add(this.fechaFinMes);
            this.Controls.Add(this.fechaFinDia);
            this.Controls.Add(this.fechaInicioAño);
            this.Controls.Add(this.fechaInicioMes);
            this.Controls.Add(this.fechaInicioDia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.duracion);
            this.Controls.Add(this.maximoAsistentes);
            this.Controls.Add(this.minimoAsistentes);
            this.Controls.Add(this.diasLMXJVSD);
            this.Controls.Add(this.dias);
            this.Controls.Add(this.horaInicio);
            this.Controls.Add(this.fechaFinalizacion);
            this.Controls.Add(this.fechaInicio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AñadirAct";
            this.Text = "Añadir Actividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fechaInicio;
        private System.Windows.Forms.Label fechaFinalizacion;
        private System.Windows.Forms.Label horaInicio;
        private System.Windows.Forms.Label dias;
        private System.Windows.Forms.Label diasLMXJVSD;
        private System.Windows.Forms.Label minimoAsistentes;
        private System.Windows.Forms.Label maximoAsistentes;
        private System.Windows.Forms.Label duracion;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fechaInicioDia;
        private System.Windows.Forms.TextBox fechaInicioMes;
        private System.Windows.Forms.TextBox fechaInicioAño;
        private System.Windows.Forms.TextBox fechaFinDia;
        private System.Windows.Forms.TextBox fechaFinMes;
        private System.Windows.Forms.TextBox fechaFinAño;
        private System.Windows.Forms.CheckBox lunes;
        private System.Windows.Forms.CheckBox martes;
        private System.Windows.Forms.CheckBox miercoles;
        private System.Windows.Forms.CheckBox jueves;
        private System.Windows.Forms.CheckBox viernes;
        private System.Windows.Forms.CheckBox sabado;
        private System.Windows.Forms.CheckBox domingo;
        private System.Windows.Forms.TextBox horaInicioText;
        private System.Windows.Forms.TextBox duracionText;
        private System.Windows.Forms.TextBox minimoText;
        private System.Windows.Forms.TextBox maximoText;
        private System.Windows.Forms.TextBox precioText;
        private System.Windows.Forms.TextBox descripcionText;
        private System.Windows.Forms.Button botonAñadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salasText;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label2;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestDep.Services;
using GestDep.Entities;

namespace GestDep.GUI.Forms
{
    public partial class AñadirAct : Form
    {
        private IGestDepService service;
        private Gym gimnasio;
        
        public AñadirAct(IGestDepService service, Gym g)
        {
            InitializeComponent();
            this.service = service;
            this.gimnasio = g;
        }

        private void botonAñadir_Click(object sender, EventArgs e)

        {
            Boolean ok = true;
            DateTime inicio=new DateTime(0);
            try
            {
                inicio = new DateTime(Convert.ToInt32(fechaInicioAño.Text), Convert.ToInt32(fechaInicioMes.Text), Convert.ToInt32(fechaInicioDia.Text));
            }
            catch (Exception)
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        "Fecha de inicio incorrecta.",      // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                ok = false;
                return;                           
            }

            DateTime fin= new DateTime(0);
            try
            {
                fin = new DateTime(Convert.ToInt32(fechaFinAño.Text), Convert.ToInt32(fechaFinMes.Text), Convert.ToInt32(fechaFinDia.Text));
            }
            catch (Exception)
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        "Fecha de finalizacion incorrecta.",// Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                ok = false;
                return;
            }

            Days diasActividad = Days.None;
            if (lunes.Checked) { diasActividad = diasActividad | Days.Mon; }
            if (martes.Checked) { diasActividad = diasActividad | Days.Tue; }
            if (miercoles.Checked) { diasActividad = diasActividad | Days.Wed; }
            if (jueves.Checked) { diasActividad = diasActividad | Days.Thu; }
            if (viernes.Checked) { diasActividad = diasActividad | Days.Fri; }
            if (sabado.Checked) { diasActividad = diasActividad | Days.Sat; }
            if (domingo.Checked) { diasActividad = diasActividad | Days.Sun; }

            DateTime horaInicioActividad = new DateTime(0);
            try
            {
                horaInicioActividad = Convert.ToDateTime(horaInicioText.Text + ":00");
            }
            catch (Exception)
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        "Hora de inicio incorrecta.",       // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                ok = false;
                return;
            }

            TimeSpan duracionActividad= new TimeSpan(0,0,0);
            try
            {
                duracionActividad = new TimeSpan(0, Convert.ToInt32(duracionText.Text), 0);
            }
            catch (Exception)
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        "Duracion incorrecta.",             // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                ok = false;
                return;
            }

            int minimoAsistentesActividad=0;
            try
            {
                minimoAsistentesActividad = Convert.ToInt32(minimoText.Text);
            }
            catch (Exception)
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        "Minimo de asistentes incorrecto.", // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                ok = false;
                return;
            }

            int maximoAsistentesActividad=0;
            try
            {
                maximoAsistentesActividad = Convert.ToInt32(maximoText.Text);
            }
            catch (Exception)
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        "Maximo de asistentes incorrecto.", // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                ok = false;
                return;
            }

            double precioActividad=0;
            try
            {
               
                precioActividad = Convert.ToDouble(precioText.Text);
            }
            catch (Exception)
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        "Precio incorrecto.",               // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                ok = false;
                return;
            }
            
            Activity nuevaActividad = new Activity(diasActividad, descripcionText.Text, duracionActividad, fin, maximoAsistentesActividad, minimoAsistentesActividad, precioActividad, inicio, horaInicioActividad);
            //string[] salas = salasText.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string salas = salasText.Text;
            //descripcion.Text = "";
            //foreach (string s in salas)
            for(int i = 0; i < salas.Length; i++)
            {
                try
                {
                    if (salas[i] > 47 && salas[i] < 58)
                    {
                        int numeroSala = (int)Char.GetNumericValue(salas, i);
                        //descripcion.Text = descripcion.Text + " " + Convert.ToInt32(c).ToString();
                        Room sala = gimnasio.FindRoom(numeroSala);
                        if (sala == null)
                        {
                            DialogResult answer = MessageBox.Show(this,                 // Owner
                                                    "Alguna de las salas indicada no existe, o no está disponible.",   // Message
                                                    "Error",                            // Title
                                                    MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                                    MessageBoxIcon.Exclamation);        // Icon
                            ok = false;
                            return;
                        }
                        nuevaActividad.AddRoom(sala);
                    }
                    else if (salas[i] == '-')
                    {
                        continue;
                    }
                    else
                    {
                        DialogResult answer = MessageBox.Show(this,                 // Owner
                                            "Formato de salas incorrecto.",     // Message
                                            "Error",                            // Title
                                            MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                            MessageBoxIcon.Exclamation);        // Icon
                        ok = false;
                        return;
                    }
                }
                catch (Exception)
                {
                    DialogResult answer = MessageBox.Show(this,                 // Owner
                                            "Formato de salas incorrecto.",     // Message
                                            "Error",                            // Title
                                            MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                            MessageBoxIcon.Exclamation);        // Icon
                    ok = false;
                    return;
                }
            }
            service.AddActivity(nuevaActividad);
            try
            {
                gimnasio.AddActivity(nuevaActividad);
            }
            catch (Exception ex)
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        ex.Message,                         // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                ok = false;
                return;
            }
            if (ok)
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        "Actividad añadida correctamente.", // Message
                                        "Información",                      // Title
                                        MessageBoxButtons.OK,               // Buttons included
                                        MessageBoxIcon.Information);        // Icon
                fechaInicioAño.Text = "";
                fechaInicioMes.Text = "";
                fechaInicioDia.Text = "";
                fechaFinAño.Text = "";
                fechaFinMes.Text = "";
                fechaFinDia.Text = "";
                horaInicioText.Text = "";
                duracionText.Text = "";
                minimoText.Text = "";
                maximoText.Text = "";
                precioText.Text = "";
                salasText.Text = "";
                descripcionText.Text = "";
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

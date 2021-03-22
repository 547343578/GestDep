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
    public partial class Salas : Form
    {
        private IGestDepService service;
        private Gym gym;
        private DateTime inicio, fecha, dia, fin;
       
        public Salas(IGestDepService service, Gym g)
        {
            InitializeComponent();
            this.service = service;
            this.gym = g;
            LoadData();
        }

        private void LoadData()
        {
            ICollection<Gym> gyms = service.GetAllGyms();
            GymComboBox.Items.Clear();
            if (gyms != null) 
            {
                foreach (Gym g in gyms) 
                {
                    GymComboBox.Items.Add(g.Name);
                }
            }
            GymComboBox.SelectedIndex = -1;
            GymComboBox.ResetText();
            bindingSource1.DataSource = null;
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Botoncancelar(object sender, EventArgs e)
        {
            Close();
        }

        private void GymComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gym = service.FindGymByName((string)GymComboBox.SelectedItem);
        }

        private void buttonMostrarSalas_Click(object sender, EventArgs e)
        {
            if (calendario.SelectionStart.DayOfWeek.CompareTo(DayOfWeek.Monday) != 0)
            {

                DialogResult answer = MessageBox.Show(this,                 // Owner
                                       "Dia seleccionado no válido.",       // Message
                                       "Error",                             // Title
                                       MessageBoxButtons.AbortRetryIgnore,  // Buttons included
                                       MessageBoxIcon.Exclamation);         // Icon
                return;
            }
            BindingList<object> list = new BindingList<object>();
            list.Clear();
            inicio = gym.OpeningHour;
            fin = inicio.AddMinutes(45);
            fecha = calendario.SelectionStart.Date;
            dia = fecha.AddHours(inicio.Hour).AddMinutes(inicio.Minute);

            while (inicio < gym.ClosingHour)
            {
                string auxHora = inicio.ToString("HH:mm") + "-" + fin.ToString("HH: mm");
                list.Add(new
                {
                    hora = auxHora,
                    Lunes = gym.GetFreeRooms(dia, Days.Mon),
                    Martes = gym.GetFreeRooms(dia.AddDays(1), Days.Tue),
                    Miercoles = gym.GetFreeRooms(dia.AddDays(2), Days.Wed),
                    Jueves = gym.GetFreeRooms(dia.AddDays(3), Days.Thu),
                    Viernes = gym.GetFreeRooms(dia.AddDays(4), Days.Fri),
                    Sabado = gym.GetFreeRooms(dia.AddDays(5), Days.Sat),
                });

                inicio = inicio.AddMinutes(45);
                fin = fin.AddMinutes(45);
                dia = dia.AddMinutes(45);
            }
            bindingSource1.DataSource = list;
            /*
            if (calendario.SelectionStart.DayOfWeek.CompareTo(DayOfWeek.Monday)!=0){

                DialogResult answer = MessageBox.Show(this,                 // Owner
                                       "Dia seleccionado no válido.",       // Message
                                       "Error",                             // Title
                                       MessageBoxButtons.AbortRetryIgnore,  // Buttons included
                                       MessageBoxIcon.Exclamation);         // Icon
            }
            BindingList<object> list = new BindingList<object>();
            list.Clear();
            
            inicio = gym.OpeningHour;
            diaCalendario=calendario.SelectionStart;
            fecha = diaCalendario.Date;
            dia = fecha.AddHours(inicio.Hour).AddMinutes(inicio.Minute);
            */
            /*
            if (calendario.SelectionStart.DayOfWeek.CompareTo(DayOfWeek.Monday)!=0){

                DialogResult answer = MessageBox.Show(this,                 // Owner
                                       "Dia seleccionado no válido.",       // Message
                                       "Error",                             // Title
                                       MessageBoxButtons.AbortRetryIgnore,  // Buttons included
                                       MessageBoxIcon.Exclamation);         // Icon
            }
            */
            /*diaCalendario = calendario.SelectionStart.Date;
            while (diaCalendario.DayOfWeek.CompareTo(DayOfWeek.Monday) != 0)
            {
                diaCalendario.AddDays(-1);
            }

            BindingList<object> list = new BindingList<object>();
            list.Clear();

            inicio = gym.OpeningHour;
            fecha = diaCalendario.Date;
            dia = fecha.AddHours(inicio.Hour).AddMinutes(inicio.Minute);

            while (inicio < gym.ClosingHour)
            {
                list.Add(new
                {
                    hora = inicio.TimeOfDay + "-" + inicio.AddMinutes(45).TimeOfDay,
                    Lunes = gym.GetFreeRooms(dia, Days.Mon),
                    Martes = gym.GetFreeRooms(dia.AddDays(1), Days.Tue),
                    Miercoles = gym.GetFreeRooms(dia.AddDays(2), Days.Wed),
                    Jueves = gym.GetFreeRooms(dia.AddDays(3), Days.Thu),
                    Viernes = gym.GetFreeRooms(dia.AddDays(4), Days.Fri),
                    Sabado = gym.GetFreeRooms(dia.AddDays(5), Days.Sat),
                });

                inicio = inicio.AddMinutes(45);
                dia = dia.AddMinutes(45);
            }
            bindingSource1.DataSource = list;*/
        }
    }
}

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
    public partial class SelectMonitor : Form
    {
        private IGestDepService service;
        private Activity activity;
        private List<Instructor> instructorsLibres = new List<Instructor>();
        private Instructor instructorSeleccionado;
        public SelectMonitor(IGestDepService service,Activity activity)
        {
            InitializeComponent();
            this.service = service;
            this.activity = activity;
            LoadData();
        }

        private void LoadData()
        {
            ICollection<Instructor> instructors = service.GetAllInstructors();
            monitorCombox.Items.Clear();
            if (instructors != null)
            {
                foreach (Instructor i in service.GetAllInstructors())
                {
                    bool check = true;
                    foreach (Activity a in i.Activities)
                    {
                        if (!(a.StartDate > activity.FinishDate || a.FinishDate < activity.StartDate))
                        {
                            if ((a.ActivityDays & activity.ActivityDays) != 0)
                            {
                                if (!(a.StartHour > (activity.StartHour + activity.Duration)
                                      || (a.StartHour + a.Duration) < activity.StartHour))
                                {
                                    check = false;
                                }
                            }
                        }
                    }
                    if (check == true)
                    {
                        monitorCombox.Items.Add(i.Name);
                        instructorsLibres.Add(i);
                    }
                }
            }
            monitorCombox.SelectedIndex = -1;
            monitorCombox.ResetText();
        }

        private void monitorCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux = monitorCombox.SelectedIndex;
            instructorSeleccionado = instructorsLibres.ElementAt(aux);
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            Instructor monitor = instructorSeleccionado;
            if (monitor != null)
            {
                activity.SetInstructor(monitor);
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                            "El monitor ya esta asignado correctamente.", // Message
                                            "Confirmacion",                 // Title
                                            MessageBoxButtons.OK,           // Buttons included
                                            MessageBoxIcon.Information);    // Icon
                Close();
            }
            else {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                            "Seleccionar un monitor por favor.", // Message
                                            "Error",                        // Title
                                            MessageBoxButtons.RetryCancel,  // Buttons included
                                            MessageBoxIcon.Exclamation);    // Icon
            }
            
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

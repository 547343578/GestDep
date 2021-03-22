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
    public partial class AñadirMonitor : Form
    {
        private IGestDepService service;
        private Activity activity;
        public AñadirMonitor(IGestDepService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        private void LoadData()
        {
            ICollection<Activity> activities = service.GetAllActivities();
            activityCombox.Items.Clear();
            if (activities != null)
            {
                foreach (Activity a in activities)
                {
                    activityCombox.Items.Add(a.Description);
                }
            }
            activityCombox.SelectedIndex = -1;
            activityCombox.ResetText();
            AddMonitorBindingSource.DataSource = null;
        }

        private void activityCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string description = (string)activityCombox.SelectedItem;
            this.activity = service.FindActivityByName(description);
            
            BindingList<object> bingdingList = new BindingList<object>();
            
            string nameMonitor = "";
            if (activity.Instructor != null) {
                 nameMonitor = activity.Instructor.Name;
               }  
               bingdingList.Add(new
                  {  
                      ds_day = activity.ActivityDays,
                      ds_name = activity.Description,
                      ds_duration = activity.Duration,
                      ds_iniDate = activity.StartDate,
                      ds_finDate = activity.FinishDate,
                      ds_iniTime = activity.StartHour,
                      ds_min = activity.MinimumEnrollments,
                      ds_max = activity.MaximumEnrollments,
                      ds_precio = activity.Price,
                      ds_monitor = nameMonitor
                  }
              );

            AddMonitorBindingSource.DataSource = bingdingList;
            
        }

        private void AddMonitor_Click(object sender, EventArgs e)
        {
            if (activityCombox.SelectedItem == null)
            {
                DialogResult answer = MessageBox.Show(this,                     // Owner
                                       "Selecciona una actividad por favor.",   // Message
                                       "Error",                                 // Title
                                       MessageBoxButtons.RetryCancel,           // Buttons included
                                       MessageBoxIcon.Exclamation);             // Icon
            }
            else
            {
                if (activity.Instructor != null)
                {
                    DialogResult answer = MessageBox.Show(this,                     // Owner
                                            "La actividad seleccionada ya tiene un monitor asignado", // Message
                                            "Error",                                // Title
                                            MessageBoxButtons.RetryCancel,          // Buttons included
                                            MessageBoxIcon.Exclamation);            // Icon
                }
                else
                {
                    SelectMonitor selectMonitor = new SelectMonitor(service, activity);
                    selectMonitor.ShowDialog();
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (activityCombox.SelectedItem == null)
            {
                DialogResult answer = MessageBox.Show(this,                     // Owner
                                        "Es necesario seleccionar una actividad.", // Message
                                        "Error",                                // Title
                                        MessageBoxButtons.OK,                   // Buttons included
                                        MessageBoxIcon.Exclamation);            // Icon
            }
            else
            {
                if (activity.Instructor == null)
                {
                    DialogResult answer = MessageBox.Show(this,                     // Owner
                                            "Es necesario asignar un instructor a la actividad.", // Message
                                            "Error",                                // Title
                                            MessageBoxButtons.RetryCancel,          // Buttons included
                                            MessageBoxIcon.Exclamation);            // Icon
                }
                else
                {
                    Close();
                }
            }
        }
    }
}

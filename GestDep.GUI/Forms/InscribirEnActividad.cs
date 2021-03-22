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
    public partial class InscribirEnActividad : Form
    {
        private IGestDepService service;
        private Activity actividadSeleccionada;
        private User usuarioSeleccionado;
        private CityHall ciudad;
        private Gym gimnasio;
        private double precio;

        public InscribirEnActividad(IGestDepService service, CityHall c, Gym g)
        {
            InitializeComponent();
            this.service = service;
            this.ciudad = c;
            this.gimnasio = g;
            LoadData();
        }
        private void LoadData()
        {
            ICollection<Activity> actividades = service.GetAllActivities();
            comboBoxActividades.Items.Clear();
            if (actividades != null)
            {
                foreach (Activity a in actividades)
                {
                    if (a.FinishDate > DateTime.Today)
                    {
                        comboBoxActividades.Items.Add(a.Description);
                    }
                }
            }
            comboBoxActividades.SelectedIndex = -1;
            comboBoxActividades.ResetText();
        }

        private void comboBoxActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            actividadSeleccionada = service.FindActivityByName((string)comboBoxActividades.SelectedItem);
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            añadirUsrButton.Enabled = false;
            String dni = textBoxDNI.Text;
            usuarioSeleccionado = service.FindUserById(dni);
            if (usuarioSeleccionado == null)
            {
                labelNombre.Text = "";
                labelDireccion.Text = "";
                labelCodigoPostal.Text = "";
                labelFechaNacimiento.Text = "";
                labelRetirado.Text = "";
                labelPrecio.Text = "00.00";
                if (dni.Length == 9)
                {
                    bool res = true;
                    for (int i = 0; i < 8; i++)
                    {
                        if (dni[i] < 48 || dni[i] > 57)
                        {
                            res = false;
                            break;
                        }
                    }
                    string aux = dni.ToLower();
                    if (aux[8] > 96 && aux[8] < 123 && res)
                    {
                        añadirUsrButton.Enabled = true;
                    }
                }
            }
            else
            {
                labelNombre.Text = usuarioSeleccionado.Name;
                labelDireccion.Text = usuarioSeleccionado.Address;
                labelCodigoPostal.Text = usuarioSeleccionado.ZipCode.ToString();
                labelFechaNacimiento.Text = usuarioSeleccionado.BirthDate.ToString();
                if (usuarioSeleccionado.Retired)
                {
                    labelRetirado.Text = "Sí";
                }
                else
                {
                    labelRetirado.Text = "No";
                }
                precio = actividadSeleccionada.GetPriceForUser(gimnasio, usuarioSeleccionado);
                labelPrecio.Text = precio.ToString("N2");
            }
        }

        private void inscribirButton_Click(object sender, EventArgs e)
        {
            if (comboBoxActividades.SelectedIndex == -1)
            {
                DialogResult ans = MessageBox.Show(this,                 // Owner
                                    "Se debe seleccionar una actividad.",// Message
                                    "Error",                             // Title
                                    MessageBoxButtons.AbortRetryIgnore,  // Buttons included
                                    MessageBoxIcon.Exclamation);         // Icon
                return;
            }
            else if (usuarioSeleccionado == null)
            {
                if (añadirUsrButton.Enabled)
                {
                    DialogResult ans = MessageBox.Show(this,                // Owner
                                        "Usuario no registrado, puede añadirlo si lo desea.", // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                    return;
                } else
                {
                    DialogResult ans = MessageBox.Show(this,                // Owner
                                        "DNI no válido.",                   // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                    return;
                }
            } 
            Payment pago = new Payment(DateTime.Today, "First quota", precio);
            ciudad.AddPayment(pago);  
            Enrollment matricula = new Enrollment(DateTime.Today, actividadSeleccionada, pago, usuarioSeleccionado);
            service.AddEnrollment(matricula);
            DialogResult answer = MessageBox.Show(this,                 // Owner
                                    "Usuario inscrito correctamente.",  // Message
                                    "Información",                      // Title
                                    MessageBoxButtons.OK,               // Buttons included
                                    MessageBoxIcon.Information);        // Icon
            textBoxDNI.Text = "";
         }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void añadirUsrButton_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado != null)
            {
                DialogResult ans = MessageBox.Show(this,                    // Owner
                                        "Ya se ha registrado una persona con este DNI.", // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                return;
            }
            AñadirUsuario añadirUsuario = new AñadirUsuario(service, ciudad, textBoxDNI.Text);
            añadirUsuario.ShowDialog();
        }
    }
}

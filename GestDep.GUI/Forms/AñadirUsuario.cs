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
    public partial class AñadirUsuario : Form
    {
        private IGestDepService service;
        private CityHall city;
        public AñadirUsuario(IGestDepService service, CityHall city)
        {
            InitializeComponent();
            this.service = service;
            this.city = city;
        }
        public AñadirUsuario(IGestDepService service, CityHall city, String s)
        {
            InitializeComponent();
            this.service = service;
            this.city = city;
            dni.Text = s;
        }

        private void BotonAddUser(object sender, EventArgs e)

        {
            Boolean ok = true;
            if (string.IsNullOrEmpty(nombre.Text))
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                       "No ha introducido el nombre.",      // Message
                                       "Error",                             // Title
                                       MessageBoxButtons.AbortRetryIgnore,  // Buttons included
                                       MessageBoxIcon.Exclamation);         // Icon
                ok = false;
                return;
            }

            if (string.IsNullOrEmpty(dni.Text))
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                      "No ha introducido el DNI.",          // Message
                                      "Error",                              // Title
                                      MessageBoxButtons.AbortRetryIgnore,   // Buttons included
                                      MessageBoxIcon.Exclamation);          // Icon
                ok = false;
                return;
            }

            if (string.IsNullOrEmpty(direccion.Text))
            {
                DialogResult answer = MessageBox.Show(this,                     // Owner
                                          "No ha introducido la dirección.",     // Message
                                          "Error",                              // Title
                                          MessageBoxButtons.AbortRetryIgnore,   // Buttons included
                                          MessageBoxIcon.Exclamation);          // Icon
                ok = false;
                return;
            }

            int codigopostal = 0;
            try
            {
                codigopostal = Convert.ToInt32(cp.Text);
            }
            catch (Exception)
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        "Código postal incorrecto.",  // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);
                ok = false;
                return;
            }

            if (string.IsNullOrEmpty(iban.Text))
            {
                DialogResult answer = MessageBox.Show(this,                     // Owner
                                          "No ha introducido el número de cuenta.", // Message
                                          "Error",                              // Title
                                          MessageBoxButtons.AbortRetryIgnore,   // Buttons included
                                          MessageBoxIcon.Exclamation);          // Icon
                ok = false;
                return;
            }

            DateTime fecha = new DateTime(0);
            try
            {
                fecha = new DateTime(Convert.ToInt32(año.Text), Convert.ToInt32(mes.Text), Convert.ToInt32(dia.Text));
            }
            catch (Exception)
            {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        "Fecha de nacimiento incorrecta.",  // Message
                                        "Error",                            // Title
                                        MessageBoxButtons.AbortRetryIgnore, // Buttons included
                                        MessageBoxIcon.Exclamation);        // Icon
                ok = false;
                return;
            }

            bool jubilado = false;
            if (jubsi.Checked) { jubilado = true; }

            User nuevoUsuario = new User(direccion.Text, iban.Text, dni.Text, nombre.Text, codigopostal, fecha, jubilado);       
            
            try
            {
                city.AddPerson(nuevoUsuario);
                service.AddUser(nuevoUsuario);
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

            if (ok) {
                DialogResult answer = MessageBox.Show(this,                 // Owner
                                        "Usuario añadido correctamente.",   // Message
                                        "Información",                      // Title
                                        MessageBoxButtons.OK,               // Buttons included
                                        MessageBoxIcon.Information);        // Icon
                nombre.Text = "";
                dni.Text = "";
                direccion.Text = "";
                cp.Text = "";
                iban.Text = "";
                año.Text = "";
                mes.Text = "";
                dia.Text = "";
            }
         }

        private void botoncancelar(object sender, EventArgs e)
        {
            Close();
        }
    }
}

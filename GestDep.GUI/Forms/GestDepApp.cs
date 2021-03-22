using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestDep.GUI.Forms;
using GestDep.Services;
using GestDep.Entities;


namespace GestDep.GUI
{
    public partial class GestDepApp : Form
    {
        private IGestDepService service;
        private CityHall ciudad;
        private Gym gimnasio;
   
        public GestDepApp(IGestDepService service) 
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        private void LoadData()
        {
            ciudad = service.FindCityHallByName("Valencia");
            gimnasio = service.FindGymByName("Gym1");
        }

        private void añadirActividad(object sender, EventArgs e)
        {
            AñadirAct añadir = new AñadirAct(service, gimnasio);
            añadir.ShowDialog();
        }

        private void añadirMonitor(object sender, EventArgs e)
        {
            AñadirMonitor añadirMonitor = new AñadirMonitor(service);
            añadirMonitor.ShowDialog();
        }

        private void inscribirUsuario(object sender, EventArgs e)
        {
            InscribirEnActividad inscribirEnActividad = new InscribirEnActividad(service, ciudad, gimnasio);
            inscribirEnActividad.ShowDialog();
        }

        private void añadirUsuario(object sender, EventArgs e)
        {
            AñadirUsuario añadirUsuario = new AñadirUsuario(service, ciudad);
            añadirUsuario.ShowDialog();
        }
        
        private void salasLibres(object sender, EventArgs e)
        {
            Salas salas = new Salas(service, gimnasio);
            salas.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestDep.Services;

namespace GestDep.Entities
{
    public partial class CityHall
    {
        public CityHall() 
        {
            People = new List<Person>();
            Payments = new List<Payment>();
            Gyms = new List<Gym>();
        }

        public CityHall(string name) : this()
        {
            //Id is managed by EE
            this.Name = name;
            this.People = new List<Person>();
            this.Payments = new List<Payment>();
            this.Gyms = new List<Gym>();
        }

        public void AddGym(Gym gym)
        {
            this.Gyms.Add(gym);
        }

        public Gym FindGymByName(string name)
        {
            foreach (Gym g in this.Gyms)
            {
                if (g.Name == name) { return g; }
            }
            return null;
        }

        public List<Instructor> LookForInstructors(Activity a)
        {
            if (a.Instructor != null)
            {
                List<Instructor> instructoresDisponibles = new List<Instructor>();
                foreach (Person p in this.People)
                {
                    if (p is Instructor)
                    {
                        Instructor i = (Instructor)p;
                        bool res = true;
                        foreach(Activity act_existente in i.Activities)
                        {
                            if (!(act_existente.StartDate > a.FinishDate || act_existente.FinishDate < a.StartDate))
                            {
                                if ((act_existente.ActivityDays & a.ActivityDays) != 0)
                                {
                                    if (!(act_existente.StartHour > (a.StartHour + a.Duration) 
                                          || (act_existente.StartHour + act_existente.Duration) < a.StartHour))
                                    {
                                        res = false;
                                        break;
                                    }
                                }
                            }
                        }
                        if (res == true) { instructoresDisponibles.Add(i); }
                    }
                }
                if (instructoresDisponibles == null || instructoresDisponibles.Count == 0)
                {
                    throw new ServiceException("No hay monitores disponibles para el horario.");
                }
                return instructoresDisponibles;
            }
            return null;
        }
        public void AddPerson(Person p)
        {
            foreach (Person persona in this.People)
            {
                if (persona.Id == p.Id)
                {
                    throw new ServiceException("Ya existe un usuario con este DNI. Vuelva a introducir los datos.");
                }
            }
            this.People.Add(p);
        }

        public void AddPayment(Payment p)
        {
            this.Payments.Add(p);
        }

        public bool HayUsuario(string id)
        {
            foreach(Person persona in People)
            {
                if (persona.Id.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

  
    }
}
